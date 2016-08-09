using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Xml;
using System.Xml.Schema;
using System.IO;
using System.Threading.Tasks;

namespace Overstor
{
    class DataBase : DataSet
    {
        public bool LoadDB(string path)
        {
            try
            {
                FileStream fs = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                XmlTextReader xml_read = new XmlTextReader(fs);
                Tables.Clear();
                ReadXml(xml_read, XmlReadMode.InferSchema);
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool SaveDB(string path)
        {
            try 
            { 
                FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
                XmlTextWriter xml_writer = new XmlTextWriter(fs, Encoding.UTF8);
                WriteXml(path, XmlWriteMode.IgnoreSchema);
                fs.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public void CreateDB(string name, List<string> cols_name)
        {
            try
            {
                DataTable data_table = new DataTable();
                data_table.TableName = name;

                // Insert columns
                for (int i = 0; i < cols_name.Count; i++)
                {
                    data_table.Columns.Add();
                    data_table.Columns[i].ColumnName = cols_name[i];
                }

                Tables.Clear();
                Tables.Add(data_table);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

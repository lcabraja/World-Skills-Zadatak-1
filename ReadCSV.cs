using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace World_Skills_Zadatak_1
{
    public class ReadCSV
    {
        public DataTable readCSV;
        private class fieldProperties {
            public int index;
            public Type type;
        }
        public ReadCSV(string filename, bool firstRowContainsFieldNames = true)
        {
            readCSV = GenerateDataTable(filename, firstRowContainsFieldNames);
        }
        private static DataTable GenerateDataTable(string filename, bool firstRowContainsFieldNames = true)
        {
            DataTable result = new DataTable();
            DataTable importantResult = new DataTable();
            var importantFields = new Dictionary<string, fieldProperties>()
            {
                {"proper", new fieldProperties { index = 0, type = null} },
                {"dist", new fieldProperties { index = 0, type = null}},
                {"mag", new fieldProperties { index = 0, type = null}}
            };

            if (filename == "")
            {
                return result;
            }

            string delimiters = ",";
            string extension = Path.GetExtension(filename);

            if (extension.ToLower() == "txt")
                delimiters = "\t";
            else if (extension.ToLower() == "csv")
                delimiters = ",";

            using (TextFieldParser tfp = new TextFieldParser(filename))
            {
                tfp.SetDelimiters(delimiters);

                // Get the Column Names
                if (!tfp.EndOfData)
                {
                    string[] fields = tfp.ReadFields();

                    for (int i = 0; i < fields.Count(); i++)
                    {
                        if (firstRowContainsFieldNames)
                            result.Columns.Add(fields[i]);
                        else
                            result.Columns.Add("Col" + i);
                    }

                    // If first line is data then add it
                    if (!firstRowContainsFieldNames)
                        result.Rows.Add(fields);
                }
                //Get Remaining Rows from the CSV
                while (!tfp.EndOfData)
                    result.Rows.Add(tfp.ReadFields());
            }
 
            // Find the relevant column indexes, and data types ... they're all strings because why wouldn't they be...
            for(int i = 0; i < result.Columns.Count; i++)
            {
                if (importantFields.ContainsKey(result.Columns[i].ColumnName))
                {
                    importantFields[result.Columns[i].ColumnName].index = i;
                    importantFields[result.Columns[i].ColumnName].type = result.Columns[i].DataType;
                }
            }
            
            foreach (string key in importantFields.Keys)
                importantResult.Columns.Add(key, importantFields[key].type);

            // Finds only the relevant rows and columns from the full array
            foreach (DataRow dr in result.Rows)
            {
                DataRow newRow = importantResult.NewRow();
                foreach (string column in importantFields.Keys)
                    newRow[column] = dr.ItemArray[importantFields[column].index];
                //if (newRow.ItemArray[0].ToString().Length.Equals(0))
                //    continue;
                importantResult.Rows.Add(newRow);
            }

            return importantResult;
        }
    }
}

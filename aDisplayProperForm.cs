using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_Skills_Zadatak_1
{
    public partial class aDisplayProperForm : Form
    {
        public aDisplayProperForm()
        {
            InitializeComponent();
        }

        public string connectionString { get; set; }
        public string tableName { get; set; }
        public DataTable import { get; set; }

        private DataTable display = new DataTable();

        private string[] preEditedCell = { "", "", "" };
        private string[] postEditedCell = { "", "", "" };
        void extractProper()
        {
            foreach (DataColumn dc in import.Columns)
                display.Columns.Add(dc.ColumnName);
            foreach (DataRow dr in import.Rows)
            {
                if (dr.ItemArray[0].ToString().Length.Equals(0)) continue;
                DataRow newRow = display.NewRow();
                for (int i = 0; i < display.Columns.Count; i++)
                {
                    newRow[display.Columns[i].ColumnName] = dr.ItemArray[i];
                }
                //if (newRow.ItemArray[0].ToString().Length.Equals(0))
                //    continue;
                display.Rows.Add(newRow);
            }

            aDisplay.DataSource = display;
        }

        private void aTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = "aaa";
            if (display.Columns.Count == 0)
                if (import.IsInitialized)
                {
                    extractProper();
                    aTimer.Stop();
                }
        }

        private void aDisplay_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            int i = 0;
            foreach (string s in (aDisplay.DataSource as DataTable).Rows[aDisplay.CurrentCell.RowIndex].ItemArray)
                preEditedCell[i++] = s;
            label1.Text = preEditedCell[0];
            label2.Text = preEditedCell[1];
            label3.Text = preEditedCell[2];
        }

        private void aDisplay_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(!aDisplay.CurrentCell.Value.Equals(preEditedCell[aDisplay.CurrentCell.ColumnIndex]))
                    updateDB();
        }
        private void updateDB()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string valueName = aDisplay.CurrentCell.OwningColumn.Name;
                string valueToSet = aDisplay.CurrentCell.Value.ToString();
                string properName = preEditedCell[0];
                Debug.WriteLine($@"UPDATE [{tableName}] SET {valueName} = '{valueToSet}' WHERE upper(proper) like upper('{properName}')", connection);
                SqlCommand command = new SqlCommand($@"UPDATE {tableName} SET {valueName} = '{valueToSet}' WHERE proper = '{properName}'", connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}

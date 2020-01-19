using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
namespace World_Skills_Zadatak_1
{
    public partial class aOpenFileForm : Form
    {
        public aOpenFileForm()
        {
            InitializeComponent();
        }

        private DataTable export;

        private void aBrowseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "CSV File|*.csv" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    aTextBox.Text = openFileDialog.FileName;
                }
            }
        }
        private void aReadFileButton_Click(object sender, EventArgs e)
        {
            string address = @"C:\Users\doss\Downloads\HYG-Database-master\hygdata_v3.csv";
            try
            {
                ReadCSV csv = new ReadCSV(address);//aTextBox.Text);
                try
                {
                    export = csv.readCSV;
                    aDatabaseView.DataSource = export;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public List<string> dataTables;
        private void aConnectButton_Click(object sender, EventArgs e)
        {
            getTables(getConnectionString());
        }
        private void aImportButton_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (export.Equals(null))
                        throw new Exception();

                    string connectionString = getConnectionString();

                    //Open a connection with destination database;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        //Open bulkcopy connection.
                        using (SqlBulkCopy bulkcopy = new SqlBulkCopy(connection))
                        {
                            //Set destination table name
                            //to table previously created.
                            bulkcopy.DestinationTableName = $"dbo.{aTableBox.SelectedItem}";

                            try
                            {
                                bulkcopy.WriteToServer(export);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            connection.Close();
                        }

                        MessageBox.Show("Database Import Complete", "Woo Hoo!", MessageBoxButtons.OK);
                        aDisplayProperForm proper = new aDisplayProperForm();
                        proper.import = export;
                        proper.connectionString = getConnectionString();
                        proper.tableName = aTableBox.Text;
                        this.Hide();
                        proper.Show();
                        
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }
        private void updateConnectionString(object sender, EventArgs e)
        {
            aConnectionStringBox.Text = $@"server={aServerBox.Text};database={aDatabaseBox.Text};UID={aUsernameBox.Text};password={aPasswordBox.Text};";
        }
        public void getTables(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                DataTable schema = connection.GetSchema("Tables");
                List<string> TableNames = new List<string>();
                foreach (DataRow row in schema.Rows)
                {
                    TableNames.Add(row[2].ToString());
                }
                dataTables = TableNames;
                aTableBox.DataSource = TableNames;
            }
        }
        public string getConnectionString()
        {
            return aConnectionStringBox.Text;
        }

        //return @"server=localhost\STARPLATINUM;database=testdb1;UID=sa;password=123456789;";
    }
}
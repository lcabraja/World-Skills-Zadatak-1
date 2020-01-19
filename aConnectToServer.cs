using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace World_Skills_Zadatak_1
{
    public partial class aConnectToServer : UserControl
    {

        public aConnectToServer()
        {
            InitializeComponent();
        }

        public DataTable upload;

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
                    if (upload.Equals(null))
                        return;

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
                                bulkcopy.WriteToServer(upload);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            connection.Close();
                        }
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

    }
}

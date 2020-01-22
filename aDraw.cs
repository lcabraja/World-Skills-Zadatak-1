using System;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Collections.Generic;

namespace World_Skills_Zadatak_1
{
    public partial class aDraw : Form
    {
        public aDraw()
        {
            InitializeComponent();
        }

        public DataTable display = new DataTable();
        public DataTable import = new DataTable();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aDraw_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Debug.WriteLine("waaa");
            //if (Application.OpenForms.Count.Equals(0))
            //    Application.Exit();
        }

        private void aDraw_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine("wooo");
            if (Application.OpenForms.Count.Equals(0))
                Application.Exit();
        }

        private void simple()
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
                display.Rows.Add(newRow);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            simple();
            var hold = aChart.Series[0].Points.Count;
            Debug.WriteLine(hold);
            arrangeData();
            timer1.Stop();
        }
        private void arrangeData()
        {
            for (int i = 0; i < 10; i++)
            {
                DataRow dr = display.Rows[i];
                aChart.Series[0].ChartType = SeriesChartType.Bubble;
                double x = Convert.ToDouble(dr.ItemArray[1].ToString());
                double y = Convert.ToDouble(dr.ItemArray[2].ToString());
                aChart.Series[0].Points.Add(x, x, y);
                //DataPoint dp = new DataPoint();
                //dp.XValue = x;
                //dp.YValues = { x, y };
                aChart.Series[0].Points[i].Label = dr.ItemArray[0].ToString();
                //Debug.WriteLine(dr.ItemArray[0].ToString() + " dist: " + dr.ItemArray[1].ToString() + " mag: " + dr.ItemArray[2]);
            }
        }
    }
}

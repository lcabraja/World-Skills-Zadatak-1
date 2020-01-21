using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace World_Skills_Zadatak_1
{
    public partial class aDraw : Form
    {
        public aDraw()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void aDraw_FormClosed(object sender, FormClosedEventArgs e)
        {
            Debug.WriteLine("waaa");
            if (Application.OpenForms.Count.Equals(0))
                Application.Exit();
        }

        private void aDraw_FormClosing(object sender, FormClosingEventArgs e)
        {
            Debug.WriteLine("wooo");
            if (Application.OpenForms.Count.Equals(0))
                Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dogao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BTNrestaurar.Visible = false;
        }

        private void BTNfechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BTNmaximizar.Visible = true;
            BTNrestaurar.Visible = false;
        }

        private void BTNmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BTNmaximizar.Visible = false;
            BTNrestaurar.Visible = true;
        }
    }
}

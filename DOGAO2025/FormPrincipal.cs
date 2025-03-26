using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace DOGAO2025
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 cadastrar = new Form1();
            cadastrar.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BTNrestaurar.Visible = true;
        }

        private void BTNrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BTNrestaurar.Visible = false;
            BTNmaximizar.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized) 
            {
                BTNrestaurar.Visible = true;;
            }
            else
            {
                BTNrestaurar.Visible = false;
            }
        }
    }
}

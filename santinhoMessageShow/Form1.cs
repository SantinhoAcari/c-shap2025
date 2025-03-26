using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace santinhoMessageShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("msn Simples" + "\n" + "   ❤️ Santinho", "Alerta Simples do Santinho");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("msn simples com Título", "❤️ santinho no título");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult retorno = MessageBox.Show("Santinho ❤️",
                                                    "Vamos Estudar C#",
                                                    MessageBoxButtons.YesNo);
            if (retorno == DialogResult.Yes)
            {
                MessageBox.Show("Gostei, vc Clicou em Sim", "❤️ santinho nota 10");
            }
            else if (retorno == DialogResult.No)
            {
                MessageBox.Show("que pena você clicou em não", "❤️ Santinho");
            }
        }
    }
}

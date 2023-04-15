using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ValorDigitado;
            ValorDigitado = Convert.ToInt32(txtValor.Text);
            for(int i = 0; i <=10; i++)
            {
               listBoxTabu.Items.Add(i + "X" + ValorDigitado + "=" + (i * ValorDigitado));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxTabu.Items.Clear();
            txtValor.Clear();
            txtValor.Focus();
        }
    }
}

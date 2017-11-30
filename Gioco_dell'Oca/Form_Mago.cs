using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Gioco_dell_Oca
{
    public partial class Form_Mago : Form
    {
        Mago temp = new Mago();
        public Form_Mago()
        {
            InitializeComponent();
        }

        private void Form_Mago_Load(object sender, EventArgs e)
        {
            label1.Text = temp.Domanda;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tempo;
            tempo = textBox1.Text;
            if (tempo == temp.Risposta)
                this.Hide();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DECLARARAAS VARIAVEIS
            int Tcel, Tkel, Tfah;
            //LER A TEMPERATURA EM CELCIUS A SER CONVERTIDA
            Tcel = int.Parse(textBox1.Text);
            //CALCULANDO AS CONVERSOES
            Tkel = Tcel + 273;
            Tfah = (((Tcel * 9) / 5) + 32);
            //converter o resultado para  string
            //dessa forma conseguimos exibir o resultado
            label3.Text = Tkel.ToString();
            label5.Text = Tfah.ToString();

        }
    }
}

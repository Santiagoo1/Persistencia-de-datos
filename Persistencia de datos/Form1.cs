﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persistencia_de_datos
{
    public partial class Form1 : Form
        
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void productos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = productos.Rows.Add();

            productos.Rows[n].Cells[0].Value = Nombreproducto.Text;
            productos.Rows[n].Cells[1].Value = CodigoProducto.Text;
            productos.Rows[n].Cells[2].Value = Precioproducto.Text;


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nombreproducto.Text = "";
            CodigoProducto.Text = "";
            Precioproducto.Text = "";
            
       
        }

       

         
    }

    
}

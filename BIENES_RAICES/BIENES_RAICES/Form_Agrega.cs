using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIENES_RAICES
{
    public partial class Form_Agrega : Form
    {
        public Form_Agrega()
        {
            InitializeComponent();
        }

        private void Add_cliente_Click(object sender, EventArgs e)
        {
            Clientes frm = new Clientes();
            frm.Show();
        }

        private void tipo_plazo_Click(object sender, EventArgs e)
        {
            Form_tipo_plazo frm = new Form_tipo_plazo();
            frm.Show();
        }

        private void Tipo_terreno_Click(object sender, EventArgs e)
        {
           Form_tipo_terreno frm = new Form_tipo_terreno();
            frm.Show();
        }

        private void terreno_Click(object sender, EventArgs e)
        {
            Form_terreno frm = new Form_terreno();
            frm.Show();
        }

        private void casa_Click(object sender, EventArgs e)
        {
            Form_Casa frm = new Form_Casa();
            frm.Show();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void f_pago_Click(object sender, EventArgs e)
        {
            Form_pagos frm = new Form_pagos();
            frm.Show();
        }

        private void amortizacion_Click(object sender, EventArgs e)
        {
            Form_amortizacion frm = new Form_amortizacion();
             frm.Show();
        }
    }
}

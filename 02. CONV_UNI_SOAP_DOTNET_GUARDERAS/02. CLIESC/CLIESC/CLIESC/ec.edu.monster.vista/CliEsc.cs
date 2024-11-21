using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLIESC.ec.edu.monster.controlador;
using CLIESC.ec.edu.monster.vista;

namespace CLIESC.ec.edu.monster.vista
{
    public partial class CliEsc : Form
    {
        private ConvUniControlador controlador;
        public CliEsc()
        {
            InitializeComponent();
            controlador = new ConvUniControlador();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
            //
        }

        private void txtCel_TextChanged(object sender, EventArgs e)
        {
            string text = txtCel.Text;
            if (text != "" && double.TryParse(text, out _))
            {
                txtFar.Text = controlador.convertCF(Convert.ToDouble(text)).ToString();
            }
            else
            {
                txtFar.Text = "";
            }
        }

        private void txtFar_TextChanged(object sender, EventArgs e)
        {
            string text = txtFar.Text;
            if (text != "" && double.TryParse(text, out _))
            {
                txtCel.Text = controlador.convertFC(Convert.ToDouble(text)).ToString();
            }
            else
            {
                txtCel.Text = "";
            }
        }

        private void CliEsc_FormClosing(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Hide();
            new LogIn().ShowDialog();
        }
    }
}

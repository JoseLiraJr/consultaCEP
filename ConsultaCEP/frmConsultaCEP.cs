using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCEP
{
    public partial class frmConsultaCEP : Form
    {
        public frmConsultaCEP()
        {
            InitializeComponent();
        }        

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            edtCEP.Text = string.Empty;
            edtEstado.Text = string.Empty;
            edtCidade.Text = string.Empty;
            edtBairro.Text = string.Empty;
            edtLogradouro.Text = string.Empty;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(edtCEP.Text))
            {
                MessageBox.Show("Informe o valor do CEP antes de continuar!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } 
            else
            {
                using (var ws = new wsCorreios.AtendeClienteClient())
                {
                    try
                    {
                        var resultado = ws.consultaCEP(edtCEP.Text.Trim());

                        edtEstado.Text = resultado.uf;
                        edtCidade.Text = resultado.cidade;
                        edtBairro.Text = resultado.bairro;
                        edtLogradouro.Text = resultado.end;
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show("Erro ao consultar o CEP: " + exc.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void edtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

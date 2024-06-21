using System;
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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TbBase.Text) || string.IsNullOrWhiteSpace(TbAltura.Text))
                {
                    LbMensagem.Text = "ERRO: POR FAVOR, PREENCHA TODOS OS CAMPOS!";
                    return;
                }

                if (float.TryParse(TbBase.Text, out float baseValue) && float.TryParse(TbAltura.Text, out float alturaValue))
                {
                    float res = baseValue * alturaValue / 2;
                    TbResultado.Text = res.ToString();
                    LbMensagem.Text = "CALCULO EFETUADO COM SUCESSO!";
                }
                else
                {
                    LbMensagem.Text = "ERRO: POR FAVOR, INSIRA VALORES NUMÉRICOS VÁLIDOS!";
                }
            }
            catch (Exception ex)
            {
                LbMensagem.Text = $"OCORREU UM ERRO: {ex.Message}";
            }
        }

        private void BtLimpar_Click(object sender, EventArgs e) { 
            TbBase.Text = null;
            TbAltura.Text = null;
            TbResultado.Text= null;
            LbMensagem.Text= null;
        }
    }
}

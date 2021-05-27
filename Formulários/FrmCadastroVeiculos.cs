using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO_N2.Formulários
{
    public partial class FrmCadastroVeiculos : Form
    {
        #region Singleton
        private static FrmCadastroVeiculos instance;

        public static FrmCadastroVeiculos GetSingleInstance()
        {
            if (instance == null)
            {
                instance = new FrmCadastroVeiculos();
            }

            return instance;
        }

        #endregion

        #region Listas de Veículos
        List<Veiculo> lista = new List<Veiculo>();

        #endregion
        public FrmCadastroVeiculos()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnCadastrar_Carro_Click(object sender, EventArgs e)
        {
            try
            {
                Carro carro = new Carro();

                carro.Identificação = txtNome_Carro.Text;
                carro.Modelo.Descricao = txtModelo_Carro.Text;
                carro.Modelo.Marca.Descricao = txtMarca_Carro.Text;
                carro.QuantidadePortas = Convert.ToInt16(txtQtdePortas_Carro.Text);
                carro.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_Carro.Text);
                lista.Add(carro);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Carro_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in lista)
            {
                if (v is Carro)
                {
                    (v as Carro).Desacelera();
                }
            }
        }

        private void btn_Desacelerar_Carro_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in lista)
            {
                if (v is Carro)
                {
                    (v as Carro).Acelera();
                }
            }
        }

        private void btnPagarPedagio_Carro_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in lista)
            {
                if (v is Carro)
                {
                    (v as Carro).PagaPedagio();
                }
            }
        }

        private void btnLimparVidros_Carro_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in lista)
            {
                if (v is Carro)
                {
                    (v as Carro).Limpador();
                }
            }
        }
    }
}

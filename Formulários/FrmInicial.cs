using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_POO_N2.Formulários;

namespace Trabalho_POO_N2.Formulários
{
    public partial class FrmInicial : Form
    {
        #region Singleton
        private static FrmInicial instance;

        public static FrmInicial GetSingleInstance()
        {
            if (instance == null)
            {
                instance = new FrmInicial();
            }

            return instance;
        }

        #endregion
        public FrmInicial()
        {
            InitializeComponent();
            instance = this;
        }

        private void btnCadatroModeloMarca_Click(object sender, EventArgs e)
        {
            FrmCadastroModeloMarca FrmCadastroModeloMarca = new FrmCadastroModeloMarca();

            FrmCadastroModeloMarca.Show();
        }

        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            FrmCadastroVeiculos FrmCadastroVeiculos = new FrmCadastroVeiculos();

            FrmCadastroVeiculos.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            FrmListar FrmListar = new FrmListar();

            FrmListar.Show();
        }

        private void btnCadastraPedagio_Click(object sender, EventArgs e)
        {
            FrmPedagio FrmPedagio = new FrmPedagio();

            FrmPedagio.Show();
        }
    }
}

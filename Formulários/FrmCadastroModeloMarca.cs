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
    public partial class FrmCadastroModeloMarca : Form
    {
        #region Singleton
        private static FrmCadastroModeloMarca instance;

        public static FrmCadastroModeloMarca GetSingleInstance()
        {
            if (instance == null)
            {
                instance = new FrmCadastroModeloMarca();
            }

            return instance;
        }

        #endregion

        #region Listas 
        List<Modelo> listaModelo = new List<Modelo>();
        List<Marca> listaMarca = new List<Marca>();

        #endregion
        public FrmCadastroModeloMarca()
        {
            InitializeComponent();
            instance = this;
        }

        #region Marca
        private void btnCadastrar_Marca_Click(object sender, EventArgs e)
        {
            try
            {
                Marca marca = new Marca();

                marca.Codigo = Convert.ToInt16(txtCodigo_Marca.Text);
                marca.Descricao = txtDescricao_Marca.Text;

                listaMarca.Add(marca);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        #endregion

        #region Modelo
        private void btnCadastrarModelo_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo modelo = new Modelo();
                cbMarca_Modelo.Items.Add(listaModelo);

                modelo.Codigo = Convert.ToInt16(txtCodigo_Modelo.Text);
                modelo.Descricao = txtDescricao_Modelo.Text;
                modelo.Marca = (Marca)cbMarca_Modelo.SelectedItem;
                listaModelo.Add(modelo);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static Trabalho_POO_N2.MenuSuperior;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace Trabalho_POO_N2.Formulários
{
    public partial class FrmCadastroModeloMarca : Form, IMenuSuperior
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
        public List<Modelo> listaModelo = new List<Modelo>();
        public List<Marca> listaMarca = new List<Marca>();
        #endregion
        public FrmCadastroModeloMarca()
        {
            InitializeComponent();
            instance = this;
            SetCurrentForm(this);
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
                cbMarca_Modelo.Items.Add(marca); //adicionar as marcas na combobox do modelo

                cbMarca_Modelo.DisplayMember = "Descricao";
                MessageBox.Show("Marca cadastrada com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        void SalvarMarca()
        {
            File.WriteAllText("marcas.json", JsonConvert.SerializeObject(listaMarca, Formatting.Indented));
        }


        #endregion

        #region Modelo
        private void btnCadastrarModelo_Click(object sender, EventArgs e)
        {
            try
            {
                Modelo modelo = new Modelo(Convert.ToInt16(txtCodigo_Modelo.Text), txtDescricao_Modelo.Text, (Marca)cbMarca_Modelo.SelectedItem);

                listaModelo.Add(modelo);
                SalvarMarca();
                SalvarModelo();
                MessageBox.Show("Modelo cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        void SalvarModelo()
        {
            File.WriteAllText("modelos.json", JsonConvert.SerializeObject(listaModelo, Formatting.Indented));
        }

        public void SetCurrentForm(Form currentForm)
        {
            FormController.CurrentForm = currentForm;
        }

        #endregion

    }
}

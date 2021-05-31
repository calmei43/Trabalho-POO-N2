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

        #region Dicionarios 
        public Dictionary<int, Modelo> dicModelo = new Dictionary<int, Modelo>();
        public Dictionary<int, Marca> dicMarca = new Dictionary<int, Marca>();
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
                if(dicMarca.ContainsKey(Convert.ToInt16(txtCodigo_Marca.Text)))
                {
                    dicMarca[Convert.ToInt16(txtCodigo_Marca.Text)].Descricao = txtDescricao_Marca.Text;

                    MessageBox.Show("Marca alterada com sucesso!");
                }
                else
                {
                    Marca marca = new Marca();
                    marca.Codigo = dicMarca.Count + 1;
                    marca.Descricao = txtDescricao_Marca.Text;
                    dicMarca.Add(marca.Codigo, marca);

                    cbMarca_Modelo.DisplayMember = "Descricao";
                    cbMarca_Modelo.Items.Add(marca); //adicionar as marcas na combobox do modelo

                    MessageBox.Show("Marca cadastrada com sucesso!");
                }

                SalvarMarca();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        void SalvarMarca()
        {
            File.WriteAllText("marcas.json", JsonConvert.SerializeObject(RetoraListaComValues(dicMarca), Formatting.Indented));
        }
        #endregion

        #region Modelo
        private void btnCadastrarModelo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dicModelo.ContainsKey(Convert.ToInt16(txtCodigo_Modelo.Text)))
                {
                    dicModelo[Convert.ToInt16(txtCodigo_Modelo.Text)].Descricao = txtDescricao_Modelo.Text;

                    MessageBox.Show("Modelo alterada com sucesso!");
                }
                else
                {
                    Modelo modelo = new Modelo(dicModelo.Count + 1, txtDescricao_Modelo.Text, (Marca)cbMarca_Modelo.SelectedItem);
                    dicModelo.Add(modelo.Codigo, modelo);

                    MessageBox.Show("Modelo cadastrada com sucesso!");
                }

                SalvarModelo();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        void SalvarModelo()
        {
            File.WriteAllText("modelos.json", JsonConvert.SerializeObject(RetoraListaComValues(dicModelo), Formatting.Indented));
        }

        public void SetCurrentForm(Form currentForm)
        {
            FormController.CurrentForm = currentForm;
        }

        #endregion

        List<Modelo> RetoraListaComValues(Dictionary<int, Modelo> dicModelo)
        {
            List<Modelo> modelos = new List<Modelo>();

            foreach (var item in dicModelo.Values)
            {
                modelos.Add(item);
            }

            return modelos;
        }

        List<Marca> RetoraListaComValues(Dictionary<int, Marca> dicMarca)
        {
            List<Marca> marcas = new List<Marca>();

            foreach (var item in dicMarca.Values)
            {
                marcas.Add(item);
            }

            return marcas;
        }
    }
}

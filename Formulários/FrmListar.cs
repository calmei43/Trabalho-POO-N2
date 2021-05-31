using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Trabalho_POO_N2.MenuSuperior;

namespace Trabalho_POO_N2.Formulários
{
    public partial class FrmListar : Form, IMenuSuperior
    {
        #region Singleton
        private static FrmListar instance;

        public static FrmListar GetSingleInstance()
        {
            if (instance == null)
            {
                instance = new FrmListar();
            }

            return instance;
        }

        #endregion
        public FrmListar()
        {
            InitializeComponent();
            instance = this;
            SetCurrentForm(this);
        }

        public void SetCurrentForm(Form currentForm)
        {
            FormController.CurrentForm = currentForm;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (cbTipoVeiculo_Listar.SelectedIndex == 0)
            {
                List<Veiculo> listaVeiculos = new List<Veiculo>();

                listaVeiculos = JsonConvert.DeserializeObject<List<Veiculo>>(File.ReadAllText("veiculos.json"));

                try
                {
                    txtListarVeiculos.Clear();

                    foreach (Veiculo v in listaVeiculos)
                        txtListarVeiculos.Text += v.ToString() + Environment.NewLine + Environment.NewLine;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (cbTipoVeiculo_Listar.SelectedIndex == 1)
            {
                List<Aviao> listaAvioes = new List<Aviao>();

                listaAvioes = JsonConvert.DeserializeObject<List<Aviao>>(File.ReadAllText("avioes.json"));

                try
                {
                    txtListarVeiculos.Clear();

                    foreach (Aviao v in listaAvioes)
                        txtListarVeiculos.Text += v.ToString() + Environment.NewLine + Environment.NewLine;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (cbTipoVeiculo_Listar.SelectedIndex == 2)
            {
                List<AviaoDeGuerra> listaAvioesDeGuerra = new List<AviaoDeGuerra>();

                listaAvioesDeGuerra = JsonConvert.DeserializeObject<List<AviaoDeGuerra>>(File.ReadAllText("avioesdeguerra.json"));

                try
                {
                    txtListarVeiculos.Clear();

                    foreach (AviaoDeGuerra v in listaAvioesDeGuerra)
                        txtListarVeiculos.Text += v.ToString() + Environment.NewLine + Environment.NewLine;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (cbTipoVeiculo_Listar.SelectedIndex == 3)
            {
                List<Carro> listaCarros = new List<Carro>();

                listaCarros = JsonConvert.DeserializeObject<List<Carro>>(File.ReadAllText("carros.json"));

                try
                {
                    txtListarVeiculos.Clear();

                    foreach (Carro v in listaCarros)
                        txtListarVeiculos.Text += v.ToString() + Environment.NewLine + Environment.NewLine;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (cbTipoVeiculo_Listar.SelectedIndex == 4)
            {
                List<Caminhao> listaCaminhoes = new List<Caminhao>();

                listaCaminhoes = JsonConvert.DeserializeObject<List<Caminhao>>(File.ReadAllText("caminhoes.json"));

                try
                {
                    txtListarVeiculos.Clear();

                    foreach (Caminhao v in listaCaminhoes)
                        txtListarVeiculos.Text += v.ToString() + Environment.NewLine + Environment.NewLine;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (cbTipoVeiculo_Listar.SelectedIndex == 5)
            {
                List<Moto> listaMotos = new List<Moto>();

                listaMotos = JsonConvert.DeserializeObject<List<Moto>>(File.ReadAllText("motos.json"));

                try
                {
                    txtListarVeiculos.Clear();

                    foreach (Moto v in listaMotos)
                        txtListarVeiculos.Text += v.ToString() + Environment.NewLine + Environment.NewLine;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (cbTipoVeiculo_Listar.SelectedIndex == 6)
            {
                List<Navio> listaNavios = new List<Navio>();

                listaNavios = JsonConvert.DeserializeObject<List<Navio>>(File.ReadAllText("navios.json"));

                try
                {
                    txtListarVeiculos.Clear();

                    foreach (Navio v in listaNavios)
                        txtListarVeiculos.Text += v.ToString() + Environment.NewLine + Environment.NewLine;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (cbTipoVeiculo_Listar.SelectedIndex == 7)
            {
                List<NavioGuerra> listaNavioGuerra = new List<NavioGuerra>();

                listaNavioGuerra = JsonConvert.DeserializeObject<List<NavioGuerra>>(File.ReadAllText("naviosdeguerra.json"));

                try
                {
                    txtListarVeiculos.Clear();

                    foreach (NavioGuerra v in listaNavioGuerra)
                        txtListarVeiculos.Text += v.ToString() + Environment.NewLine + Environment.NewLine;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (cbTipoVeiculo_Listar.SelectedIndex == 8)
            {
                List<Onibus> listaOnibus = new List<Onibus>();

                listaOnibus = JsonConvert.DeserializeObject<List<Onibus>>(File.ReadAllText("onibus.json"));

                try
                {
                    txtListarVeiculos.Clear();

                    foreach (Onibus v in listaOnibus)
                        txtListarVeiculos.Text += v.ToString() + Environment.NewLine + Environment.NewLine;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else if (cbTipoVeiculo_Listar.SelectedIndex == 9)
            {
                List<Trem> listaTrem = new List<Trem>();

                listaTrem = JsonConvert.DeserializeObject<List<Trem>>(File.ReadAllText("trens.json"));

                try
                {
                    txtListarVeiculos.Clear();

                    foreach (Trem v in listaTrem)
                        txtListarVeiculos.Text += v.ToString() + Environment.NewLine + Environment.NewLine;
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void FrmListar_Load(object sender, EventArgs e)
        {

        }
    }
}

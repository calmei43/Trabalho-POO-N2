using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Trabalho_POO_N2.Interfaces;
using static Trabalho_POO_N2.MenuSuperior;

namespace Trabalho_POO_N2.Formulários
{
    public partial class FrmCadastroVeiculos : Form, IMenuSuperior
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

        public FrmCadastroVeiculos()
        {
            InitializeComponent();
            instance = this;
            SetCurrentForm(this);

            CarregaMarcas();
            CarregaModelos();
            CarregaVeiculos();
            CarregaPedagios();

            PreencheArrayComboBoxMarca();
            PreencheArrayComboBoxModelo();
            PreencheArrayComboBoxPedagio();
        }

        #region Listas
        List<Marca> listaMarcas = new List<Marca>();
        List<Modelo> listaModelos = new List<Modelo>();

        List<Aviao> listaAvioes = new List<Aviao>();
        List<AviaoDeGuerra> listaAvioesDeGuerra = new List<AviaoDeGuerra>();
        List<Caminhao> listaCaminhoes = new List<Caminhao>();
        List<Carro> listaCarros = new List<Carro>();
        List<Moto> listaMotos = new List<Moto>();
        List<Navio> listaNavios = new List<Navio>();
        List<NavioGuerra> listaNaviosDeGuerra = new List<NavioGuerra>();
        List<Onibus> listaOnibus = new List<Onibus>();
        List<Trem> listaTrens = new List<Trem>();
        List<Pedagio> listaPedagio = new List<Pedagio>();

        List<Veiculo> ListaVeiculos()
        {
            List<Veiculo> listaVeiculos = new List<Veiculo>();
            listaVeiculos.AddRange(listaAvioes);
            listaVeiculos.AddRange(listaAvioesDeGuerra);
            listaVeiculos.AddRange(listaCaminhoes);
            listaVeiculos.AddRange(listaCarros);
            listaVeiculos.AddRange(listaMotos);
            listaVeiculos.AddRange(listaNavios);
            listaVeiculos.AddRange(listaNaviosDeGuerra);
            listaVeiculos.AddRange(listaOnibus);
            listaVeiculos.AddRange(listaTrens);

            File.WriteAllText("veiculos.json", JsonConvert.SerializeObject(listaVeiculos, Formatting.Indented));
            return listaVeiculos;
        }

        #endregion

        #region Métodos Ações
        void Acelera(string identificacao, Control textBox)
        {
            foreach (var item in ListaVeiculos())
            {
                if (item.Identificacao == identificacao)
                {
                    item.Acelera();
                    (textBox as TextBox).Text = item.velocidade.ToString();
                    return;
                }
            }

            MessageBox.Show("Não tem veículo salvo com este nome!");
        }
        void Desacelera(string identificacao, Control textBox)
        {
            foreach (var item in ListaVeiculos())
            {
                if (item.Identificacao == identificacao)
                {
                    item.Desacelera();
                    (textBox as TextBox).Text = item.velocidade.ToString();
                    return;
                }
            }
            MessageBox.Show("Não tem veículo salvo com este nome!");
        }
        void Limpador(string identificacao)
        {
            foreach (var item in ListaVeiculos())
            {
                if (item.Identificacao == identificacao)
                {
                    if (item is Carro)
                    {
                        (item as Carro).Limpador();
                        return;
                    }
                    else if (item is Caminhao)
                    {
                        (item as Caminhao).Limpador();
                        return;
                    }
                    else if (item is Onibus)
                    { 
                        (item as Onibus).Limpador();
                        return;
                    }
                    else if (item is Aviao)
                    { 
                        (item as Aviao).Limpador();
                        return;
                    }
                    else
                    { 
                        (item as Trem).Limpador();
                        return;
                    }
                }
            }

            MessageBox.Show("Não existe veículo com este nome!");
        }
        void Atacar(string identificacao)
        {
            foreach (var item in ListaVeiculos())
            {
                if (item.Identificacao == identificacao)
                {
                    if (item is AviaoDeGuerra)
                    {
                        (item as AviaoDeGuerra).Atacar();
                        return;
                    }
                    else
                    {
                        (item as NavioGuerra).Atacar();
                        return;
                    }
                }
            }
            MessageBox.Show("Não tem veículo salvo com este nome!");
        }
        void Atracar(string identificacao)
        {
            foreach (var item in ListaVeiculos())
            {
                if (item.Identificacao == identificacao)
                {
                    if (item is Navio)
                    {
                        (item as Navio).Atracar();
                        return;
                    }
                    else
                    {
                        (item as NavioGuerra).Atracar();
                        return;
                    }
                }
            }
            MessageBox.Show("Não tem veículo salvo com este nome!");
        }
        void Pousar(string identificacao)
        {
            foreach (var item in ListaVeiculos())
            {
                if (item.Identificacao == identificacao)
                {
                    if (item is Aviao)
                    {
                        (item as Aviao).Pousar();
                        return;
                    }
                    else
                    {
                        (item as AviaoDeGuerra).Pousar();
                        return;
                    }
                }
            }
            MessageBox.Show("Não tem veículo salvo com este nome!");
        }
        void Arremeter(string identificacao)
        {
            foreach (var item in ListaVeiculos())
            {
                if (item.Identificacao == identificacao)
                {
                    if (item is Aviao)
                    {
                        (item as Aviao).Arremeter();
                        return;
                    }
                    else
                    {
                        (item as AviaoDeGuerra).Arremeter();
                        return;
                    }
                }
            }
            MessageBox.Show("Não tem veículo salvo com este nome!");
        }
        void Decolar(string identificacao)
        {
            foreach (var item in ListaVeiculos())
            {
                if (item.Identificacao == identificacao)
                {
                    if (item is Aviao)
                    {
                        (item as Aviao).Decolar();
                        return;
                    }
                    else
                    {
                        (item as AviaoDeGuerra).Decolar();
                        return;
                    }
                }
            }
            MessageBox.Show("Não tem veículo salvo com este nome!");
        }

        #endregion

        #region Metodos Carrega Modelo/Marca/Veiculos/Pedagios Combobox
        void CarregaMarcas()
        {
            listaMarcas = JsonConvert.DeserializeObject<List<Marca>>(File.ReadAllText("marcas.json"));
        }
        void CarregaModelos()
        {
            listaModelos = JsonConvert.DeserializeObject<List<Modelo>>(File.ReadAllText("modelos.json"));
        }

        void CarregaVeiculos()
        {
            listaCarros = JsonConvert.DeserializeObject<List<Carro>>(File.ReadAllText("carros.json"));
            listaAvioes = JsonConvert.DeserializeObject<List<Aviao>>(File.ReadAllText("avioes.json"));
            listaAvioesDeGuerra = JsonConvert.DeserializeObject<List<AviaoDeGuerra>>(File.ReadAllText("avioesdeguerra.json"));
            listaCaminhoes = JsonConvert.DeserializeObject<List<Caminhao>>(File.ReadAllText("caminhoes.json"));
            listaMotos = JsonConvert.DeserializeObject<List<Moto>>(File.ReadAllText("motos.json"));
            listaNavios = JsonConvert.DeserializeObject<List<Navio>>(File.ReadAllText("navios.json"));
            listaNaviosDeGuerra = JsonConvert.DeserializeObject<List<NavioGuerra>>(File.ReadAllText("naviosdeguerra.json"));
            listaOnibus = JsonConvert.DeserializeObject<List<Onibus>>(File.ReadAllText("onibus.json"));
            listaTrens = JsonConvert.DeserializeObject<List<Trem>>(File.ReadAllText("trens.json"));

        }

        void CarregaPedagios()
        {
            listaPedagio = JsonConvert.DeserializeObject<List<Pedagio>>(File.ReadAllText("pedagios.json"));
        }

        void PreencheArrayComboBoxMarca()
        {
            ComboBox[] arrayCbMarca = {cbMarca_Carro, cbMarca_Moto, cbMarca_Navio, cbMarca_NavioGuerra, cbMarca_Onibus,
            cbMarca_Trem, cbMarca_Aviao, cbMarca_AviaoGuerra, cbMarca_Caminhao};

            foreach (var cb in arrayCbMarca)
            {
                foreach (var item in listaMarcas)
                {
                    cb.Items.Add(item);
                    cb.DisplayMember = "Descricao";
                }
                cb.SelectedIndex = 0;
            }
        }
        void PreencheArrayComboBoxModelo()
        {
            ComboBox[] arrayCbModelo = {cbModelo_Carro, cbModelo_Moto, cbModelo_Navio, cbModelo_NavioGuerra, cbModelo_Onibus,
                    cbModelo_Trem, cbModelo_Aviao, cbModelo_AviaoGuerra, cbModelo_Caminhao};

            foreach (var cb in arrayCbModelo)
            {
                foreach (var item in listaModelos)
                {
                    cb.Items.Add(item);
                    cb.DisplayMember = "Descricao";
                }
                cb.SelectedIndex = 0;
            }
        }

        void PreencheArrayComboBoxPedagio()
        {
            ComboBox[] arrayCbPedagio = {cbPedagio_Carro, cbPedagio_Moto, cbPedagio_Onibus, cbPedagio_Caminhao, cbPedagio_TodosVeiculos};

            foreach (var cb in arrayCbPedagio)
            {
                foreach (var item in listaPedagio)
                {
                    cb.Items.Add(item);
                    cb.DisplayMember = "Identificação";                    
                }
                cb.SelectedIndex = 0;
            }
        }

        #endregion

        #region Carro
        private void btnCadastrar_Carro_Click(object sender, EventArgs e)
        {
            try
            {
                Carro carro = new Carro();

                carro.Identificacao = txtNome_Carro.Text;
                carro.Modelo = (Modelo)cbModelo_Carro.SelectedItem;
                carro.Modelo.Marca = (Marca)cbMarca_Carro.SelectedItem;
                carro.QuantidadePortas = Convert.ToInt16(txtQtdePortas_Carro.Text);
                carro.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_Carro.Text);

                listaCarros.Add(carro);
             
                MessageBox.Show("Carro cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Carro_Click(object sender, EventArgs e)
        {
            Acelera(txtNome_Carro.Text, txtVelocidade_Carro);                    
        }
        private void btn_Desacelerar_Carro_Click(object sender, EventArgs e)
        {
            Desacelera(txtNome_Carro.Text, txtVelocidade_Carro);
        }

        private void btnPagarPedagio_Carro_Click(object sender, EventArgs e)
        {
            foreach (var item in listaCarros)
                if (item.Identificacao == txtNome_Carro.Text)
                    item.PagaPedagio((Pedagio)cbPedagio_Carro.SelectedItem);
        }

        private void btnLimparVidros_Carro_Click(object sender, EventArgs e)
        {
            Limpador(txtNome_Carro.Text);
        }
        #endregion

        #region Caminhão
        private void btnCadastrar_Caminhao_Click(object sender, EventArgs e)
        {
            try
            {
                Caminhao caminhao = new Caminhao();

                caminhao.CapacidadeMaxima = Convert.ToInt16(txtCapacidadeMax_Caminhao.Text);
                caminhao.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_Caminhao.Text);
                caminhao.Identificacao = txtNome_Caminhao.Text;
                caminhao.Modelo = (Modelo)cbModelo_Caminhao.SelectedItem;
                caminhao.Modelo.Marca = (Marca)cbMarca_Caminhao.SelectedItem;
                caminhao.PesoCarregado = Convert.ToInt16(txtPesoCarregado_Caminhao.Text);
                caminhao.QuantidadeEixos = Convert.ToInt16(txtQtdeEixos_Caminhao.Text);

                listaCaminhoes.Add(caminhao);
                
                MessageBox.Show("Caminhão cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        private void btnAcelerar_Caminhao_Click(object sender, EventArgs e)
        {
            Acelera(txtNome_Caminhao.Text, txtVelocidade_Caminhao);
        }

        private void btnDesacelerar_Caminhao_Click(object sender, EventArgs e)
        {
            Desacelera(txtNome_Caminhao.Text, txtVelocidade_Caminhao);
        }

        private void btnPagarPedagio_Caminhao_Click(object sender, EventArgs e)
        {
            foreach (var item in listaCaminhoes)
                if (item.Identificacao == txtNome_Caminhao.Text)
                    item.PagaPedagio((Pedagio)cbPedagio_Caminhao.SelectedItem);
        }

        private void btnLimparVidros_Caminhao_Click(object sender, EventArgs e)
        {
            Limpador(txtNome_Caminhao.Text);
        }

        private void btnCarregar_Caminhao_Click(object sender, EventArgs e)
        {
            foreach (Caminhao v in listaCaminhoes)
            {
                v.Carregar(Convert.ToInt16(txtPesoCarregado_Caminhao.Text));

            }
        }

        private void btnDescarregar_Caminhao_Click(object sender, EventArgs e)
        {
            foreach (Caminhao v in listaCaminhoes)
            {
                v.Descarregar();

            }
        }

        #endregion

        #region Moto
        private void btnCadastrar_Moto_Click(object sender, EventArgs e)
        {
            try
            {
                Moto moto = new Moto();

                moto.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_Moto.Text);
                moto.Identificacao = txtNome_Moto.Text;
                moto.Modelo = (Modelo)cbModelo_Moto.SelectedItem;
                moto.Modelo.Marca = (Marca)cbMarca_Moto.SelectedItem;

                listaMotos.Add(moto);
                
                MessageBox.Show("Moto cadastrada com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Moto_Click(object sender, EventArgs e)
        {
            Acelera(txtNome_Moto.Text, txtVelocidade_Moto);
        }

        private void btnDesacelerar_Moto_Click(object sender, EventArgs e)
        {
            Desacelera(txtNome_Moto.Text, txtVelocidade_Moto);
        }

        private void btnPagarPedagio_Moto_Click(object sender, EventArgs e)
        {
            foreach (var item in listaMotos)
                if (item.Identificacao == txtNome_Moto.Text)
                    item.PagaPedagio((Pedagio)cbPedagio_Moto.SelectedItem);
        }

        private void btnEmpinar_Moto_Click(object sender, EventArgs e)
        {
            foreach (Moto v in listaMotos)
            {
                if (v.Identificacao == txtNome_Moto.Text)
                {
                    v.Empinar();
                    return;
                }
            }
            MessageBox.Show("Não tem veículo salvo com este nome!");
        }

        #endregion

        #region Ônibus
        private void btnCadastrar_Onibus_Click(object sender, EventArgs e)
        {
            try
            {
                Onibus onibus = new Onibus();


                onibus.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_Onibus.Text);
                onibus.Identificacao = txtNome_Onibus.Text;
                onibus.Modelo = (Modelo)cbModelo_Onibus.SelectedItem;
                onibus.Modelo.Marca = (Marca)cbMarca_Onibus.SelectedItem;
                onibus.QuantidadeEixos = Convert.ToInt16(txtQtdeEixos_Onibus.Text);
                onibus.Leito = ckbPossuiLeitoSim_Onibus.Checked;

                listaOnibus.Add(onibus);
                
                MessageBox.Show("Ônibus cadastrado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Onibus_Click(object sender, EventArgs e)
        {
            Acelera(txtNome_Onibus.Text, txtVelocidade_Onibus);
        }

        private void btnDesacelerar_Onibus_Click(object sender, EventArgs e)
        {
            Desacelera(txtNome_Onibus.Text, txtVelocidade_Onibus);
        }

        private void btnLimpaVidros_Onibus_Click(object sender, EventArgs e)
        {
            Limpador(txtNome_Onibus.Text);
        }

        private void btnPagarPedagio_Onibus_Click(object sender, EventArgs e)
        {
            foreach (var item in listaOnibus)
                if (item.Identificacao == txtNome_Onibus.Text)
                    item.PagaPedagio((Pedagio)cbPedagio_Onibus.SelectedItem);
        }

        #endregion

        #region Avião
        private void btnCadastrar_Aviao_Click(object sender, EventArgs e)
        {
            try
            {
                Aviao aviao = new Aviao();

                aviao.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_Aviao.Text);
                aviao.Identificacao = txtNome_Aviao.Text;
                aviao.Modelo = (Modelo)cbModelo_Aviao.SelectedItem;
                aviao.Modelo.Marca = (Marca)cbMarca_Aviao.SelectedItem;

                listaAvioes.Add(aviao);
                
                MessageBox.Show("Avião cadastrado com sucesso!");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Aviao_Click(object sender, EventArgs e)
        {
            Acelera(txtNome_Aviao.Text, txtVelocidade_Aviao);
        }

        private void btnDesacelerar_Aviao_Click(object sender, EventArgs e)
        {
            Desacelera(txtNome_Aviao.Text, txtVelocidade_Aviao);
        }

        private void btnLimpaVidros_Aviao_Click(object sender, EventArgs e)
        {
            Limpador(txtNome_Aviao.Text);
        }

        private void btnDecolar_Aviao_Click(object sender, EventArgs e)
        {
            Decolar(txtNome_Aviao.Text);
        }

        private void btnArremeter_Aviao_Click(object sender, EventArgs e)
        {
            Arremeter(txtNome_Aviao.Text);
        }

        private void btnPousar_Aviao_Click(object sender, EventArgs e)
        {
            Pousar(txtNome_Aviao.Text);
        }
        #endregion

        #region Avião de Guerra
        private void btnCadastrar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            try
            {
                AviaoDeGuerra aviaoGuerra = new AviaoDeGuerra();


                aviaoGuerra.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_AviaoGuerra.Text);
                aviaoGuerra.Identificacao = txtNome_AviaoGuerra.Text;
                aviaoGuerra.Modelo = (Modelo)cbModelo_AviaoGuerra.SelectedItem;
                aviaoGuerra.Modelo.Marca = (Marca)cbMarca_AviaoGuerra.SelectedItem;

                listaAvioesDeGuerra.Add(aviaoGuerra);

                MessageBox.Show("Avião de Guerra cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            Acelera(txtNome_AviaoGuerra.Text, txtVelocidade_AviaoGuerra);
        }

        private void btnDesacelerar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            Desacelera(txtNome_AviaoGuerra.Text, txtVelocidade_AviaoGuerra);
        }

        private void btnAtacar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            Atacar(txtNome_AviaoGuerra.Text);
        }

        private void btnEjetar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            foreach (AviaoDeGuerra v in listaAvioesDeGuerra)
            {
                if (v.Identificacao == txtNome_AviaoGuerra.Text)
                    v.Ejetar();
            }
        }

        private void btnDecolar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            Decolar(txtNome_AviaoGuerra.Text);
        }

        private void btnArremeter_AviaoGuerra_Click(object sender, EventArgs e)
        {
            Arremeter(txtNome_AviaoGuerra.Text);
        }

        private void btnPousar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            Pousar(txtNome_AviaoGuerra.Text);
        }
        #endregion

        #region Trem
        private void btnCadastrar_Trem_Click(object sender, EventArgs e)
        {
            try
            {
                Trem trem = new Trem();


                trem.QuantidadeVagões = Convert.ToInt16(txtQtdeVagoes_Trem.Text);
                trem.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_Trem.Text);
                trem.Modelo = (Modelo)cbModelo_Trem.SelectedItem;
                trem.Modelo.Marca = (Marca)cbMarca_Trem.SelectedItem;
                trem.Identificacao = txtNome_Trem.Text;

                listaTrens.Add(trem);
               
                MessageBox.Show("Trem cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Trem_Click(object sender, EventArgs e)
        {
            Acelera(txtNome_Trem.Text, txtVelocidade_Trem);
        }

        private void btnDesacelerar_Trem_Click(object sender, EventArgs e)
        {
            Desacelera(txtNome_Trem.Text, txtVelocidade_Trem);
        }

        private void btnLimparVidros_Trem_Click(object sender, EventArgs e)
        {
            Limpador(txtNome_Trem.Text);
        }

        #endregion

        #region Navio
        private void btnCadastrar_Navio_Click(object sender, EventArgs e)
        {
            try
            {
                Navio navio = new Navio();


                navio.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_Navio.Text);
                navio.Identificacao = txtNome_Navio.Text;
                navio.Modelo = (Modelo)cbModelo_Navio.SelectedItem;
                navio.Modelo.Marca = (Marca)cbMarca_Navio.SelectedItem;

                listaNavios.Add(navio);
                
                MessageBox.Show("Navio cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Navio_Click(object sender, EventArgs e)
        {
            Acelera(txtNome_Navio.Text, txtVelocidade_Navio);
        }

        private void btnDesacelerar_Navio_Click(object sender, EventArgs e)
        {
            Desacelera(txtNome_Navio.Text, txtVelocidade_Navio);
        }

        private void btnAtracar_Navio_Click(object sender, EventArgs e)
        {
            Atracar(txtNome_Navio.Text);
        }


        #endregion

        #region Navio de Guerra
        private void btnCadastrar_NavioGuerra_Click(object sender, EventArgs e)
        {
            try
            {
                NavioGuerra navioGuerra = new NavioGuerra();


                navioGuerra.Identificacao = txtNome_NavioGuerra.Text;
                navioGuerra.Modelo = (Modelo)cbModelo_NavioGuerra.SelectedItem;
                navioGuerra.Modelo.Marca = (Marca)cbMarca_NavioGuerra.SelectedItem;
                navioGuerra.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_NavioGuerra.Text);

                listaNaviosDeGuerra.Add(navioGuerra);
               
                MessageBox.Show("Navio de Guerra cadastrado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_NavioGuerra_Click(object sender, EventArgs e)
        {
            Acelera(txtNome_NavioGuerra.Text, txtVelocidade_NavioGuerra);
        }

        private void btnDesacelerar_NavioGuerra_Click(object sender, EventArgs e)
        {
            Desacelera(txtNome_NavioGuerra.Text, txtVelocidade_NavioGuerra);
        }

        private void btnAtracar_NavioGuerra_Click(object sender, EventArgs e)
        {
            Atracar(txtNome_NavioGuerra.Text);
        }

        private void btnAtacar_NavioGuerra_Click(object sender, EventArgs e)
        {
            Atacar(txtNome_NavioGuerra.Text);
        }
        #endregion

        public void SetCurrentForm(Form currentForm)
        {
            FormController.CurrentForm = currentForm;
        }
       

        private void FrmCadastroVeiculos_FormClosed(object sender, FormClosedEventArgs e)
        {

            File.WriteAllText("carros.json", JsonConvert.SerializeObject(listaCarros, Formatting.Indented));
            File.WriteAllText("caminhoes.json", JsonConvert.SerializeObject(listaCaminhoes, Formatting.Indented));
            File.WriteAllText("motos.json", JsonConvert.SerializeObject(listaMotos, Formatting.Indented));
            File.WriteAllText("onibus.json", JsonConvert.SerializeObject(listaOnibus, Formatting.Indented));
            File.WriteAllText("avioes.json", JsonConvert.SerializeObject(listaAvioes, Formatting.Indented));
            File.WriteAllText("avioesdeguerra.json", JsonConvert.SerializeObject(listaAvioesDeGuerra, Formatting.Indented));
            File.WriteAllText("trens.json", JsonConvert.SerializeObject(listaTrens, Formatting.Indented));
            File.WriteAllText("navios.json", JsonConvert.SerializeObject(listaNavios, Formatting.Indented));
            File.WriteAllText("naviosdeguerra.json", JsonConvert.SerializeObject(listaNaviosDeGuerra, Formatting.Indented));
            File.WriteAllText("pedagios.json", JsonConvert.SerializeObject(listaPedagio, Formatting.Indented));

            ListaVeiculos();
        }

        private void txtVelocidade_Navio_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastroVeiculos_Load(object sender, EventArgs e)
        {

        }

        private void btnPagarTodosVeiculos_Click(object sender, EventArgs e)
        {
            foreach(var item in ListaVeiculos())
            {
                if(item is Carro)
                {
                    (item as Carro).PagaPedagio((Pedagio)cbPedagio_TodosVeiculos.SelectedItem);
                }
                else if(item is Caminhao)
                {
                    (item as Caminhao).PagaPedagio((Pedagio)cbPedagio_TodosVeiculos.SelectedItem);
                }
                else if(item is Moto)
                {
                    (item as Moto).PagaPedagio((Pedagio)cbPedagio_TodosVeiculos.SelectedItem);
                }
                else if(item is Onibus)
                {
                    (item as Onibus).PagaPedagio((Pedagio)cbPedagio_TodosVeiculos.SelectedItem);
                }                
            }
            MessageBox.Show("Pedágios pagos!");
        }
    }
}

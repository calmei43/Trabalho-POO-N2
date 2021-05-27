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

        #region Lista de Veículos
        List<Veiculo> listaVeiculos = new List<Veiculo>();

        #endregion
        public FrmCadastroVeiculos()
        {
            InitializeComponent();
            instance = this;
        }

        #region Carro
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
                listaVeiculos.Add(carro);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Carro_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Carro)
                {
                    (v as Carro).Desacelera();
                }
            }
        }

        private void btn_Desacelerar_Carro_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Carro)
                {
                    (v as Carro).Acelera();
                }
            }
        }

        private void btnPagarPedagio_Carro_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Carro)
                {
                    (v as Carro).PagaPedagio();
                }
            }
        }

        private void btnLimparVidros_Carro_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Carro)
                {
                    (v as Carro).Limpador();
                }
            }
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
                caminhao.Identificação = txtNome_Caminhao.Text;
                caminhao.Modelo.Descricao = txtModelo_Caminhao.Text;
                caminhao.PesoCarregado = Convert.ToInt16(txtPesoCarregado_Caminhao.Text);
                caminhao.QuantidadeEixos = Convert.ToInt16(txtQtdeEixos_Caminhao.Text);
                listaVeiculos.Add(caminhao);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }


        }

        private void btnAcelerar_Caminhao_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Caminhao)
                {
                    (v as Caminhao).Acelera();
                }
            }
        }

        private void btnDesacelerar_Caminhao_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Caminhao)
                {
                    (v as Caminhao).Desacelera();
                }
            }
        }

        private void btnPagarPedagio_Caminhao_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Caminhao)
                {
                    (v as Caminhao).PagaPedagio();
                }
            }
        }

        private void btnLimparVidros_Caminhao_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Caminhao)
                {
                    (v as Caminhao).PagaPedagio();
                }
            }
        }

        private void btnCarregar_Caminhao_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Caminhao)
                {
                    (v as Caminhao).Carregar(Convert.ToInt16(txtPesoCarregado_Caminhao.Text));
                }
            }
        }

        private void btnDescarregar_Caminhao_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Caminhao)
                {
                    (v as Caminhao).Descarregar();
                }
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
                moto.Identificação = txtNome_Moto.Text;
                moto.Modelo.Descricao = txtModelo_Moto.Text;
                listaVeiculos.Add(moto);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Moto_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Moto)
                {
                    (v as Moto).Acelera();
                }
            }
        }

        private void btnDesacelerar_Moto_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Moto)
                {
                    (v as Moto).Desacelera();
                }
            }
        }

        private void btnPagarPedagio_Moto_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Moto)
                {
                    (v as Moto).PagaPedagio();
                }
            }
        }

        private void btnEmpinar_Moto_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Moto)
                {
                    (v as Moto).Empinar();
                }
            }
        }

        #endregion

        #region Ônibus
        private void btnCadastrar_Onibus_Click(object sender, EventArgs e)
        {
            try
            {
                Onibus onibus = new Onibus();

                onibus.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_Onibus.Text);
                onibus.Identificação = txtNome_Onibus.Text;
                onibus.Modelo.Descricao = txtModelo_Onibus.Text;
                onibus.QuantidadeEixos = Convert.ToInt16(txtQtdeEixos_Onibus.Text);

                if (ckbPossuiLeitoSim_Onibus.Checked)
                    onibus.Leito = true;
                else
                    onibus.Leito = false;

                listaVeiculos.Add(onibus);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Onibus_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Onibus)
                {
                    (v as Onibus).Acelera();
                }
            }
        }

        private void btnDesacelerar_Onibus_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Onibus)
                {
                    (v as Onibus).Desacelera();
                }
            }
        }

        private void btnLimpaVidros_Onibus_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Onibus)
                {
                    (v as Onibus).Limpador();
                }
            }
        }

        private void btnPagarPedagio_Onibus_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Onibus)
                {
                    (v as Onibus).PagaPedagio();
                }
            }
        }

        #endregion

        #region Avião
        private void btnCadastrar_Aviao_Click(object sender, EventArgs e)
        {
            try
            {
                Aviao aviao = new Aviao();

                aviao.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_Aviao.Text);
                aviao.Identificação = txtNome_Aviao.Text;
                aviao.Modelo.Descricao = txtModelo_Aviao.Text;
                listaVeiculos.Add(aviao);

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Aviao_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Aviao)
                {
                    (v as Aviao).Acelera();
                }
            }
        }

        private void btnDesacelerar_Aviao_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Aviao)
                {
                    (v as Aviao).Desacelera();
                }
            }
        }

        private void btnLimpaVidros_Aviao_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Aviao)
                {
                    (v as Aviao).Limpador();
                }
            }
        }

        private void btnDecolar_Aviao_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Aviao)
                {
                    (v as Aviao).Decolar();
                }
            }
        }

        private void btnArremeter_Aviao_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Aviao)
                {
                    (v as Aviao).Arremeter();
                }
            }
        }

        private void btnPousar_Aviao_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Aviao)
                {
                    (v as Aviao).Pousar();
                }
            }
        }
        #endregion

        #region Avião de Guerra
        private void btnCadastrar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            try
            {
                AviaoDeGuerra aviaoGuerra = new AviaoDeGuerra();

                aviaoGuerra.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_AviaoGuerra.Text);
                aviaoGuerra.Identificação = txtNome_AviaoGuerra.Text;
                aviaoGuerra.Modelo.Descricao = txtModelo_AviaoGuerra.Text;

                listaVeiculos.Add(aviaoGuerra);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is AviaoDeGuerra)
                {
                    (v as AviaoDeGuerra).Acelera();
                }
            }
        }

        private void btnDesacelerar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is AviaoDeGuerra)
                {
                    (v as AviaoDeGuerra).Desacelera();
                }
            }
        }

        private void btnAtacar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is AviaoDeGuerra)
                {
                    (v as AviaoDeGuerra).Atacar();
                }
            }
        }

        private void btnEjetar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is AviaoDeGuerra)
                {
                    (v as AviaoDeGuerra).Ejetar();
                }
            }
        }

        private void btnDecolar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is AviaoDeGuerra)
                {
                    (v as AviaoDeGuerra).Decolar();
                }
            }
        }

        private void btnArremeter_AviaoGuerra_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is AviaoDeGuerra)
                {
                    (v as AviaoDeGuerra).Arremeter();
                }
            }
        }

        private void btnPousar_AviaoGuerra_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is AviaoDeGuerra)
                {
                    (v as AviaoDeGuerra).Pousar();
                }
            }
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
                trem.Modelo.Descricao = txtModelo_Trem.Text;
                trem.Identificação = txtNome_Trem.Text;

                listaVeiculos.Add(trem);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Trem_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Trem)
                {
                    (v as Trem).Acelera();
                }
            }
        }

        private void btnDesacelerar_Trem_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Trem)
                {
                    (v as Trem).Desacelera();
                }
            }
        }

        private void btnLimparVidros_Trem_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is Trem)
                {
                    (v as Trem).Limpador();
                }
            }
        }

        #endregion

        #region Navio
        private void btnCadastrar_Navio_Click(object sender, EventArgs e)
        {
            try
            {
                NavioBase navio = new NavioBase();

                navio.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_Navio.Text);
                navio.Identificação = txtNome_Navio.Text;
                navio.Modelo.Descricao = txtModelo_Navio.Text;

                listaVeiculos.Add(navio);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_Navio_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is NavioBase)
                {
                    (v as NavioBase).Acelera();
                }
            }
        }

        private void btnDesacelerar_Navio_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is NavioBase)
                {
                    (v as NavioBase).Desacelera();
                }
            }
        }

        private void btnAtracar_Navio_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is NavioBase)
                {
                    (v as NavioBase).Atracar();
                }
            }
        }


        #endregion

        #region Navio de Guerra
        private void btnCadastrar_NavioGuerra_Click(object sender, EventArgs e)
        {
            try
            {
                NavioGuerra navioGuerra = new NavioGuerra();

                navioGuerra.Identificação = txtNome_NavioGuerra.Text;
                navioGuerra.Modelo.Descricao = txtModelo_NavioGuerra.Text;
                navioGuerra.CapacidadePassageiros = Convert.ToInt16(txtCapacidadePassageiros_NavioGuerra.Text);

                listaVeiculos.Add(navioGuerra);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnAcelerar_NavioGuerra_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is NavioGuerra)
                {
                    (v as NavioGuerra).Acelera();
                }
            }
        }

        private void btnDesacelerar_NavioGuerra_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is NavioGuerra)
                {
                    (v as NavioGuerra).Desacelera();
                }
            }
        }

        private void btnAtracar_NavioGuerra_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is NavioGuerra)
                {
                    (v as NavioGuerra).Atracar();
                }
            }
        }

        private void btnAtacar_NavioGuerra_Click(object sender, EventArgs e)
        {
            foreach (Veiculo v in listaVeiculos)
            {
                if (v is NavioGuerra)
                {
                    (v as NavioGuerra).Atacar();
                }
            }
        }

        #endregion
    }
}

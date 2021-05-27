using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Trabalho_POO_N2.Formulários;

namespace TestesUnitarios
{
    [TestClass]
    public partial class TesteInterface
    {

        [TestMethod]
        public void TesteAbreForm_FrmCadastroVeiculo()
        {
            FrmInicial frmInicial = new FrmInicial();

            frmInicial.Show();
            Thread.Sleep(500);

            frmInicial.btnCadastrarVeiculo.PerformClick();
            Thread.Sleep(500);

        }

        [TestMethod]
        public void TesteAbreForm_FrmCadastroModeloMarca()
        {
            FrmInicial frmInicial = new FrmInicial();

            frmInicial.Show();
            Thread.Sleep(500);

            frmInicial.btnCadatroModeloMarca.PerformClick();

        }

        [TestMethod]
        public void TesteAbreForm_FrmCadastroListar()
        {
            FrmInicial frmInicial = new FrmInicial();

            frmInicial.Show();
            Thread.Sleep(500);

            frmInicial.btnListar.PerformClick();

        }
    }
}

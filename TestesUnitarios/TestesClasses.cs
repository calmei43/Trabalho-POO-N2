using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Trabalho_POO_N2;

namespace TestesUnitarios
{
    [TestClass]
    public class TestesClasses
    {
        [TestMethod]
        public void TestMethodMethod1()
        {
        }

        #region Veiculos
        [TestMethod]
        public void TestMethodeVeiculo_Acelera()
        {
            Veiculo veiculo = new Veiculo();

            veiculo.Acelera();
        }

        [TestMethod]
        public void TestMethodeVeiculo_Desacelera()
        {
            Veiculo veiculo = new Veiculo();

            veiculo.Desacelera();
        }

        [TestMethod]
        public void TestMethodeVeiculo_VerificaAceleracao()
        {
            Veiculo veiculo = new Veiculo();

            veiculo.Acelera();
            veiculo.Acelera();
            veiculo.Acelera();

            Assert.AreEqual(3, veiculo.velocidade);
        }

        [TestMethod]
        public void TestMethodeVeiculo_VerificaDesaceleracao()
        {
            Veiculo veiculo = new Veiculo();

            veiculo.Desacelera();

            veiculo.Acelera();
            veiculo.Acelera();

            Assert.AreEqual(1, veiculo.velocidade);
        }

        [TestMethod]
        public void TestMethodeVeiculo_ExcecaoVerificaDesaceleracao()
        {
            Veiculo veiculo = new Veiculo();

            veiculo.Desacelera();

            veiculo.Acelera();
            veiculo.Acelera();

            Assert.AreNotEqual(3, veiculo.velocidade);
        }
        #endregion

        #region Pedagio

        [TestMethod]
        public void TestMethodePedagio_ValorTotalAcumulado()
        {
            Carro carro = new Carro();
            Caminhao caminhao = new Caminhao();
            Onibus onibus = new Onibus();
            Moto moto = new Moto();

            caminhao.QuantidadeEixos = 1;
            onibus.QuantidadeEixos = 1;

            carro.PagaPedagio();
            caminhao.PagaPedagio();
            onibus.PagaPedagio();
            moto.PagaPedagio();

            Pedagio pedagio = Pedagio.GetSingleInstance();

            Assert.AreEqual(27, pedagio.ValorTotalAcumulado);
        }
        #endregion

        #region Caminhao

        [TestMethod]
        public void TestMethodeCarregar()
        {
            Caminhao caminhao = new Caminhao();

            caminhao.Carregar(10);
        }

        [TestMethod]
        public void TestMethodeDescarregar()
        {
            Caminhao caminhao = new Caminhao();

            caminhao.Descarregar();
        }

        [TestMethod]
        public void TestMethodeCapacidadeMaxima()
        {
            Caminhao caminhao = new Caminhao();

            caminhao.CapacidadeMaxima = 20;

            caminhao.Carregar(21);
        }

        #endregion
    }
}

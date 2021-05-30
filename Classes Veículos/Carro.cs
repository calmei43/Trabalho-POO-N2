using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_POO_N2.Interfaces;

namespace Trabalho_POO_N2
{
    public class Carro : Veiculo, IPedagio, ILimpador
    {
        #region Atributos 
        public int QuantidadePortas { get; set; }

        public const double ValorPedagio = 7;
        #endregion

        #region Metodos
        public void Limpador() => Console.WriteLine($"Limpador Ativado/Desativado do {Identificacao}...");

        public void PagaPedagio()
        {
            Pedagio pedagio = Pedagio.GetSingleInstance();
            pedagio.ValorTotalAcumulado += ValorPedagio;
        }
        #endregion

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
            "Quantidade de Portas: " + QuantidadePortas + Environment.NewLine +
            "Pedágio Pago: " + ValorPedagio;
        }

    }
}

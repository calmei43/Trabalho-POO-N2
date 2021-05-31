using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_POO_N2.Interfaces;

namespace Trabalho_POO_N2
{
    public class Caminhao : Veiculo, IPedagio, ILimpador
    {
        #region Atributos

        public double PesoCarregado { get; set; }
        public int QuantidadeEixos { get; set; }
        public double CapacidadeMaxima { get; set; }

        public const double ValorPedagio = 8.50; //por eixo

        #endregion

        #region Metodos

        /// <summary>
        ///  carrega o caminhão com um determinado peso, acumulando.
        /// </summary>
        /// <param name="peso"></param>
        public void Carregar(double peso)
        {
            PesoCarregado += peso;

            Console.WriteLine($"{Identificacao} carregando...");

        }

        /// <summary>
        /// retira todo o peso do caminhão
        /// </summary>
        public void Descarregar()
        {
            PesoCarregado = 0;
            Console.WriteLine($"{Identificacao} descarregando...");
        }

        /// <summary>
        /// Se ultrapassada, o veículo não deve acelerar.Neste caso, gere uma exceção indicando.
        /// </summary>
        public void VerificaCapacidadeMaxima()
        {

            if (PesoCarregado > CapacidadeMaxima)
            {
                throw new CapacidadeMaximaExcedidaException(CapacidadeMaxima - PesoCarregado);
            }

        }
        public void Limpador() => Console.WriteLine($"Limpador Ativado/Desativado do {Identificacao}...");

        public void PagaPedagio(Pedagio pedagio)
        {
            pedagio.Receber(ValorPedagio * QuantidadeEixos);
        }
        #endregion

        public override string ToString()
        {
            return base.ToString()  + Environment.NewLine +
            "Capacidade Máxima: " + CapacidadeMaxima + Environment.NewLine + "Peso Carregado: " + PesoCarregado +
            Environment.NewLine + "Quantidade de Eixos: " + QuantidadeEixos +
            Environment.NewLine + "Pedágio Pago: " + ValorPedagio;
        }
    }
}

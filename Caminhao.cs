using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO_N2
{
    public class Caminhao : Veiculo, IPedagio
    {
        #region Atributos

        double PesoCarregado { get; set; }
        public int QuantidadeEixos { get; set; }
        public double CapacidadeMaxima { get; set; }

        const double ValorPedagio = 8.50; //por eixo

        #endregion

        #region Metodos

        /// <summary>
        ///  carrega o caminhão com um determinado peso, acumulando.
        /// </summary>
        /// <param name="peso"></param>
        public void Carregar(double peso)
        {
            PesoCarregado += peso;
        }

        /// <summary>
        /// retira todo o peso do caminhão
        /// </summary>
        public void Descarregar()
        {
            PesoCarregado = 0;
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
        public void Limpador() => Console.WriteLine("Limpando...");

        public void PagaPedagio()
        {
            Pedagio pedagio = Pedagio.GetSingleInstance();
            pedagio.ValorTotalAcumulado += (ValorPedagio * QuantidadeEixos);
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO_N2
{
    public class Carro : Veiculo, IPedagio
    {
        #region Atributos 
        public int QuantidadePortas { get; set; }

        public const double ValorPedagio = 7;
        #endregion

        #region Metodos
        public void Limpador() => Console.WriteLine("Limpando...");

        public void PagaPedagio()
        {
            Pedagio pedagio = Pedagio.GetSingleInstance();
            pedagio.ValorTotalAcumulado += ValorPedagio;
        }
        #endregion

    }
}

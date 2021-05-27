using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO_N2
{
    public class Moto : Veiculo, IPedagio
    { 
        public const double ValorPedagio = 3;

        #region Metodos
        public void Empinar() => Console.WriteLine("Empinando...");
        public void PagaPedagio()
        {
            Pedagio pedagio = Pedagio.GetSingleInstance();
            pedagio.ValorTotalAcumulado += ValorPedagio;
        }
        #endregion

    }
}

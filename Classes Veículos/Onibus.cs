using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO_N2
{
    public class Onibus : Veiculo, IPedagio
    {
        #region Atributos
        public int QuantidadeEixos { get; set; }

        public const double ValorPedagio = 8.50; //por eixo
        public bool Leito { get; set; }
        #endregion

        #region Metodos
        public void Limpador() => Console.WriteLine("Limpando...");
        public void PagaPedagio()
        {
            Pedagio pedagio = Pedagio.GetSingleInstance();
            pedagio.ValorTotalAcumulado += (ValorPedagio * QuantidadeEixos);
        }
        #endregion

    }
}

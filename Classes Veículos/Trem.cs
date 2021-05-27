using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO_N2
{
    class Trem : Veiculo
    {
        #region Atributos
        public int QuantidadeVagões { get; set; }
        #endregion
        public void Limpador() => Console.WriteLine("Limpando...");

    }
}

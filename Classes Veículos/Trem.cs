using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_POO_N2.Interfaces;

namespace Trabalho_POO_N2
{
    class Trem : Veiculo, ILimpador
    {
        #region Atributos
        public int QuantidadeVagões { get; set; }
        #endregion
        public void Limpador() => Console.WriteLine($"Limpador Ativado/Desativado do {Identificacao}...");

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
            "Quantidade de Vagões: " + QuantidadeVagões;
        }
    }
}

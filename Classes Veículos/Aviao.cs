using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_POO_N2.Interfaces;

namespace Trabalho_POO_N2
{
    class Aviao : Veiculo, IAviao, ILimpador
    {
        public void Arremeter() => Console.WriteLine($"{Identificacao} arremetido...");
        public void Decolar() => Console.WriteLine($"{Identificacao} decolando...");
        public void Pousar() => Console.WriteLine($"{Identificacao} pousando...");
        public void Limpador() => Console.WriteLine($"Limpador Ativado/Desativado do {Identificacao}...");

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

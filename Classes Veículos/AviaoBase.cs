using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO_N2
{
    class AviaoBase : Veiculo
    {
        public void Pousar() => Console.WriteLine("Pousando...");
        public void Arremeter() => Console.WriteLine("Arremetida...");
        public void Decolar() => Console.WriteLine("Decolando...");

    }
}

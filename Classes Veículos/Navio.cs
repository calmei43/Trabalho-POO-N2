﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_POO_N2.Interfaces;

namespace Trabalho_POO_N2
{
    class Navio : Veiculo, IAtracar
    {
       public void Atracar() => Console.WriteLine($"{Identificacao} atracando...");

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

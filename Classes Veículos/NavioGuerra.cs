using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_POO_N2.Interfaces;

namespace Trabalho_POO_N2
{
    class NavioGuerra : Navio, IAtacar, IAtracar
    {
        public void Atacar() => Console.WriteLine($"{Identificacao} atacando...");
    }
}
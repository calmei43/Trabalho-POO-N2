using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_POO_N2.Interfaces;

namespace Trabalho_POO_N2
{
    class NavioGuerra : Navio, IAtacar, IAtracar
    {
        public void Atacar() => MessageBox.Show($"Navio de Guerra {Identificacao} atacando...");

        public void Atracar() => MessageBox.Show($"Navio de Guerra {Identificacao} atracando...");
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_POO_N2.Interfaces;

namespace Trabalho_POO_N2
{
    class AviaoDeGuerra : Veiculo, IAviao, IAtacar

    {
        public void Arremeter() => MessageBox.Show($"Aviao de Guerra {Identificacao} arremetido...");
        public void Decolar() => MessageBox.Show($"Aviao de Guerra {Identificacao} decolando...");
        public void Pousar() => MessageBox.Show($"Aviao de Guerra {Identificacao} pousando...");
        public void Atacar() => MessageBox.Show($"Aviao de Guerra {Identificacao} atacando...");
        public void Ejetar() => MessageBox.Show($"{Identificacao} ejetando passageiro(s)...");

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

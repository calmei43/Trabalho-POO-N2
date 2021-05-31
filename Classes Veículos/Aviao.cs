using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_POO_N2.Interfaces;

namespace Trabalho_POO_N2
{
    class Aviao : Veiculo, IAviao, ILimpador
    {
        public void Arremeter() => MessageBox.Show($"Aviao {Identificacao} arremetido...");
        public void Decolar() => MessageBox.Show($"Aviao {Identificacao} decolando...");
        public void Pousar() => MessageBox.Show($"Aviao {Identificacao} pousando...");
        public void Limpador() => MessageBox.Show($"Limpador do Aviao {Identificacao} Ativado/Desativado...");

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

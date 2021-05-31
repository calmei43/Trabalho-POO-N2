using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO_N2
{
    public class Moto : Veiculo, IPedagio
    { 
        public const double ValorPedagio = 3;

        #region Metodos
        public void Empinar() => MessageBox.Show($"{Identificacao} empinando...");
        public void PagaPedagio(Pedagio pedagio)
        {
            pedagio.Receber(ValorPedagio);
        }
        #endregion

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
            "Pedágio Pago: " + ValorPedagio;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_POO_N2.Interfaces;

namespace Trabalho_POO_N2
{
    public class Carro : Veiculo, IPedagio, ILimpador
    {
        #region Atributos 
        public int QuantidadePortas { get; set; }

        public const double ValorPedagio = 7;
        #endregion

        #region Metodos
        public void Limpador() => MessageBox.Show($"Limpador do Carro {Identificacao} Ativado/Desativado...");

        public void PagaPedagio(Pedagio pedagio)
        {            
            pedagio.Receber(ValorPedagio);
        }
        #endregion

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
            "Quantidade de Portas: " + QuantidadePortas + Environment.NewLine +
            "Pedágio Pago: " + ValorPedagio;
        }

    }
}

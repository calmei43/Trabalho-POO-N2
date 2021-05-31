using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO_N2
{
    public class Veiculo
    {
        #region Atributos
        public string Identificacao { get; set; }
        public int CapacidadePassageiros { get; set; }
        public Modelo Modelo { get; set; }

        public int velocidade = 0;
        #endregion

        #region Metodos
        public void Acelera()
        {
            velocidade++;

            MessageBox.Show($"{Identificacao} acelerando...");            
        }

        public void Desacelera()
        {
            velocidade--;

            MessageBox.Show($"{Identificacao} freando...");            
        }

        public override string ToString()
        {
            string retorno = "Identificação: " + Identificacao + Environment.NewLine +
                "Capacidade Passageiros: " + CapacidadePassageiros + Environment.NewLine +
                "Modelo: " + Modelo.Descricao + Environment.NewLine +
                "Velocidade: " + velocidade;

            return retorno;
        }
        #endregion

    }
}

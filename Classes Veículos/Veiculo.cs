using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Console.Write($"{Identificacao} acelerando...");
            Console.Write($"Velocidade: {velocidade}");

        }

        public void Desacelera()
        {
            velocidade--;

            Console.Write($"{Identificacao} freando...");
            Console.Write($"Velocidade: {velocidade}");
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

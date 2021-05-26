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
        string Identificação { get; set; }
        int CapacidadePassageiros { get; set; }
        Modelo Modelo { get; set; }

       public int velocidade = 0;
        #endregion

        #region Metodos
        public void Acelera() => velocidade++;
        public void Desacelera() => velocidade--;
        #endregion



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO_N2
{
    public class Pedagio
    {      

        #region Atributos
        public double ValorTotalAcumulado { get; set; }
        public string Identificação { get; set; }
        public string Localização { get; set; }
        #endregion

        #region Metodos
        public void Receber(double valor)
        {
            ValorTotalAcumulado += valor;
        }

        public override string ToString()
        {
            return $"Identificação: {Identificação}"  + Environment.NewLine + 
                   $"Localização: {Localização}" + Environment.NewLine + 
                   $"Valor total acumulado: {ValorTotalAcumulado:f2}" + Environment.NewLine;
        }


        #endregion
    }

}

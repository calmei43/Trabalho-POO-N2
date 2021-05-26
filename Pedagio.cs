using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO_N2
{
    public class Pedagio
    {
        #region Singleton
        private static Pedagio instance;

        private Pedagio() { } //para obrigar a usar o singleton

        public static Pedagio GetSingleInstance()
        {
            if (instance == null)
            {
                instance = new Pedagio();
            }
            return instance;
        }
        #endregion

        #region Atributos
        public double ValorTotalAcumulado { get; set; }
        protected string Identificação { get; set; }
        protected string Localização { get; set; }
        #endregion

        #region Metodos
        protected void Receber()
        {

        }

        double TotalPedagioRecebido()
        {
            return ValorTotalAcumulado;
        }
        #endregion
    }

}

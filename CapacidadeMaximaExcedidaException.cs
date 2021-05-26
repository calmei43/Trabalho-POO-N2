using System;
using System.Runtime.Serialization;

namespace Trabalho_POO_N2
{
    [Serializable]
    internal class CapacidadeMaximaExcedidaException : Exception
    {
        public CapacidadeMaximaExcedidaException(double pesoExcedido)
              : base("Capacidade excedida em " + pesoExcedido + " kg. Não pode acelerar!")
        {
        }
    }
}
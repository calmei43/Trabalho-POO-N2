﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho_POO_N2.Interfaces;

namespace Trabalho_POO_N2
{
    public class Onibus : Veiculo, IPedagio, ILimpador
    {
        #region Atributos
        public int QuantidadeEixos { get; set; }

        public const double ValorPedagio = 8.50; //por eixo
        public bool Leito { get; set; }
        #endregion

        #region Metodos
        public void Limpador() => MessageBox.Show($"Limpador do Onibus {Identificacao} Ativado/Desativado...");
        public void PagaPedagio(Pedagio pedagio)
        {
            pedagio.Receber(ValorPedagio);
        }
        #endregion

        public override string ToString()
        {
            if (Leito)
                return base.ToString() + 
                Environment.NewLine + "Quantidade de Eixos: " + QuantidadeEixos +
                Environment.NewLine + "Utiliza Leito" +
                Environment.NewLine + "Pedágio Pago: " + ValorPedagio;
            else
                return base.ToString() +
                Environment.NewLine + "Quantidade de Eixos" + QuantidadeEixos +
                Environment.NewLine + "Não Utiliza Leito" +
                Environment.NewLine + "Pedágio Pago: " + ValorPedagio;
        }

    }
}

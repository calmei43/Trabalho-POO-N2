using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_POO_N2
{
    class MenuSuperior
    {
        /// <summary>
        /// Controle de Formulários para UserControl
        /// </summary>
        public class FormController
        {
            /// <summary>
            /// Variável que contem o formulário atual armazenado
            /// </summary>
            public static Form CurrentForm { get; set; }
        }

        /// <summary>
        /// Interface para padronizar formulários que contem o MenuSuperior1
        /// </summary>
        public interface IMenuSuperior
        {
            /// <summary>
            /// Lógica para setar o Formulário atual para o UserControl
            /// </summary>
            /// <param name="currentForm">Formulário atual</param>
            void SetCurrentForm(Form currentForm);
        }
    }
}

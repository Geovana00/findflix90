using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace findflix90
{
    /// <summary>
    /// configura as customizações  da aplicação
    /// </summary>
    class Configuracao
    {
        //propriedades da classe 
        private int larguraTela; 
        private int AuturaTela;

        public static int[] corFundo = { 255, 555, 255 };

        //Construtor da cLASSE  é executado automaticamente 
         public Configuracao()
        {
            MedeTela();
            Debug.WriteLine("A Largura da tela é; " + this.larguraTela);
            Debug.WriteLine("A Autura da  da tela é; " + this.AuturaTela);
            

        }


        //METODO DA CLASSE 
        /// <summary>
        /// Mede as Informaçoes de altura e largura da Tela 
        /// </summary>
        private void MedeTela()
        {
            this.larguraTela = Screen.PrimaryScreen.Bounds.Width;
            this.AuturaTela = Screen.PrimaryScreen.Bounds.Height;
        }
    }
}

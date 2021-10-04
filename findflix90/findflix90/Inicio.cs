using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace findflix90
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Metodo load  da tela de aplicação onde podemos criar alteração da tela no carregamento 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Aplicacao_Load(object sender, EventArgs e)
        {

            this.BackColor = Color.FromArgb
                (Configuracao.corFundo[0], Configuracao.corFundo[1], Configuracao.corFundo[2]);

        }
    }
}

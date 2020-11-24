using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SorteadorDeLimparTalher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeraNumeros_Click(object sender, EventArgs e)
        {
            int num = 0;
            MessageBox.Show("Lista de Pessoas: \n  \n 1- Thiago  \n 2- Will \n 3- Leonardo \n 4- Rubão \n 5-Claudio \n 6- Gusta \n 7- Diego");
            Random randNum = new Random();
            for (int i = 1; i < 2; i++)
            num = randNum.Next(1, 8);

            if (num == 1)
            {
                lblResultado.Text = "Número Sorteado foi: " + num;
                MessageBox.Show("Thiago vai lavar");
            }
            else if (num == 2)
            {
                lblResultado.Text = "Número Sorteado foi: " + num;
                MessageBox.Show("Will vai lavar");
            }
            else if (num == 3)
            {
                lblResultado.Text = "Número Sorteado foi: " + num;
                MessageBox.Show("Leonardo vai lavar");
            }
            else if (num == 4)
            {
                lblResultado.Text = "Número Sorteado foi: " + num;
                MessageBox.Show("Rubão vai lavar");
            }
            else if (num == 5)
            {
                lblResultado.Text = "Número Sorteado foi: " + num;
                MessageBox.Show("Claudio vai lavar");
            }
            else if (num == 6)
            {
                lblResultado.Text = "Número Sorteado foi: " + num;
                MessageBox.Show("Gusta vai lavar");
            }
            else
            {
                lblResultado.Text = "Número Sorteado foi: " + num;
                MessageBox.Show("Diego vai lavar");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Número Sorteado foi: ";
        }
    }
}

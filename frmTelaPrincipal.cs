using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImcNet
{
    public partial class frmTelaPrincipal : Form
    {
        public frmTelaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente apagar as informações?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                mtxtAltura.Clear();
                mtxtPeso.Clear();
                txtResul.Visible = false;
                pbTabela.Visible = false;
                label5.Visible = false;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente fechar o programa?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (mtxtAltura.Text == "" || mtxtPeso.Text == "")
            {
                MessageBox.Show("Dados insuficientes, tente novamente.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                                        
                    double peso, resul;
                    double altura, quadAltura;

                    peso = double.Parse(mtxtPeso.Text);
                    altura = double.Parse(mtxtAltura.Text);
                    quadAltura = altura * altura;


                    resul = peso / quadAltura;

                    label5.Visible = true;
                    txtResul.Visible = true;
                    pbTabela.Visible = true;
                    txtResul.Text = resul.ToString("N");
                }
                catch(FormatException)
                {
                    MessageBox.Show("Dados incorretos, tente novamente.","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
    }
}

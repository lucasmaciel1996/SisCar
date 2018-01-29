using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DAL;
using Models;
using BLL;

namespace UI
{
    public partial class frmPrincipal : Form
    {
        public String usuario;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Finalizar o SisCar?","SisCar", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes) {
                Application.Exit();
            }
             

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Shown(object sender, EventArgs e)
        {
            Perfil perfil = new Perfil();
            PerfilBLL perfilbll = new PerfilBLL();

            toolStripStatusLabel1.Text = "Bem Vindo, " + ":" + usuario + "!";

            
            if(perfilbll.VerificarCoreFundo(perfil).Equals("C")){
                this.BackColor = ColorTranslator.FromHtml(perfilbll.RetornaCoreFundo(perfil));
            }

            else if (perfilbll.VerificarCoreFundo(perfil).Equals("I"))
            {
                this.BackgroundImage = Image.FromFile(perfilbll.RetornaCoreFundo(perfil));
            }




        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Calc.exe");
        }

        private void consultaDetranToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            Process.Start("IExplore.exe", "www.detram.pr.gov.br");

        }

        private void exibirBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (exibirBarraToolStripMenuItem.Checked)
            {
                toolStrip1.Show();
            }
            else {
                toolStrip1.Hide();
            }
        }

        private void corDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dlg1 = new DialogResult();

            if (this.BackgroundImage != null)
            {
                dlg1 = MessageBox.Show("Deseja Descartar o papel de parede atual?","Cor de Fundo", MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);

            }
            if ((dlg1 == DialogResult.Yes) || (dlg1== DialogResult.None))
            {
                Perfil perfil = new Perfil();
                PerfilBLL perfilbll = new PerfilBLL();


                colorDialog1.ShowDialog();
                this.BackColor = colorDialog1.Color;
                perfil.Cor = ColorTranslator.ToHtml(this.BackColor);
                perfilbll.SalvarCor(perfil);
                this.BackgroundImage = null;
            }
        }

        private void papelDeParedeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Selecione uma Figura para o Fundo";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Arquivos de Imagem|(*.bmp;*.jpg;*gif)|Todos os arquivos|*.*)";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                this.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                Perfil perfil = new Perfil();
                PerfilBLL perfilbll = new PerfilBLL();

                perfil.Imagem = openFileDialog1.FileName;
                perfilbll.SalvarImagem(perfil);

            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes frmclientes = new frmClientes();
            frmclientes.ShowDialog();
        }
    }
}

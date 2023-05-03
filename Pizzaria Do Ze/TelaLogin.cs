using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze
{
    public partial class TelaLogin : Form
    {
        TelaPrincipalAdmin admin = new TelaPrincipalAdmin();
        TelaPrincipalAtendente atendente = new TelaPrincipalAtendente();
        TelaPrincipalEntregador entregador = new TelaPrincipalEntregador();
        TelaDeConfg teladeConfig = new TelaDeConfg();
        public TelaLogin()
        {
            InitializeComponent();
            UserTextBox.Focus();
            Funcoes.AjustaResourcesControl(this);
            this.KeyDown += new KeyEventHandler(Funcoes.FormEventoKeyDown);
            notifyIcon1.ShowBalloonTip(1000);

            btnIdioma.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnIdioma.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            UserTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            UserTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            senhaTextBox.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            senhaTextBox.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            cancelBtn.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            cancelBtn.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            btnentrar.Enter += new EventHandler(Funcoes.CampoEventoEnter);
            btnentrar.Leave += new EventHandler(Funcoes.CampoEventoLeave);
            abrirAplicaçãoToolStripMenuItem.Click += new EventHandler(Funcoes.CampoEventoEnter);
            encerrarToolStripMenuItem.Click += new EventHandler(Funcoes.CampoEventoEnter);
            sobreToolStripMenuItem.Click += new EventHandler(Funcoes.CampoEventoEnter);
         



        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text == "admin")
            {
                admin.Show();
            }

            if (UserTextBox.Text == "atendente")
            {
                atendente.Show();
            }

            if (UserTextBox.Text == "entregador")
            {
                entregador.Show();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIdioma_Click(object sender, EventArgs e)
        {
            teladeConfig.Show();
        }
        private void FormPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }
        private void NotifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {

        }

        private void UserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void labelinicio_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void TelaLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            TelaDeSair sairdaTela = new TelaDeSair();
            DialogResult result = sairdaTela.ShowDialog();

            if (result == DialogResult.Yes)
            { 
             e.Cancel= true;
                this.WindowState = FormWindowState.Minimized;
                notifyIcon1.ShowBalloonTip(2000);
                
            }
            else if (result == DialogResult.OK) 
            {
                
            }

            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }



        }
    }
}

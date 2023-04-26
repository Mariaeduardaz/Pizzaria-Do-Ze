using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using static System.Windows.Forms.LinkLabel;

namespace Pizzaria_Do_Ze
{
    internal class Funcoes
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="container"></param>
        public static void AjustaResourcesControl(Control container)
        {

            foreach(Control c in container.Controls)
            {

                AjustaResourcesControl(c);
                ComponentResourceManager resources =  new ComponentResourceManager(typeof(Properties.Resources));
                resources.ApplyResources(c, c.Name);
            }
        }
        public static void CampoEventoEnter(object sender, System.EventArgs e)
        {
            if (sender is TextBoxBase txt) //MaskedTextBox, TextBox
            {
                txt.BackColor = Color.LightPink;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.LightPink;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = Color.LightPink;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.LightPink;
            }
        }
        public static void CampoEventoLeave(object sender, System.EventArgs e)
        {
            if (sender is TextBoxBase txt)
            {
                txt.BackColor = Color.White;
            }
            else if (sender is ComboBox cb)
            {
                cb.BackColor = Color.White;
            }
            else if (sender is RadioButton rb)
            {
                rb.BackColor = SystemColors.ActiveBorder;
            }
            else if (sender is ButtonBase btn)
            {
                btn.BackColor = Color.White;
            }
        }
        /// <summary>
        /// Tratar eventos de teclado, no caso tecla ENTER funcionando com TAB e tecla ESC para fechar
        /// </summary>
        /// <remarks>KeyPreview do formulário para true.</remarks>
        /// <param name="sender">Objeto que gerou o evento</param>
        /// <param name="e">Evento que foi capturado</param>
        /// <example>No construtor do formulário:
        /// this.KeyDown += new System.Windows.Forms.KeyEventHandler(ClassFuncoes.FormEventoKeyDown);
        ///</example>
        public static void FormEventoKeyDown(object sender, KeyEventArgs e)
        {
            //obtém o form onde o componente gerou o evento
            Control x = (Control)sender;
            Form form = x.FindForm();
            //verifica se foi pressionado ENTER
            if (e.KeyCode == Keys.Enter)
            {
                //Obtém ou define um valor que indica se o evento de chave deve ser passado para o controle
                
                //true caso o evento chave não deva ser enviado ao controle; caso contrário, false
                //com isso evitamos o som de erro toda vez que pressionamos enter em algum campo
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");
                
            }
            //verifica se foi pressionado ESC
            else if (e.KeyCode == Keys.Escape)
            {
                form.Close();
            }
        }
       
    }
}

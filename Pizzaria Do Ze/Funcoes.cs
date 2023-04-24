using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

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
    }
}

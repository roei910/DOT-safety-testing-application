using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IO.Swagger.Client;


namespace gui
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            webBrowser1.Navigate("https://2a4ab8d2.cognata-studio.com/#/dashboard/queue/1");
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Main_menu_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files(*.pdf)|*.pdf|WORD Files(*.doc;*.docx)|*.doc;*.docx|EXCEL Files(*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt)|*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt|Image Files(*.jpg;*.gif;*.bmp;*.png;*.jpeg)|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName.ToString();
                file_name_textBox.Text = path;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
        }
    }
}

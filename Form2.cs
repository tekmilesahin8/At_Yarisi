using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Formlar arası geçişi sağlamak için aşağıdaki kodları kullandım.
            //Yeni formun gözükmesi için visible özelliğini uyguladım.

            if (textBox1.Text == "2")
            {
                Form1 oyunekrani = new Form1();
                oyunekrani.Visible = true;
            }
            else if(textBox1.Text=="3")
            {
                Form1 oyunekrani = new Form1();
                oyunekrani.Visible = true;
            }
            else if(textBox1.Text=="4")
            {
                Form1 oyunekrani = new Form1();
                oyunekrani.Visible = true;
            }
            else
            {
                MessageBox.Show("Oyuncu sayısı en az 2 en fazla 4 olmalıdır!!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
               
        }
    }
}

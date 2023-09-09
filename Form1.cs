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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       //form içinde form açılabilir// this.IsMdiContainer=true;

        //Atların bulundukları yerden başlangıca olan uzaklık değişkenlerini yazdık.
        int birinciatsolauzaklik_201104025, ikinciatsolauzaklik_201104025, ucuncuatsolauzaklik_201104025;

        private void button1_Click(object sender, EventArgs e)
        {
            //Zamanlayıcı çalışmaya başlar.
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Hangi atın önde olduğunu anlamak için genişliği kullanırız.
            int birinciatgenislik_201104025 = pictureBox1.Width;
            int ikinciatgenislik_201104025 = pictureBox2.Width;
            int ucuncuatgenislik_201104025 = pictureBox3.Width;

           
            //Bitiş uzaklığı tanımlandı.
            int bitisuzakligi_201104025 = label5.Left;


            //Her defasında soldan uzaklaştır ve bitiş çizgisine yaklaştırmak için kullanılır.
            //Random sayıyı 0 ya da 1 gibi düşük sayılardan başlatmadım ki at takılıp çok yavaş ilerlemesin diye
            pictureBox1.Left = pictureBox1.Left + rastgele_201104025.Next(3, 17);
            pictureBox2.Left = pictureBox2.Left + rastgele_201104025.Next(3, 17);
            pictureBox3.Left = pictureBox3.Left + rastgele_201104025.Next(3, 17);




            if (birinciatgenislik_201104025 + pictureBox1.Left >= bitisuzakligi_201104025)
            {
                //Önce timeri durdurup sonra messagebox ile yazdırırız hata almayıp sonsuz kez göstermesin diye.
                //3 at için de bu koşulu yazarız.
                timer1.Enabled = false;
                MessageBox.Show("Oyunu 1.oyuncu kazanmıştır ve oyun bitmiştir !!!");
                
            }

            if (ikinciatgenislik_201104025 + pictureBox2.Left >= bitisuzakligi_201104025)
            {
                timer1.Enabled = false;
                MessageBox.Show("Oyunu 2.oyuncu kazanmıştır ve oyun bitmiştir !!!");
            }

            if (ucuncuatgenislik_201104025 + pictureBox3.Left >= bitisuzakligi_201104025)
            {
                timer1.Enabled = false;
                MessageBox.Show("Oyunu 1.oyuncu kazanmıştır ve oyun bitmiştir !!!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Atların başlangıç noktasına olan uzaklıklarını 0 verirsek atlar en başa döner yani sıfırlamış oluruz.

            pictureBox1.Left = 0;
            pictureBox2.Left = 0;
            pictureBox3.Left = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 OyunEkrani = new Form2();
            OyunEkrani.Show();
        }

        Random rastgele_201104025 = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            

            //Başlangıça yani ilk çıktığı çizgiden hangisinin daha uzak olduğunu bulmak için yazılır.
            birinciatsolauzaklik_201104025 = pictureBox1.Left;
            ikinciatsolauzaklik_201104025 = pictureBox2.Left;
            ucuncuatsolauzaklik_201104025 = pictureBox3.Left;
        }
 
        }
    }


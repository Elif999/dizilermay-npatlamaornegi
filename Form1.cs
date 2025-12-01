using System.Diagnostics.Eventing.Reader;
using System.Linq.Expressions;

namespace WinFormsApp46
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //bu projeye veritabanıda ekle
        byte[,] dizi = new byte[4, 4];
        byte satir, sutun;
        int süre = 0;
        private void button1_Click(object sender, EventArgs e)
        {     
            bool isValidInput = byte.TryParse(textBox1.Text, out satir) && byte.TryParse(textBox2.Text, out sutun) && (satir <= 3 && sutun <= 3);
            if (!isValidInput)
            {
                label1.Text = "Hata:boş veya geçersiz değerler girmeyin!!!";
                return; // Exit if invalid input
            }
  
            try
            {
                PictureBox kutu = this.Controls.Find("p" + satir + sutun, true)[0] as PictureBox;//0 yazmak zorunlu yoksa birden fazla aynı ad hatası verir
                byte durum = dizi[satir, sutun];
                if (durum == 0)
                {
                    kutu.BackColor = Color.Green;

                }
                else
                {
                    kutu.BackColor = Color.Red;
                    MessageBox.Show("üzgününüm kırmızı mayına bastınız");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    button1.Visible = false;
                    p00.BackColor = Color.LightBlue;
                    p01.BackColor = Color.LightBlue;
                    p02.BackColor = Color.LightBlue;
                    p03.BackColor = Color.LightBlue;
                    p10.BackColor = Color.LightBlue;
                    p11.BackColor = Color.LightBlue;
                    p12.BackColor = Color.LightBlue;
                    p13.BackColor = Color.LightBlue;
                    p20.BackColor = Color.LightBlue;
                    p21.BackColor = Color.LightBlue;
                    p22.BackColor = Color.LightBlue;
                    p23.BackColor = Color.LightBlue;
                    p30.BackColor = Color.LightBlue;
                    p31.BackColor = Color.LightBlue;
                    p32.BackColor = Color.LightBlue;
                    p33.BackColor = Color.LightBlue;


                }


            }
            catch//bu hata kısmındaki şart neden sağlanmıyor hocaya söyle
            {
                if( (satir > 3 || sutun > 3)&&(satir>3&&sutun>3))
                {
                    
                    label1.Text = "0-3 arası rakamları giriniz";
                }
                else
                {
                    label1.Text = " ";
                }
            }
            label1.Text = " ";


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false;
            textBox2.Visible = false;
            button1.Visible = false;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Random rastgele = new Random();
            int satirastgele = rastgele.Next(4);
            int sutunrastgele = rastgele.Next(4);
            dizi[satirastgele, sutunrastgele] = 1;

            textBox1.Visible = true;
            textBox2.Visible = true;
            button1.Visible = true;
            textBox1.Clear();
            textBox2.Clear();
            p00.BackColor = Color.LightBlue;
            p01.BackColor = Color.LightBlue;
            p02.BackColor = Color.LightBlue;
            p03.BackColor = Color.LightBlue;
            p10.BackColor = Color.LightBlue;
            p11.BackColor = Color.LightBlue;
            p12.BackColor = Color.LightBlue;
            p13.BackColor = Color.LightBlue;
            p20.BackColor = Color.LightBlue;
            p21.BackColor = Color.LightBlue;
            p22.BackColor = Color.LightBlue;
            p23.BackColor = Color.LightBlue;
            p30.BackColor = Color.LightBlue;
            p31.BackColor = Color.LightBlue;
            p32.BackColor = Color.LightBlue;
            p33.BackColor = Color.LightBlue;
          
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            süre++;
            if(süre>0&&süre<10)
            {
                label5.Text = "0-3 arası değerler giriniz";
            }
            else
            {
                timer1.Stop();
                label5.Text = " ";
            }
        }
    }
}
/*
 

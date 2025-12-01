namespace WinFormsApp45
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] isimler = new string[5];
        int[] notlar = new int[5];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            isimler[index] = textBox1.Text;
            notlar[index] = int.Parse(textBox2.Text);
            index++;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < index; i++)
            {
                listBox1.Items.Add(isimler[i] + ">" + notlar[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int endusuk = notlar[0];
            for (int i = 0; i < index; i++)
            {
                if (notlar[i] < endusuk)
                {
                    endusuk = notlar[i];
                }
            }
            label4.Text = endusuk.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int enyuksek = notlar[0];

            for (int i = 0; i < notlar.Length; i++)//notlar.lenght kullanmak yerine "index" yazmak daha sağlıklı yapay zekaya sorabilirsin anlamadıysan
            {
                if (notlar[i] > enyuksek)
                {
                    enyuksek = notlar[i];
                }
            }
            label6.Text = enyuksek.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ort = 0, toplam = 0;

            for (int i =0; i < index; i++)//notlar.lenght kullanmak yerine "index" yazmak daha sağlıklı yapay zekaya sorabilirsin anlamadıysan
            {
                toplam += notlar[i];
                ort = toplam / index;

            }
            label8.Text = ort.ToString();
        }

        private void button6_Click(object sender, EventArgs e)//endusuk , enyuksek ve ortalama bulma işlemlerini tek bir buttonla yapar=button6
        {
            if (index == 0) // Eğer hiç not girilmemişse
            {
                MessageBox.Show("Lütfen önce not girin.");
                return;
            }

            int endusuk = notlar[0];
            int enyuksek = notlar[0];
            int ort=0, toplam = 0;

            for (int i = 0; i < index; i++) // index kadar döngü yap
            {
                // En düşük notu bul
                if (notlar[i] < endusuk)
                {
                    endusuk = notlar[i];
                }

                // En yüksek notu bul
                if (notlar[i] > enyuksek)
                {
                    enyuksek = notlar[i];
                }

                // Toplamı hesapla
                toplam += notlar[i];
            }

            // Ortalama hesapla
            ort = toplam / index;

            // Sonuçları etiketlere yazdır
            label4.Text = endusuk.ToString(); // En düşük not
            label6.Text = enyuksek.ToString(); // En yüksek not
            label8.Text = ort.ToString(); // Ortalama (2 ondalık basamak)
         }
       }
    }


/*
 
  


*/

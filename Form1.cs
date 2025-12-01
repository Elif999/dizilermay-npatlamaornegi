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

            for (int i = 0; i < notlar.Length; i++)//notlar.lenght kullanmak yerine "index" yazmak daha saðlýklý yapay zekaya sorabilirsin anlamadýysan
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

            for (int i =0; i < index; i++)//notlar.lenght kullanmak yerine "index" yazmak daha saðlýklý yapay zekaya sorabilirsin anlamadýysan
            {
                toplam += notlar[i];
                ort = toplam / index;

            }
            label8.Text = ort.ToString();
        }

        private void button6_Click(object sender, EventArgs e)//endusuk , enyuksek ve ortalama bulma iþlemlerini tek bir buttonla yapar=button6
        {
            if (index == 0) // Eðer hiç not girilmemiþse
            {
                MessageBox.Show("Lütfen önce not girin.");
                return;
            }

            int endusuk = notlar[0];
            int enyuksek = notlar[0];
            int ort=0, toplam = 0;

            for (int i = 0; i < index; i++) // index kadar döngü yap
            {
                // En düþük notu bul
                if (notlar[i] < endusuk)
                {
                    endusuk = notlar[i];
                }

                // En yüksek notu bul
                if (notlar[i] > enyuksek)
                {
                    enyuksek = notlar[i];
                }

                // Toplamý hesapla
                toplam += notlar[i];
            }

            // Ortalama hesapla
            ort = toplam / index;

            // Sonuçlarý etiketlere yazdýr
            label4.Text = endusuk.ToString(); // En düþük not
            label6.Text = enyuksek.ToString(); // En yüksek not
            label8.Text = ort.ToString(); // Ortalama (2 ondalýk basamak)
         }
       }
    }


/*
 
   //   BlackBox.Al yapay zeka         
-----diziler global alanda tanýmlanýr----
string[] isimler = new string[5];:

5 elemanlý bir dizi oluþturur ve bu dizi, kullanýcýdan alýnan isimleri saklamak için kullanýlýr.
int[] notlar = new int[5];:

5 elemanlý bir dizi oluþturur ve bu dizi, kullanýcýdan alýnan notlarý saklamak için kullanýlýr.
int index = 0;:
Kullanýcýnýn girdiði isim ve notlarýn hangi indekste saklanacaðýný takip etmek için bir sayaç.
Baþlangýçta 0'dýr.

Buton Ýþlevleri
1. button1_Click
Bu buton, kullanýcýdan isim ve not almak için kullanýlýr.

isimler[index] = textBox1.Text;:

Kullanýcýnýn textBox1'e girdiði ismi alýr ve isimler dizisinin index konumuna kaydeder.
notlar[index] = int.Parse(textBox2.Text);:

Kullanýcýnýn textBox2'ye girdiði notu alýr, tam sayýya çevirir ve notlar dizisinin index konumuna kaydeder.
index++;:

index deðiþkenini bir artýrarak bir sonraki eleman için yer açar.
textBox1.Clear(); ve textBox2.Clear();:

Girdi kutularýný temizler, böylece kullanýcý yeni bir isim ve not girebilir.
textBox1.Focus();:
Kullanýcý arayüzünde textBox1'e odaklanýr, böylece kullanýcý hemen isim girmeye baþlayabilir.

2. button2_Click
Bu buton, girilen isim ve notlarý listelemek için kullanýlýr.

for (int i = 0; i < isimler.Length; i++):
isimler dizisinin uzunluðu kadar döngü yapar.
listBox1.Items.Add(isimler[i] + ">" + notlar[i]);:
Her bir isim ve notu "isim>not" formatýnda listBox1 kontrolüne ekler.

3. button6_Click
Bu buton, en düþük notu, en yüksek notu ve ortalamayý hesaplamak için kullanýlýr.
if (index == 0):
{
MessageBox.Show(lütfen isim ve Not giriþi yapýnýz");
Eðer index 0 ise, yani hiç not girilmemiþse, 
kullanýcýya bir mesaj gösterir ve iþlemi durdurur. 
Bu, kullanýcýdan veri alýnmadan hesaplama yapýlmasýný engeller.
}
int endusuk = notlar[0];:
endusuk deðiþkeni, en düþük notu saklamak için kullanýlýr ve baþlangýçta dizinin ilk elemanýna atanýr.

int enyuksek = notlar[0];:
enyuksek deðiþkeni, en yüksek notu saklamak için kullanýlýr ve baþlangýçta dizinin ilk elemanýna atanýr.

int ort = 0, toplam = 0;:
ort deðiþkeni, ortalama notu saklamak için kullanýlýr.
toplam deðiþkeni ise tüm notlarýn toplamýný saklamak için kullanýlýr.

for (int i = 0; i < index; i++):
Kullanýcýnýn girdiði not sayýsý kadar döngü yapar.
{
En Düþük Notu Bulma:
if (notlar[i] < endusuk):
Mevcut not (notlar[i]), en düþük not (endusuk) ile karþýlaþtýrýlýr. Eðer mevcut not daha küçükse,
endusuk güncellenir.

En Yüksek Notu Bulma:
if (notlar[i] > enyuksek):
Mevcut not (notlar[i]), en yüksek not (enyuksek) ile karþýlaþtýrýlýr. Eðer mevcut not daha büyükse, 
enyuksek güncellenir.

Toplamý Hesaplama:
toplam += notlar[i];
}

*/
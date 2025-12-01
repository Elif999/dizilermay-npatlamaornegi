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
        //bu projeye veritabanýda ekle
        byte[,] dizi = new byte[4, 4];
        byte satir, sutun;
        int süre = 0;
        private void button1_Click(object sender, EventArgs e)
        {     
            bool isValidInput = byte.TryParse(textBox1.Text, out satir) && byte.TryParse(textBox2.Text, out sutun) && (satir <= 3 && sutun <= 3);
            if (!isValidInput)
            {
                label1.Text = "Hata:boþ veya geçersiz deðerler girmeyin!!!";
                return; // Exit if invalid input
            }
  
            try
            {
                PictureBox kutu = this.Controls.Find("p" + satir + sutun, true)[0] as PictureBox;//0 yazmak zorunlu yoksa birden fazla ayný ad hatasý verir
                byte durum = dizi[satir, sutun];
                if (durum == 0)
                {
                    kutu.BackColor = Color.Green;

                }
                else
                {
                    kutu.BackColor = Color.Red;
                    MessageBox.Show("üzgününüm kýrmýzý mayýna bastýnýz");
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
            catch//bu hata kýsmýndaki þart neden saðlanmýyor hocaya söyle
            {
                if( (satir > 3 || sutun > 3)&&(satir>3&&sutun>3))
                {
                    
                    label1.Text = "0-3 arasý rakamlarý giriniz";
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
                label5.Text = "0-3 arasý deðerler giriniz";
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
 BLACKBOXAI -Kodun Mantýðýnýn Anlatýmý:

Tabii ki! Bu kodun mantýðýný adým adým ve detaylý bir þekilde açýklayarak kalýcý bir anlayýþ oluþturmanýza yardýmcý olacaðým.
Bu kod, basit bir "mayýn tarlasý" oyunu simüle ediyor. Ýþte kodun mantýðý:

1. Dizi Tanýmlama:
byte[,] dizi = new byte[4, 4];
Açýklama: 4x4 boyutunda bir byte dizisi tanýmlanýr. Bu dizi, her hücre için bir durum saklayacak.
Baþlangýçta tüm hücreler 0'dýr. Eðer bir hücreye 1 atanýrsa, bu hücrede bir "mayýn" olduðunu gösterir.

2. Form Yüklenirken:
private void Form1_Load(object sender, EventArgs e)
{
    textBox1.Visible = false;
    textBox2.Visible = false;
    button1.Visible = false;
}
Açýklama: Form yüklendiðinde, kullanýcýdan girdi almak için kullanýlan TextBox ve Button kontrolleri gizlenir.
Bu, oyunun baþlangýç aþamasýnda kullanýcýdan girdi alýnmadýðýný gösterir.

3. Rastgele Mayýn Yerleþtirme:
private void button2_Click(object sender, EventArgs e)
{
    Random rastgele = new Random();
    int satirastgele = rastgele.Next(4);
    int sutunrastgele = rastgele.Next(4);
    dizi[satirastaste, sutunrastgele] = 1;

    textBox1.Visible = true;
    textBox2.Visible = true;
    button1.Visible = true;
    textBox1.Clear();
    textBox2.Clear();
    // Tüm hücrelerin arka plan rengini açýk mavi yap
    // ...
    MessageBox.Show("0-3 arasý deðerler giriniz 0'da dahil");
}
Açýklama: button2 butonuna týklandýðýnda, rastgele bir satýr ve sütun seçilir (0 ile 3 arasýnda) ve bu konuma 1 deðeri atanýr.
Bu, o hücrenin "mayýn" olduðunu gösterir. Ardýndan, kullanýcýdan girdi almak için gerekli kontroller görünür hale getirilir. 
Ayrýca, tüm hücrelerin arka plan rengi açýk mavi yapýlýr.

4. Kullanýcý Girdisi Kontrolü:
private void button1_Click(object sender, EventArgs e)
{
    byte satir, sutun;
    satir = byte.Parse(textBox1.Text);
    sutun = byte.Parse(textBox2.Text);
    
    PictureBox kutu = this.Controls.Find("p" + satir + sutun, true)[0] as PictureBox;
    byte durum = dizi[satir, sutun];
    if (durum == 0)
    {
        kutu.BackColor = Color.Green;
    }
    else
    {
        kutu.BackColor = Color.Red;
        MessageBox.Show("Kýrmýzý Mayýna bastýnýz Yeniden deneyin :) ");
        kutu.BackColor = Color.LightBlue;
        // Tüm hücrelerin arka plan rengini açýk mavi yap
        // ...
    }
}
Açýklama: button1 butonuna týklandýðýnda, kullanýcýdan alýnan satýr ve sütun bilgileri kullanýlarak ilgili PictureBox kontrolü bulunur.
Eðer kullanýcý geçerli bir hücre seçerse ve bu hücrede mayýn yoksa (durum 0 ise), PictureBox'ýn arka plan rengi yeþil olur.
Eðer mayýn varsa (durum 1 ise), PictureBox'ýn arka plan rengi kýrmýzý olur ve kullanýcýya bir mesaj gösterilir.
Ayrýca, tüm hücrelerin arka plan rengi açýk mavi yapýlýr.

Oyun Mantýðý
Oyun Baþlangýcý: Kullanýcý button2 butonuna týkladýðýnda,****************************************************
rastgele bir hücreye mayýn yerleþtirilir ve kullanýcýdan girdi almak için gerekli kontroller görünür hale gelir.
Kullanýcý Girdisi: Kullanýcý, textBox1 ve textBox2'ye satýr ve sütun numaralarýný girer.
Bu deðerler, PictureBox kontrolünün adýný oluþturmak için kullanýlýr.
Hücre Kontrolü: Kullanýcý button1 butonuna týkladýðýnda, 
girilen satýr ve sütun bilgilerine göre dizi dizisindeki durumu kontrol eder:

Eðer durum 0 ise:
Bu, seçilen hücrede bir mayýn olmadýðýný gösterir. Bu durumda:
kutu.BackColor = Color.Green;
PictureBox kontrolünün arka plan rengi yeþil olur. Bu, kullanýcýnýn doðru bir hücre seçtiðini gösterir.

Eðer durum 1 ise:
Bu, seçilen hücrede bir mayýn olduðunu gösterir. Bu durumda:
kutu.BackColor = Color.Red;
MessageBox.Show("Kýrmýzý Mayýna bastýnýz Yeniden deneyin :) ");
kutu.BackColor = Color.LightBlue;
PictureBox kontrolünün arka plan rengi kýrmýzý olur ve kullanýcýya "Kýrmýzý Mayýna bastýnýz, yeniden deneyin :)" mesajý gösterilir.
Ardýndan, tüm hücrelerin arka plan rengi açýk mavi yapýlýr. Bu, oyunun sona erdiðini ve tüm hücrelerin gösterilmesi gerektiðini belirtir.

5. Tüm Hücrelerin Rengini Deðiþtirme:
textBox1.Clear();
textBox2.Clear();
textBox1.Visible = false;
textBox2.Visible = false;
button1.Visible = false;
p00.BackColor = Color.LightBlue;
p01.BackColor = Color.LightBlue;
// Diðer hücrelerin arka plan rengini açýk mavi yapma iþlemleri...
Açýklama: Eðer kullanýcý bir mayýna basarsa, tüm hücrelerin arka plan rengi açýk mavi yapýlýr.
Bu, oyunun sona erdiðini ve kullanýcýya tüm hücrelerin durumunu göstermeyi amaçlar.
Ayrýca, kullanýcýdan girdi almak için kullanýlan TextBox ve Button kontrolleri gizlenir.

Özet
Oyun Baþlangýcý: Kullanýcý button2 butonuna týkladýðýnda,
rastgele bir hücreye mayýn yerleþtirilir ve kullanýcýdan girdi almak için gerekli kontroller görünür hale gelir.

Kullanýcý Girdisi: Kullanýcý, textBox1 ve textBox2'ye satýr ve sütun numaralarýný girer.

Hücre Kontrolü:Eðer seçilen hücrede mayýn yoksa, hücre yeþil renge döner.
Eðer seçilen hücrede mayýn varsa, hücre kýrmýzý renge döner, 
kullanýcýya bir mesaj gösterilir ve tüm hücreler açýk mavi yapýlýr.

Sonuç
Bu kod, basit bir "mayýn tarlasý" oyunu mantýðýný uygulamakta.
Kullanýcýdan alýnan girdilere göre bir dizi içinde rastgele bir mayýn yerleþtiriliyor ve 
kullanýcý bu mayýna basýp basmadýðýný kontrol ediyor.
Oyun, kullanýcý etkileþimi ve görsel geri bildirim ile dinamik bir deneyim sunuyor.
*/




/*
 ama ben diyelim panel kullanmadým Sadece pictureBoxlarý satýr sütun hizasýnda dizdim ozaman true neiþe yarayacak

BLACKBOXAI

Eðer sadece PictureBox kontrollerini doðrudan form üzerine yerleþtirdiyseniz ve herhangi bir Panel, GroupBox veya baþka bir konteyner kullanmadýysanýz, 
this.Controls.Find metodunun ikinci parametresi olan true veya false arasýnda bir fark olmayacaktýr. 
Çünkü arama, doðrudan formun kontrol koleksiyonunda yapýlacak ve iç içe geçmiþ kontroller yoksa, her iki durumda da ayný sonuç elde edilecektir.

Özet:
true Kullanýmý: Eðer formda iç içe geçmiþ kontroller (örneðin, bir Panel veya GroupBox içinde bulunan PictureBox'lar) varsa, true kullanmak,
bu iç içe geçmiþ kontrollerin de aranmasýný saðlar.
false Kullanýmý: Eðer formda sadece doðrudan yerleþtirilmiþ PictureBox'lar varsa, 
false kullanmak da yeterli olacaktýr. Bu durumda, Find metodu doðrudan formun kontrol koleksiyonunu tarayacak ve aradýðýnýz PictureBox'ý bulacaktýr.

Örnek Durumlar:
Sadece PictureBox'lar:
Eðer formda sadece PictureBox kontrolleri varsa, this.Controls.Find("p" + satir + sutun, false) veya this.Controls.Find("p" + satir + sutun, true) kullanmanýz arasýnda 
bir fark yoktur. 
Her iki durumda da aradýðýnýz kontrol bulunacaktýr.

Ýç Ýçe Kontroller:
Eðer formda bir Panel veya GroupBox varsa ve PictureBox'lar bu k1ontrollerin içinde yer alýyorsa,
true kullanmak zorundasýnýz ki Find metodu bu iç içe geçmiþ kontrolleri de arayabilsin.
false kullanýrsanýz, Find metodu yalnýzca formun doðrudan altýndaki kontrolleri arayacak ve içteki PictureBox'larý bulamayacaktýr.

Sonuç:
Eðer sadece PictureBox'lar kullanýyorsanýz, true veya false kullanmanýz arasýnda bir fark yoktur. Ancak, gelecekte iç içe geçmiþ kontroller eklemeyi
düþünüyorsanýz, true kullanmak daha esnek bir yaklaþým olacaktýr.





eðer panel varsa true veya false kullanýrsak ne olur;

BLACKBOXAI

Eðer formunuzda bir Panel (veya baþka bir iç içe geçmiþ kontrol, örneðin GroupBox) varsa ve this.Controls.Find metodunu kullanýyorsanýz, 
true veya false parametrelerinin etkisi aþaðýdaki gibi olacaktýr:

1. true Kullanýmý
Açýklama: Eðer Find metoduna true parametresi verirseniz, 
arama iþlemi formun kontrol koleksiyonundaki tüm kontrolleri ve bunlarýn içindeki tüm alt kontrolleri (iç içe geçmiþ kontroller) kapsar.
Sonuç: Eðer PictureBox kontrolü bir Panel içinde yer alýyorsa, Find metodu bu PictureBox'ý bulabilir. Yani, aradýðýnýz kontrol bulunur.


2. false Kullanýmý
Açýklama: Eðer Find metoduna false parametresi verirseniz, arama iþlemi yalnýzca formun doðrudan altýndaki kontrolleri kapsar. 
Ýç içe geçmiþ kontroller (örneðin, bir Panel içindeki PictureBox) göz ardý edilir.
Sonuç: Eðer PictureBox kontrolü bir Panel içinde yer alýyorsa, Find metodu bu kontrolü bulamaz.
Bu durumda, kutu deðiþkeni null olur ve daha sonra bu deðiþken üzerinde iþlem yapmaya çalýþtýðýnýzda bir NullReferenceException hatasý alýrsýnýz.

Örnek Durumlar
form'da Panel Ýçinde PictureBox'lar varsa:
Panel myPanel = new Panel();
PictureBox myPictureBox = new PictureBox();
myPictureBox.Name = "p12";
myPanel.Controls.Add(myPictureBox);
this.Controls.Add(myPanel);
this.Controls.Find("p12", true): Bu durumda myPictureBox bulunur.
this.Controls.Find("p12", false): Bu durumda myPictureBox bulunamaz.

form üzerinde Sadece PictureBox'lar varsa:
PictureBox myPictureBox = new PictureBox();
myPictureBox.Name = "p12";
this.Controls.Add(myPictureBox);
this.Controls.Find("p12", true): Bu durumda myPictureBox bulunur.
this.Controls.Find("p12", false): Bu durumda da myPictureBox bulunur.

Sonuç
true kullanmak: Ýç içe geçmiþ kontrollerin de aranmasýný saðlar.
Eðer formda Panel veya GroupBox gibi kontroller varsa ve aradýðýnýz kontrol bu tür bir konteyner içinde yer alýyorsa, true kullanmalýsýnýz.
false kullanmak: Sadece formun doðrudan altýndaki kontrolleri arar. Eðer aradýðýnýz kontrol iç içe geçmiþ bir kontrol içinde yer alýyorsa, 
false kullanmak bu kontrolü bulamaz.
Bu nedenle, eðer formunuzda iç içe geçmiþ kontroller varsa, true kullanmak daha güvenli ve esnek bir yaklaþýmdýr.



[0]:
Find metodu, belirtilen adý taþýyan tüm kontrollerin bir dizisini döndürür. 
Eðer birden fazla kontrol ayný ada sahipse, bu dizi içinde hepsi yer alýr. 
[0] ifadesi, bu dizinin ilk elemanýný alýr. Yani, eðer "p12" adýnda bir kontrol varsa, bu kontrolü alýr.


*/
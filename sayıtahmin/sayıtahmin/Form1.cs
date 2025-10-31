namespace sayıtahmin
{
    public partial class Form1 : Form
    {
        private string cevap;
        private int tahsay = 0;
        public Form1()
        {
            InitializeComponent();
        }
        static string Sayiata()
        {
            Random rnd = new Random();
            string rastgelesayi = Convert.ToString(rnd.Next(1, 9)) + Convert.ToString(rnd.Next(0, 9)) + Convert.ToString(rnd.Next(0, 9));
            return rastgelesayi;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cevap = Sayiata();
            tbxTahmin.PlaceholderText = "Yalnız 3 haneli";
        }
        private void btnKontrol_Click(object sender, EventArgs e)
        {
            //tahmin ve cevap kullanıldığında, true olacak olan bool değişken dizileri.
            bool[] tahkul = new bool[3];
            bool[] cevkul = new bool[3];
            //yazdırılırken hangi renk yazdırılacağını atadığımız renk dizisi
            Color[] renk = new Color[3];
            string tahmin = tbxTahmin.Text;
            //eğer sayı doğru yerde ise tahmin ve cevap dizilerinin o elemanını true ya çevirir, daha sonraki döngülerde kullanmaması için.
            //o sayının indexi yeşil olur
            for (int i = 0; i < 3; i++)
            {
                if (tahmin[i] == cevap[i])
                {
                    renk[i] = Color.Green;
                    tahkul[i] = true;
                    cevkul[i] = true;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                //eğer sayı, ve yeri bilinmişse  bir sonraki indexe geçer.
                if (tahkul[i] == true)
                    continue;
                for (int j = 0; j < 3; j++)
                {
                    //cevabın her bir indexini kullanılmış mı diye kontrol eder kullanılmamışsa tahminin i. indexi ile karşılaştırır(çakışmayı önler)
                    if (!cevkul[j] && tahmin[i] == cevap[j])
                    {
                        renk[i] = Color.Orange;
                        cevkul[j] = true;
                        tahkul[i] = true;
                        break;
                    }
                }
            }
            //geri kalan indexleri kırmızı yapar
            for (int i = 0; i < 3; i++)
            {
                if (tahkul[i] == false)
                {
                    renk[i] = Color.Red;
                }
            }
            //her bir indexi rengi ile beraber yazdırır
            for (int i = 0; i < 3; i++)
            {
                rtbxSonuc.SelectionColor = renk[i];
                rtbxSonuc.AppendText(tahmin[i].ToString());
            }
            //alt satıra geçiş
            rtbxSonuc.AppendText("\n");
            //cevap doğruysa oyunu resetle
            if (tahmin == cevap)
            {
                MessageBox.Show("Cevabınız Doğru Tebrikler");
                rtbxSonuc.Clear();
                tbxTahmin.Clear();
                cevap = Sayiata();
                tbxTahmin.PlaceholderText = "Yalnız 3 haneli";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doğru Cevap: "+cevap);
            rtbxSonuc.Clear();
            tbxTahmin.Clear();
            cevap = Sayiata();
            tbxTahmin.PlaceholderText = "Yalnız 3 haneli";
        }

    }
}

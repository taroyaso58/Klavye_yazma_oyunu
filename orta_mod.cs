using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oyun_Klavye_yazma
{
    public partial class orta : Form
    {
        public orta()
        {
            InitializeComponent();
        }

        /* ana forma erişim */

        Form1 anaform = new Form1();

        // HATA : PUAN SİSTEMİNİ VE SÜREYİ DİĞER FORMA DÜZGÜN BİR ŞEKİLDE AKTARAMIYORUM  \\

        // YARDIM İSTE : RANDOMLARDA KONUMU TAM OLARAK AYARLAMA YÖNTEMİ VAR MI ? \\
        
        /* konum belirleme randomları */

        Random x = new Random();
        Random y = new Random();

        /* ilk 10 kelime belirleme */

        string[] yazılcaklar = {"1.","2.","3.","4","5","6","7","8","9","10"};

        /* kelime sayısını ayarlamak için */

        int j = 0;

        /* timerin sayısını ayarlamak için */

        int i = 0;

        /* en sonda puan gösterimi için*/

        int puan = 0;

        private void orta_Load(object sender, EventArgs e)
        {
            /* Form yüklendikten sonra giriş formundaki ambardan kelimeleri çekme yeri */

            kelimeyerletirme();
        }

        /* yazılcaklar dizisini doldurma yeri */

        public void kelimeyerletirme()
        {
            for (int i = 0;i<yazılcaklar.Length;i++)
            {
                yazılcaklar[i] = anaform.kelime_ambarı();
            }
        }


        /* text boxu ilk defa silmeye yarar */
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "  buraya yazınız:")
            {
                textBox1.Clear();
            }
        }


        /*  label ve text boxu göstermeyi ve oyunun başlamasını sağlar */
        private void btn_başlama_Click(object sender, EventArgs e)
        {
            lbl_görünenkelime.Text = yazılcaklar[j];

            lbl_görünenkelime.Visible = true;
            textBox1 .Visible = true ;
            btn_başlama.Visible = false ;

            /* timer başlatma yeri */

            timer1.Start();
        }

        /* Kelime Buraya yazılacak */
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == lbl_görünenkelime.Text.ToLower())
            {

                /* Değer sağlanınca olucaklar */

                j++;
                puan += 10;
                lbl_puan.Text = puan.ToString();
                textBox1.Clear();

                /* kelime random yer olamsı */

                lbl_görünenkelime.Location = new Point(x.Next(10,500), y.Next(10,300));

                /* dizi dışına çıkmasını engelleme */

                if (j != yazılcaklar.Length)
                lbl_görünenkelime.Text = yazılcaklar[j];
                

                /* Kelime Göstermeyi Bitirme */

                if (j == yazılcaklar.Length)
                {
                    /* timer durdurma yeri */

                    timer1.Stop();

                    /* Bitince diğer forma geçme yeri */

                    Sonuç_ektanı sonuçekran = new Sonuç_ektanı();
                    sonuçekran.Show();
                    this.Hide();
                }
                
            }
            
            /* Fazla Gereksiz kelime engelleme yöntemi */

            if (textBox1.Text.Length > lbl_görünenkelime.Text.Length)
            {
                textBox1.Clear();
            }
        }
        /* süre gönderme */
        public string süregönder()
        {
            return lbl_timer.Text;
        }

        /* Puanı Gönerme metodu */
        public string puangöder()
        {
            return puan.ToString();
        }

        /* timer geçen süre */
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            lbl_timer.Text = i.ToString();

        }
    }
}

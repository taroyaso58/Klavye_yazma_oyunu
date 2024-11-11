using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Oyun_Klavye_yazma
{
    public partial class kolay : Form
    {
        public kolay()
        {
            InitializeComponent();
        }

        /* yer düzeni için randomlar */

        Random x = new Random();
        Random y = new Random();


        /* kullanılıcak kelimeler */

        string[] kelimeler = { "1","2","3","4","5","6"};

        /* dizinin indeksi için */

        int i = 0;

        /* puan */

        int puan = 0;

        /* timer için */

        int j = 0;

        /* anaforma erişim */

        Form1 anaform = new Form1();

        /* form yüklenirken */
        private void kolay_Load(object sender, EventArgs e)
        {
            /* anaformdan kelimeleri alır */

            for (int k = 0; k < kelimeler.Length; k++)
            {
                kelimeler[k] = anaform.kelime_ambarı();
            }
        }

        /* oyunu başlatır, timer ve buton ve yazıların görünümleri ayarlar */
        private void btn_başlama_Click(object sender, EventArgs e)
        {
            btn_başlama.Visible = false;
            txt_yazılcak_yer.Visible = true;
            lbl_gelen_kelime.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            lbl_süre.Visible = true;
            lbl_puan.Visible = true;

            lbl_gelen_kelime.Text = kelimeler[i];

            timer1.Start();
        }

        /* kelime değişiklikleri ve bulma durumu */
        private void txt_yazılcak_yer_TextChanged(object sender, EventArgs e)
        {

            /* doğru bilme */

            if (txt_yazılcak_yer.Text == lbl_gelen_kelime.Text.ToLower())
            {
                i++;
                puan += 10;
                lbl_puan.Text = puan.ToString();
                txt_yazılcak_yer.Clear();

                /* sürekli kelimenin konumunu değiştirir */

                lbl_gelen_kelime.Location = new Point(x.Next(10,600), y.Next(10,300));

                /* kelimenin daha fazla diziye eklenmemesini sağlar */

                if(i!=kelimeler.Length)
                lbl_gelen_kelime.Text = kelimeler[i];
               
                /* oyunu bitirme */

                if (i == kelimeler.Length)
                {
                    timer1.Stop();
                    puangönder(puan);
                    süregönder(lbl_süre.Text);

                    Sonuç_ektanı sonuçekranı = new Sonuç_ektanı();
                    sonuçekranı.Show();
                    this.Hide();
                }
            }

            /* kelime sınırını aşma */

            if (txt_yazılcak_yer.Text.Length > lbl_gelen_kelime.Text.Length)
            {
                txt_yazılcak_yer.Clear();
            }
        }

        /* text boxu temizleme */
        private void txt_yazılcak_yer_Click(object sender, EventArgs e)
        {
            if(txt_yazılcak_yer.Text=="  buraya yazınız:")
            {
                txt_yazılcak_yer.Clear();
            }
        }

        /* timer yazdırma */
        private void timer1_Tick(object sender, EventArgs e)
        {
            j++;
            lbl_süre.Text = j.ToString();
        }
        /* puan gönderme */
        public string puangönder(int a)
        {
            
            return a.ToString();
        }

        /* süre gönderme */
        
        public string süregönder(string b)
        {
            return b;
        }
    }
}

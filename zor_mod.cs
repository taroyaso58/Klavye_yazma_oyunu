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
    public partial class zo : Form
    {
        public zo()
        {
            InitializeComponent();
        }

        /* kelimeler dizisi */
        
        string[] kelimeler = {"1.","2.","3.","4.","5." ,",6",",7",",8","9,","10,",",11",",12,","13,","14,",",15,",",16",",17",",18,",",19,",",20",",21","22",",23",",24,","25,"};

        /* anaforma erişim */       

        Form1 anaform = new Form1();

        /* puan */

        int puan = 0;

        /* süre */

        int süre = 0;

        /* kelime sayacı */
        int j = 0;
      
        /* yazım süreci ve doğrular */
       
        private void zo_Load(object sender, EventArgs e)
        {

            /* Form yüklenir yüklenmez kelimeler ayarlanıyor */

            kelimebelirleme();

        }
         /* kelimeleri yerleştirme yeri */ 
        public void kelimebelirleme()
        {
            for(int i =0; i < kelimeler.Length; i++)
            {
                kelimeler[i] = anaform.kelime_ambarı();
            }
        }

        /* kelime ekleem ve kontrol */
        private void zo_KeyPress(object sender, KeyPressEventArgs e)
        {
            lbl_yazı.Text += e.KeyChar;

          
        } 

        private void lbl_yazı_Click(object sender, EventArgs e)
        {

        }

        private void btn_başlama_Click(object sender, EventArgs e)
        {
           
            btn_başlama.Visible = false;

            lbl_görünenkelime.Text = kelimeler[j];
        }
    }
}

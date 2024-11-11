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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* kelime ambarı için random */

        Random kelime_karıştırıcısı = new Random();

        /* zorluk seviyesi belirleme */

        int zorluk_seviyesi = 0;

        /* orta butonu çalışırsa */
        private void btn_orta_Click(object sender, EventArgs e)
        {
            zorluk_seviyesi = 2;

            orta ortaoyun = new orta();
            ortaoyun.Show();
            this.Hide();
        }

        /* kolay butonu çalışırsa */
        private void btn_kolay_Click(object sender, EventArgs e)
        {
            zorluk_seviyesi = 1;

            kolay kolayoyun = new kolay();
            kolayoyun.Show();
            this.Hide();
        }

        /* zor butonu çalışırsa */
        private void btn_zor_Click(object sender, EventArgs e)
        {
            zorluk_seviyesi = 3;

            zo zoroyun = new zo();
            zoroyun.Show();
            this.Hide();
        }

        /* rastgele kelime belirleme yeri */
       public string kelime_ambarı()
        {
             
            string kelimehazensi =  "ABACI\nABADİ\nABALI\nABANA\nABANİ\nABAŞO\nABAZA\nABBAS\nABDAL\nABECE\nBABAÇ\nBABAİ\nBACAK\nBAÇÇI\nBADAL\nBADAS\nBADAT\nBADEM\nBADIÇ\nBADİK\nCACIK\nCADDE\nCAHİL\nCAİZE\nCALİP\nCAMCI\nCAMIZ\nCAMİA\nCAMİT\nCAMLI\nÇABUK\nÇADIR\nÇAĞLA\nÇAĞMA\nÇAĞRI\nÇAKAL\nÇAKAR\nÇAKER\nÇAKIL\nÇAKIM\nFACİA\nFAGOT\nFAHİŞ\nFAHRİ\nFAHTE\nFAHUR\nFAKAT\nFAKİH\nFAKİR\nFAKÜL\nHABBE\nHABER\nHABEŞ\nHABİP\nHABİS\nHACET\nHACİM\nHACİR\nHACİZ\nHAÇLI";
            string[] kelimeler = kelimehazensi.Split('\n');
          
           int sa=kelime_karıştırıcısı.Next(0,60);

            return kelimeler[sa];
        }

        public void seviyeyegörepuan()
        {
            
        }
    }
}

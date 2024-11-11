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
    public partial class Sonuç_ektanı : Form
    {
        public Sonuç_ektanı()
        {
            InitializeComponent();
        }
        orta ortaform = new orta();
        private void Sonuç_ektanı_Load(object sender, EventArgs e)
        {
            string a = ortaform.puangöder();
            string b = ortaform.süregönder();

            lbl_süre.Text = b;
            lbl_sonuçpuan.Text = a;
            lbl_enyüksek_skor.Text = "0";
        }

        private void btn_tekraroyna_Click(object sender, EventArgs e)
        {
            Form1 anaform = new Form1();
            anaform.ShowDialog();
            this.Hide();
        }

        private void btn_çıkış_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

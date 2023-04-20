using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VucutKitle_Endeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void SadeceSayiGirme(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy = Convert.ToDouble(textBox1.Text.Insert(1,","));
            int kg = Convert.ToInt32(textBox2.Text);
            int sonuc = Convert.ToInt32(kg / (boy * boy));
            if (sonuc > 15 && sonuc < 20) label3.Text = "Vücüt Kitle indeksiniz : " + sonuc +" Biraz zayıfsınız. Beslenmenizi arttırmanız gerekli";
            if (sonuc > 20 && sonuc < 25) label3.Text = "Vücüt Kitle indeksiniz : "+ sonuc +" İdeal Kilodasınız";
            if (sonuc > 25 && sonuc < 30) label3.Text = "Vücüt Kitle indeksiniz : "+ sonuc +" Fazla kilonuz bulunuyor. Beslenmenizi arttırmayınız.";
            if (sonuc > 30 && sonuc < 40) label3.Text = "Vücüt Kitle indeksiniz : "+ sonuc +" Obezsiniz. Beslenmenize dikkat etmelisiniz.";
            if (sonuc > 40) label3.Text = "Vücüt Kitle indeksiniz : "+ sonuc +" Aşırı obezsiniz. Beslenmenize dikkat etmelisiniz.";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "Vücüt Kitle indeksiniz : " ;
        }
    }
}

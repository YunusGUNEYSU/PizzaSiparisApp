using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaSiparis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ebat kucuk = new Ebat();
            kucuk.Adi = "Küçük";
            kucuk.Carpan = 1;
            Ebat orta = new Ebat();
            orta.Adi = "Orta";
            orta.Carpan = 1.25;
            Ebat buyuk = new Ebat();
            buyuk.Adi = "Büyük";
            buyuk.Carpan = 1.75;
            Ebat maxi = new Ebat();
            maxi.Adi = "Maxi";
            maxi.Carpan = 2;
            cmbEbatlar.Items.Add(kucuk);
            cmbEbatlar.Items.Add(orta);
            cmbEbatlar.Items.Add(buyuk);
            cmbEbatlar.Items.Add(maxi);
            Pizza klasik = new Pizza();
            klasik.Adi = "KLASİK";
            klasik.Fiyat = 17;
            Pizza karisik = new Pizza();
            karisik.Adi = "KARIŞIK";
            karisik.Fiyat = 17;
            Pizza extravaganza = new Pizza();
            extravaganza.Adi = "EXTRAVAGANZA";
            extravaganza.Fiyat = 21;
            Pizza italiano = new Pizza();
            italiano.Adi = "İTALİANO";
            italiano.Fiyat = 20;
            Pizza turkish = new Pizza();
            turkish.Adi = "TURKİSH";
            turkish.Fiyat = 23;
            Pizza tuna = new Pizza();
            tuna.Adi = "TUNA";
            tuna.Fiyat = 18;
            Pizza seafeed = new Pizza();
            seafeed.Adi = "SEAFEED";
            seafeed.Fiyat = 19;
            Pizza kastamonu = new Pizza();
            kastamonu.Adi = "KASTAMONU";
            kastamonu.Fiyat = 20;
            Pizza calypso = new Pizza();
            calypso.Adi = "CALYPSO";
            calypso.Fiyat = 24;
            Pizza akdeniz = new Pizza();
            akdeniz.Adi = "AKDENİZ";
            akdeniz.Fiyat = 21;
            Pizza karadeniz = new Pizza();
            karadeniz.Adi = "KARADENİZ";
            karadeniz.Fiyat = 21;
            lstPizzalar.Items.Add(klasik);
            lstPizzalar.Items.Add(karisik);
            lstPizzalar.Items.Add(extravaganza);
            lstPizzalar.Items.Add(italiano);
            lstPizzalar.Items.Add(turkish);
            lstPizzalar.Items.Add(tuna);
            lstPizzalar.Items.Add(seafeed);
            lstPizzalar.Items.Add(kastamonu);
            lstPizzalar.Items.Add(calypso);
            lstPizzalar.Items.Add(akdeniz);
            lstPizzalar.Items.Add(karadeniz);
            KenarTip ince = new KenarTip();
            ince.Adi = "İnce Kenar";
            ince.EkFiyat = 0;
            rdbInceKenar.Tag = ince;
            KenarTip kalin = new KenarTip();
            kalin.Adi = "Kalın Kenar";
            kalin.EkFiyat = 2;
            rdbKalınKenar.Tag = kalin;

        }
        Siparis s;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Pizza p = (Pizza)lstPizzalar.SelectedItem;
            p.Ebati = (Ebat)cmbEbatlar.SelectedItem;
            p.KenarTipi = rdbInceKenar.Checked ? (KenarTip)rdbInceKenar.Tag : (KenarTip)rdbKalınKenar.Tag;
            p.Malzemeler = new List<string>();
            foreach (CheckBox ctrl in groupBox1.Controls)
            {
                if (ctrl.Checked)
                {
                    p.Malzemeler.Add(ctrl.Text);
                }
            }
            int adet = Convert.ToInt32(txtAdet.Text);
            decimal tutar = adet * p.Tutar;
            txtTutar.Text = tutar.ToString();
            s = new Siparis();
            s.Pizza = p;
            s.Adet = adet;
        }
      
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            if (s != null)
            {
                lstSiparisler.Items.Add(s);
            }
           
        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            decimal ToplamTutar = 0;
            int sayac = 0;
            foreach (Siparis spr in lstSiparisler.Items)
            {
                ToplamTutar += spr.Adet * spr.Pizza.Tutar;
                sayac++;
            }
            lblTutar.Text = ToplamTutar.ToString();
            MessageBox.Show(string.Format("Toplam Sipariş Adediniz: {0} \n Toplam Sipariş Tutarınız:{1}",sayac,ToplamTutar));
        }
    }
}

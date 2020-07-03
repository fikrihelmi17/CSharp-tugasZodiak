using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugas_zodiak
{
    public partial class Form1 : Form
    {
        string indexZodiak;
        string b, keuangan, asmara;
        int t;
   
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbBulan_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            b = dtpZodiak.Value.Date.ToString("MMMM");
            t = int.Parse(dtpZodiak.Value.Date.ToString("dd"));

            //capricorn
            if((b == "Desember") && (t>=22) && (t<=31) )
            {
                indexZodiak = "Capricorn";
                keuangan = "Ada pemasukan tambahan yang sangat membantu kondisi keuangan saat ini.";
                asmara = "Single: Dia baik bukan karena ada perasaan lebih, jangan gampang ge-er.";
            }
            if ((b == "Januari") && (t>=1) && (t<=19))
            {
                indexZodiak = "Capricorn";
                keuangan = "Ada pemasukan tambahan yang sangat membantu kondisi keuangan saat ini.";
                asmara = "Single: Dia baik bukan karena ada perasaan lebih, jangan gampang ge-er.";
            }

            //aquarius
            if ((b == "Januari") && (t >= 20) && (t <= 31))
            {
                indexZodiak = "Aquarius";
                keuangan = "Jangan membuat keputusan resign yang gegabah, ya.";
                asmara = "Single: Akhirnya dia memberikan kepastiannya juga.";
            }
            if ((b == "Februari") && (t >= 1) && (t <= 18))
            {
                indexZodiak = "Aquarius";
                keuangan = "Jangan membuat keputusan resign yang gegabah, ya.";
                asmara = "Single: Akhirnya dia memberikan kepastiannya juga.";
            }

            //pisces
            if ((b == "Februari") && (t >= 19) && (t <= 29))
            {
                indexZodiak = "Pisces";
                keuangan = "Pengeluaran tak terduga bikin tekor nih.";
                asmara = "Single: Yang sudah lama diharapkan kayaknya harus direlakan pergi.";
            }
            if ((b == "Maret") && (t >= 1) && (t <= 20))
            {
                indexZodiak = "Pisces";
                keuangan = "Pengeluaran tak terduga bikin tekor nih.";
                asmara = "Single: Yang sudah lama diharapkan kayaknya harus direlakan pergi.";
            }

            //aries
            if ((b == "Maret") && (t >= 21) && (t <= 31))
            {
                indexZodiak = "Aries";
                keuangan = "Pemasukan dan pengeluaran sudah lebih seimbang.";
                asmara = "Single: Perlu lebih bersabar menanti jodoh terbaik.";
            }
            if ((b == "April") && (t >= 1) && (t <= 19))
            {
                indexZodiak = "Aries";
                keuangan = "Pemasukan dan pengeluaran sudah lebih seimbang.";
                asmara = "Single: Perlu lebih bersabar menanti jodoh terbaik.";
            }

            //taurus
            if ((b == "April") && (t >= 20) && (t <= 30))
            {
                indexZodiak = "Taurus";
                keuangan = "Kondisi keuangan agak kritis nih.";
                asmara = "Single: Perhatianmu padanya jadi disalahartikan nih kayaknya.";
            }
            if ((b == "Mei") && (t >= 1) && (t <= 20))
            {
                indexZodiak = "Taurus";
                keuangan = "Kondisi keuangan agak kritis nih.";
                asmara = "Single: Perhatianmu padanya jadi disalahartikan nih kayaknya.";
            }

            //gemini
            if ((b == "Mei") && (t >= 21) && (t <= 31))
            {
                indexZodiak = "Gemini";
                keuangan = "Ada rekan kerja yang ingin menyaingimu.";
                asmara = "Single: Jodoh terbaikmu sebentar lagi akan menjemputmu.";
            }
            if ((b == "Juni") && (t >= 1) && (t <= 21))
            {
                indexZodiak = "Gemini";
                keuangan = "Ada rekan kerja yang ingin menyaingimu.";
                asmara = "Single: Jodoh terbaikmu sebentar lagi akan menjemputmu.";
            }

            //cancer
            if ((b == "Juni") && (t >= 22) && (t <= 30))
            {
                indexZodiak = "Cancer";
                keuangan = "Banyak pengeluaran yang harus segera diatasi.";
                asmara = "Single: Kesibukan baru membuatmu lebih bahagia.";
            }
            if ((b == "Juli") && (t >= 1) && (t <= 22))
            {
                indexZodiak = "Cancel";
                keuangan = "Banyak pengeluaran yang harus segera diatasi.";
                asmara = "Single: Kesibukan baru membuatmu lebih bahagia.";
            }

            //leo
            if ((b == "Juli") && (t >= 23) && (t <= 31))
            {
                indexZodiak = "Leo";
                keuangan = "Meningkatnya karier jadi kabar baik.";
                asmara = "Single: Jangan sampai kamu jadi orang ketiga, ya.";
            }
            if ((b == "Agustus") && (t >= 1) && (t <= 22))
            {
                indexZodiak = "Leo";
                keuangan = "Meningkatnya karier jadi kabar baik.";
                asmara = "Single: Jangan sampai kamu jadi orang ketiga, ya.";
            }

            //virgo
            if ((b == "Agustus") && (t >= 23) && (t <= 31))
            {
                indexZodiak = "Virgo";
                keuangan = "Meski pengeluaran lebih banyak tapi masih teratasi dengan baik.";
                asmara = "Single: Makin galau karena makin merasa kesepian nih.";
            }
            if ((b == "September") && (t >= 1) && (t <= 22))
            {
                indexZodiak = "Virgo";
                keuangan = "Meski pengeluaran lebih banyak tapi masih teratasi dengan baik.";
                asmara = "Single: Makin galau karena makin merasa kesepian nih.";
            }

            //libra
            if ((b == "September") && (t >= 23) && (t <= 30))
            {
                indexZodiak = "Libra";
                keuangan = "Saingan di tempat kerja makin ketat dan kompetitif.";
                asmara = "Single: Orang terdekat bisa jadi jodoh terbaikmu.";
            }
            if ((b == "Oktober") && (t >= 1) && (t <= 22))
            {
                indexZodiak = "Libra";
                keuangan = "Saingan di tempat kerja makin ketat dan kompetitif.";
                asmara = "Single: Orang terdekat bisa jadi jodoh terbaikmu.";
            }

            //scorpio
            if ((b == "Oktober") && (t >= 23) && (t <= 31))
            {
                indexZodiak = "Scorpio";
                keuangan = "Karier saat ini bisa jadi batu loncatan untuk membuka kesempatan yang lebih luas lagi.";
                asmara = "Single: Orangtua makin mendesakmu segera menikah.";
            }
            if ((b == "November") && (t >= 1) && (t <= 21))
            {
                indexZodiak = "Scorpio";
                keuangan = "Karier saat ini bisa jadi batu loncatan untuk membuka kesempatan yang lebih luas lagi.";
                asmara = "Single : Orangtua makin mendesakmu segera menikah.";
            }

            //sagitarius
            if ((b == "November") && (t >= 22) && (t <= 30))
            {
                indexZodiak = "Sagitarius";
                keuangan = "Tahan diri dari godaan diskon hari ini ya.";
                asmara = "Single: Jangan memberi harapan palsu ya.";
            }
            if ((b == "Desember") && (t >= 1) && (t <= 21))
            {
                indexZodiak = "Sagitarius";
                keuangan = "Tahan diri dari godaan diskon hari ini ya.";
                asmara = "Single: Jangan memberi harapan palsu ya.";
            }

            rtbZodiak.Clear();
            rtbZodiak.AppendText("Bulan Lahir Anda : " + b + "\n");
            rtbZodiak.AppendText("Tanggal Lahir Anda : " + t + "\n");
            rtbZodiak.AppendText("============================\n\n");
            rtbZodiak.AppendText("Zodiak Anda Adalah : " + indexZodiak + "\n");
            rtbZodiak.AppendText("Keuangan : " + keuangan + "\n");
            rtbZodiak.AppendText("Asmara : " + asmara + "\n");
    
        }

        private void cmbTanggal_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbZodiak.Clear();
            dtpZodiak.ResetText();
        }
    }
}

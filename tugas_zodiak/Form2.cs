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
    public partial class Form2 : Form
    {
        int nilai;

        public Form2()
        {
            InitializeComponent();
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHasil_Click(object sender, EventArgs e)
        {
            txtHasil.Clear();

            nilai = Convert.ToInt16(txtInput.Text);

            if (nilai >= 85 && nilai <= 100)
            {
                txtHasil.AppendText("A");
            }
            else if (nilai >= 75 && nilai < 85)
            {
                txtHasil.AppendText("B");
            }
            else if (nilai >= 55 && nilai < 75)
            {
                txtHasil.AppendText("C");
            }
            else if (nilai >= 30 && nilai < 55)
            {
                txtHasil.AppendText("D");
            }
            else if (nilai >= 0 && nilai < 30)
            {
                txtHasil.AppendText("E");
            }
            else
            {
                txtHasil.AppendText("Nilai Input Salah !!!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHasil.Clear();
            txtInput.Clear();
        }
    }
}

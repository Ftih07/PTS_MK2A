using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class FormKasir : Form
    {
        public FormKasir()
        {
            InitializeComponent();
        }

        private void FormKasir_Load(object sender, EventArgs e)
        {
            cbMakanan.Items.Add("Paket Ayam Goreng");
            cbMakanan.Items.Add("Nasi Goreng");
            cbMakanan.Items.Add("Ayam Geprek");
            cbMakanan.Items.Add("Tumis Kangkung");
            cbMakanan.Items.Add("Salad Sayur");
            cbMinuman.Items.Add("Kopi Hitam");
            cbMinuman.Items.Add("Jus Strawberry");
            cbMinuman.Items.Add("Esteh Manis");
            cbMinuman.Items.Add("Jus Mangga");
            cbMinuman.Items.Add("Es Kelapa Muda");
        }

        private void cbMakanan_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;

            pilih = cbMakanan.SelectedIndex;
            switch (pilih)
            { 
                case 0:
                    txtHargaMakanan.Text = "50000";
                    break;
                case 1:
                    txtHargaMakanan.Text = "36000";
                    break;
                case 2:
                    txtHargaMakanan.Text = "25000";
                    break;
                case 3:
                    txtHargaMakanan.Text = "24000";
                    break;
                case 4:
                    txtHargaMakanan.Text = "20000";
                   
                    break;
                default:
                    txtHargaMakanan.Text = "0";
                    break;
            }
        }

        private void cbMinuman_SelectedIndexChanged(object sender, EventArgs e)
        {
            int pilih;
            pilih = cbMinuman.SelectedIndex;
            switch (pilih)
            {
                case 0:
                    txtHargaMinuman.Text = "20000";
                    break;
                case 1:
                    txtHargaMinuman.Text = "15000";
                    break;
                case 2:
                    txtHargaMinuman.Text = "20000";
                    break;
                case 3:
                    txtHargaMinuman.Text = "16000";
                    break;
                case 4:
                    txtHargaMinuman.Text = "17000";
                    break;
                default:
                    txtHargaMinuman.Text = "0";
                    break;
            }
        }
        private void txtSatuanMakanan_ValueChanged(object sender, EventArgs e)
        {
            UpdateSubtotalMakanan();
        }

        private void txtSatuanMinuman_ValueChanged(object sender, EventArgs e)
        {
            UpdateSubtotalMinuman();
        }
        private void UpdateSubtotalMakanan()
        {
            int hargaMakanan = Convert.ToInt32(txtHargaMakanan.Text);
            int jumlahMakanan = (int)txtSatuanMakanan.Value;
            int subtotalMakanan = hargaMakanan * jumlahMakanan;
            txtSubTotalMakanan.Text = subtotalMakanan.ToString();
            CalculateTotal();
        }

        private void UpdateSubtotalMinuman()
        {
            int hargaMinuman = Convert.ToInt32(txtHargaMinuman.Text);
            int jumlahMinuman = (int)txtSatuanMinuman.Value;
            int subtotalMinuman = hargaMinuman * jumlahMinuman;
            txtSubTotalMinuman.Text = subtotalMinuman.ToString();
            CalculateTotal();
        }

        private void txtBayar_TextChanged(object sender, EventArgs e)
        {
            if (txtBayar.Text == "" || txtBayar.Text == " ")
            {
                txtBayar.Text = "0";
            }
            else
            {
                int a = Convert.ToInt32(txtBayar.Text);
                int b = Convert.ToInt32(txtTotal.Text);
                int kembali = 0;
                kembali = a - b;
                txtKembali.Text = Convert.ToString(kembali);
            }
        }
        private void txtBayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btProses_Click(object sender, EventArgs e)
        {
            MessageBox.Show("========================" +
                "\n\tWarung Rahayu" +
                "\n\tKasir: " + txtNamaKasir.Text +
                "\n========================" +
                "\nPesan : " +
                "\n" + cbMakanan.Text + "\tRp. " + txtHargaMakanan.Text +
                "\n" + cbMinuman.Text + "\tRp. " + txtHargaMinuman.Text +
                "\n========================" +
                "\nTotal\t\t: Rp. " + txtTotal.Text +
                "\nBayar\t\t: Rp. " + txtBayar.Text +
                "\nKembali\t\t: Rp. " + txtKembali.Text
                );
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            cbMakanan.Text = "";
            cbMinuman.Text = "";
            txtHargaMakanan.Text = "0";
            txtHargaMinuman.Text = "0";
            txtTotal.Text = "0";
            txtBayar.Text = "0";
            txtKembali.Text = "0";   
            txtNamaKasir.Clear();
            txtSatuanMakanan.Value = 0;
            txtSatuanMinuman.Value = 0;
        }
        private void CalculateTotal()
        {
            int subtotalMakanan = Convert.ToInt32(txtSubTotalMakanan.Text);
            int subtotalMinuman = Convert.ToInt32(txtSubTotalMinuman.Text);
            int total = subtotalMakanan + subtotalMinuman; //Total dihitung dengan menjumlahkan subtotal makanan dan minuman (txtSubTotalMakanan dan txtSubTotalMinuman).
            txtTotal.Text = total.ToString(); //Total yang dihitung akan ditampilkan di txtTotal.
        }

        private void txtKembali_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNamaKasir_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHargaMakanan_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

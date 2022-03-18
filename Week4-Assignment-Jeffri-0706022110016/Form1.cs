using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_Assignment_Jeffri_0706022110016
{
    public partial class FormPenambahanData : Form
    {
        public static string[,] Data = new string[10, 3];
        public static int jumlahData = 0;
        public FormPenambahanData()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (jumlahData == 10)
            {
                MessageBox.Show("Data telah penuh!");
            }
            else
            {
                Data[jumlahData, 0] = tBNama1.Text;
                Data[jumlahData, 1] = tBAlamat1.Text;
                Data[jumlahData, 2] = tBTelp1.Text;
                jumlahData++;
                tBNama1.Clear();
                tBAlamat1.Clear();
                tBTelp1.Clear();
                tBNama1.Focus();
            }
        }

        private void FormPenambahanData_Load(object sender, EventArgs e)
        {

        }

        private void buttonLihatData_Click(object sender, EventArgs e)
        {
            FormTampilanData FormBaru = new FormTampilanData();
            FormBaru.Show();
            this.Hide();
        }

        private void tBTelp1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

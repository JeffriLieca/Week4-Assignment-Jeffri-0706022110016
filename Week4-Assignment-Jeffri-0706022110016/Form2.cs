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
    public partial class FormTampilanData : Form
    {
        public FormPenambahanData FormLama = new FormPenambahanData();
        public int dataSaatIni = 0;
        public FormTampilanData()
        {
            InitializeComponent();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormLama.Show();
            this.Hide();
        }

        private void buttonPrevData_Click(object sender, EventArgs e)
        {
            if (dataSaatIni == 0)
            {
                MessageBox.Show("Data sudah data pertama");
            }
            else
            {
                dataSaatIni--;
                MenampilkanData();
            }
        }

        private void FormTampilanData_Load(object sender, EventArgs e)
        {
            MenampilkanData();
        }
        public void MenampilkanData()
        {
            tBNama2.Text = FormPenambahanData.Data[dataSaatIni, 0];
            tBAlamat2.Text = FormPenambahanData.Data[dataSaatIni, 1];
            tBTelp2.Text = FormPenambahanData.Data[dataSaatIni, 2];
        }

        private void buttonNextData_Click(object sender, EventArgs e)
        {
            if (dataSaatIni == 9)
            {
                MessageBox.Show("Data sudah data terakhir");
            }
            else
            {
                dataSaatIni++;
                MenampilkanData();
            }
        }
    }
}

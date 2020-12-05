using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hasil_Perhitungan
{
    public partial class Form1 : Form
    {
        private IList<Calculator> listOfCalculator = new List<Calculator>();
        public Form1()
        {
            InitializeComponent();
        }

        private void FrmProses_OnCreate(Calculator cal)
        {
            listOfCalculator.Add(cal);
            ListBox item = new ListBox();

            Hasil.Items.Add(cal.NilaiHasil);
        }
        private void btnHitung_Click(object sender, EventArgs e)
        {
            FrmProses frmProses = new FrmProses("Calculator");
            frmProses.OnCreate += FrmProses_OnCreate;
            frmProses.ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmSAUShop : Form
    {
        public FrmSAUShop()
        {
            InitializeComponent();
        }

        private void FrmSAUShop_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer1.Start();
            //เรียก Button ให้ทำงาน
            btCancel.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);

        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            cbPen.Checked = false;
            cbPencil.Checked = false;
            cbRubber.Checked = false;
            cbRuler.Checked = false;
            cbBook.Checked = false;
            tbPen.Clear();
            tbPencil.Clear();
            tbRubber.Clear();
            tbRuler.Clear();
            tbBook.Clear();
            tbPen.Enabled = false;
            tbPencil.Enabled = false;
            tbRubber.Enabled = false;
            tbRuler.Enabled = false;
            tbBook.Enabled = false;
            lbPen.Text = "0.00";
            lbPencil.Text = "0.00";
            lbRubber.Text = "0.00";
            lbRuler.Text = "0.00";
            lbBook.Text = "0.00";
            cbbSale.SelectedIndex = 0;
            lbShowTotalPay.Text = "0.00";
        }

        private void cbPen_Click(object sender, EventArgs e)
        {
            if (cbPen.Checked == true)
            {
                tbPen.Enabled = true;
            }
            else
            {                
                tbPen.Clear();
                tbPen.Enabled = false;
                lbPen.Text = "0.00";
            }
        }

        private void cbPencil_Click(object sender, EventArgs e)
        {
            if (cbPencil.Checked == true)
            {
                tbPencil.Enabled = true;
            }
            else
            {
                tbPencil.Clear();
                tbPencil.Enabled = false;
                lbPencil.Text = "0.00";
            }
        }

        private void cbRubber_Click(object sender, EventArgs e)
        {
            if (cbRubber.Checked == true)
            {
                tbRubber.Enabled = true;
            }
            else
            {
                tbRubber.Clear();
                tbRubber.Enabled = false;
                lbRubber.Text = "0.00";
            }
        }

        private void cbRuler_Click(object sender, EventArgs e)
        {
            if (cbRuler.Checked == true)
            {
                tbRuler.Enabled = true;
            }
            else
            {
                tbRuler.Clear();
                tbRuler.Enabled = false;
                lbRuler.Text = "0.00";
            }
        }

        private void cbBook_Click(object sender, EventArgs e)
        {
            if (cbBook.Checked == true)
            {
                tbBook.Enabled = true;
            }
            else
            {
                tbBook.Clear();
                tbBook.Enabled = false;
                lbBook.Text = "0.00";
            }
        }

        private void tbPen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void tbPencil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbRubber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbRuler_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbPen_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPen.Text.Length > 0){
                int quntity = int.Parse(tbPen.Text);
                double price = 5 * quntity;
                lbPen.Text = price.ToString("0.00");
            }
            else
            {
                lbPen.Text = "0.00";
            }            
        }

        private void tbPencil_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbPencil.Text.Length > 0)
            {
                int quntity = int.Parse(tbPencil.Text);
                double price = 1.5 * quntity;
                lbPencil.Text = price.ToString("0.00");
            }
            else
            {
                lbPencil.Text = "0.00";
            }
        }

        private void tbRubber_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbRubber.Text.Length > 0)
            {
                int quntity = int.Parse(tbRubber.Text);
                double price = 2.5 * quntity;
                lbRubber.Text = price.ToString("0.00");
            }
            else
            {
                lbRubber.Text = "0.00";
            }
        }

        private void tbRuler_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbRuler.Text.Length > 0)
            {
                int quntity = int.Parse(tbRuler.Text);
                double price = 2 * quntity;
                lbRuler.Text = price.ToString("0.00");
            }
            else
            {
                lbRuler.Text = "0.00";
            }
        }

        private void tbBook_KeyUp(object sender, KeyEventArgs e)
        {
            if (tbBook.Text.Length > 0)
            {
                int quntity = int.Parse(tbBook.Text);
                double price = 10.25 * quntity;
                lbBook.Text = price.ToString("0.00");
            }
            else
            {
                lbBook.Text = "0.00";
            }
        }

        private void btCalculate_Click(object sender, EventArgs e)
        {
            //รวมราคายังไม่คิดส่วนลด
            double totalPay = 
                Double.Parse( lbPen.Text ) +
                Double.Parse( lbPencil.Text ) +
                Double.Parse( lbRubber.Text ) +
                Double.Parse( lbRuler.Text ) +
                Double.Parse( lbBook.Text );
            //ตรวจสอบส่วนลดเพื่อคำนวณราคาสุทธิ แล้วแสดงผล
           if (cbbSale.SelectedIndex == 0)
            {
                totalPay = totalPay - (totalPay * 5 / 100);
            }
            else if (cbbSale.SelectedIndex == 1)
            {
                totalPay = totalPay - (totalPay * 10 / 100);
            }
            else if (cbbSale.SelectedIndex == 2)
            {
                totalPay = totalPay - (totalPay * 15 / 100);
            }
            lbShowTotalPay.Text = totalPay.ToString("#,###,###,##0.00");
        }
    }
}

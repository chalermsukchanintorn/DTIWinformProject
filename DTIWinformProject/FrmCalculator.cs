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
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer1.Start();
            //ให้รายการแรกของ ComboBox ถูกเลือก
            cbbDecimal.SelectedIndex = 0;
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

        private void cbbDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void tbNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // ตรวจสอบว่าคีย์ที่ป้อนเป็นตัวเลขหรือจุด
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // ไม่อนุญาตให้ป้อนคีย์นี้
            }

            // ตรวจสอบว่ามีจุดอยู่แล้วในข้อความหรือไม่
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // ไม่อนุญาตให้ป้อนจุดอีก
            }
        }

        private void tbNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // ตรวจสอบว่าคีย์ที่ป้อนเป็นตัวเลขหรือจุด
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; // ไม่อนุญาตให้ป้อนคีย์นี้
            }

            // ตรวจสอบว่ามีจุดอยู่แล้วในข้อความหรือไม่
            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true; // ไม่อนุญาตให้ป้อนจุดอีก
            }
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            calNumber("+");
        }

        private void calNumber(string opt)
        {
            //Validate UI
            if (tbNum1.Text.Length == 0 || tbNum2.Text.Length == 0)
            {
                ShareData.showWaringMSG("ป้อนข้อมูลให้ครบก่อนคำนวณ");
            }
            else
            {
                //คำนวณได้ โดยอย่าลืมตรวจสอบการแสดงผลทศนิยม
                double num1 = double.Parse(tbNum1.Text);
                double num2 = double.Parse(tbNum2.Text);
                double result;
                //-------------------------
                if (opt == "+")
                {
                    result = num1 + num2;
                }
                else if (opt == "-")
                {
                    result = num1 - num2;
                }
                else if (opt == "*")
                {
                    result = num1 * num2;
                }
                else if (opt == "/")
                {
                    if (num2 == 0)
                    {
                        ShareData.showWaringMSG("ไม่สามารถหารด้วย 0 ได้");
                        return;
                    }
                    result = num1 / num2;
                }
                else
                {
                    result = Math.Pow(num1, num2);
                }
                //-------------------------
                if (cbbDecimal.SelectedIndex == 0)
                {
                    lbShowResult.Text = result.ToString("0.00");
                }
                else if (cbbDecimal.SelectedIndex == 1)
                {
                    lbShowResult.Text = result.ToString("0.00000");
                }
                else
                {
                    lbShowResult.Text = result.ToString("0.000000000");
                }
            }
        }

        private void btPow_Click(object sender, EventArgs e)
        {
            calNumber("^");
        }

        private void btDevide_Click(object sender, EventArgs e)
        {
            calNumber("/");
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            calNumber("*");
        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            calNumber("-");
        }
    }
}

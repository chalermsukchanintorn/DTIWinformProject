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
    public partial class FrmShapeArea : Form
    {
        public FrmShapeArea()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer1.Start();
        }

        private void FrmShapeArea_Load(object sender, EventArgs e)
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

        private void btCircleCal_Click(object sender, EventArgs e)
        {
            //validate ui
            if (tbRadius.Text.Length == 0)
            {
                ShareData.showWaringMSG("ป้อนรัศมีด้วย");
            }
            else
            {
                double r = double.Parse(tbRadius.Text);
                double result;
                if (rdCircleArea.Checked == true)
                {
                    result = Math.PI * Math.Pow(r, 2);
                }
                else
                {
                    result = 2 * Math.PI * r;
                }
                lbCircleShow.Text = result.ToString("0.00");
            }
        }

        private void btCircleCancel_Click(object sender, EventArgs e)
        {
            tbRadius.Clear();
            rdCircleArea.Checked = true;
            lbCircleShow.Text = "0.00";
        }

        private void  keyNumberAndDotOnly(object sender, KeyPressEventArgs e)
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

        private void tbRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

        private void tbSideAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            keyNumberAndDotOnly(sender, e);
        }

       
    }
}

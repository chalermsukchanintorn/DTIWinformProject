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
    public partial class FrmDooDung : Form
    {
        public FrmDooDung()
        {
            InitializeComponent();
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            mtbIDcard.Clear();
            tbFullname.Clear();
            dtpBirthDate.Value = DateTime.Now;
            nudWeight.Value = 0;
            nudHeight.Value = 0;

            lbIDcard.Text = "XXXXXXXXXX";
            lbFullname.Text = "XXXXXXXXXX";
            lbBirthDate.Text = "XXXXXXXXXX";
            lbAge.Text = "XXXXXXXXXX";
            lbWeight.Text = "XXXXXXXXXX";
            lbHeight.Text = "XXXXXXXXXX";
            lbBMI.Text = "XXXXXXXXXX";

            lbShowResult.Text = "ผลดวง";
        }

        private void FrmDooDung_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer1.Start();

            btNew.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = new CultureInfo("th-TH");
            tslbDateTime.Text = DateTime.Now.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy เวลา HH:mm:ss น.", cultureInfo);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }

        private void btMainMenu_Click(object sender, EventArgs e)
        {
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.Show();
            Hide();
        }

        private void btDooDung_Click(object sender, EventArgs e)
        {
            //Validate UI
            if (mtbIDcard.MaskCompleted == false)
            {
                ShareData.showWaringMSG("กรุณากรอกเลขบัตรประชาชนให้ครบ");
            }
            else if (tbFullname.Text.Trim().Length == 0)
            {
                ShareData.showWaringMSG("กรุณากรอกชื่อ-สกุล");
            }
            else if (dtpBirthDate.Value.Year >= DateTime.Now.Year)
            {
                ShareData.showWaringMSG("ปีเกิดต้องน้อยกว่าปีปัจจุบัน");
            }
            else if (nudWeight.Value == 0)
            {
                ShareData.showWaringMSG("กรุณากรอกน้ำหนัก");
            }
            else if (nudHeight.Value == 0)
            {
                ShareData.showWaringMSG("กรุณากรอกส่วนสูง");
            }
            else
            {
                lbIDcard.Text = mtbIDcard.Text;
                lbFullname.Text = tbFullname.Text.Trim();

                CultureInfo cultureInfo = new CultureInfo("th-TH");
                lbBirthDate.Text = dtpBirthDate.Value.ToString("วันที่ dd เดือน MMMM พ.ศ. yyyy", cultureInfo);

                int age = DateTime.Now.Year - dtpBirthDate.Value.Year;
                lbAge.Text = age.ToString();

                lbWeight.Text = nudWeight.Value.ToString("0.00");
                lbHeight.Text = nudHeight.Value.ToString("0.00");

                double height = (double)nudHeight.Value / 100;
                double bmi = (double)nudWeight.Value / Math.Pow(height, 2);
                lbBMI.Text = bmi.ToString("0.00");

                //ผลดวงจะดูจากเดือนเกิด
                int month = dtpBirthDate.Value.Month;

                switch (month)
                {
                    case 1: lbShowResult.Text = "มีโชคดีมาก111"; break;
                    case 2: lbShowResult.Text = "มีโชคดีมาก222"; break;
                    case 3: lbShowResult.Text = "มีโชคดีมาก333"; break;
                    case 4: lbShowResult.Text = "มีโชคดีมาก444"; break;
                    case 5: lbShowResult.Text = "มีโชคดีมาก555"; break;
                    case 6: lbShowResult.Text = "มีโชคดีมาก666"; break;
                    case 7: lbShowResult.Text = "มีโชคดีมาก777"; break;
                    case 8: lbShowResult.Text = "มีโชคดีมาก888"; break;
                    case 9: lbShowResult.Text = "มีโชคดีมาก999"; break;
                    case 10: lbShowResult.Text = "มีโชคดีมาก101010"; break;
                    case 11: lbShowResult.Text = "มีโชคดีมาก111111"; break;
                    case 12: lbShowResult.Text = "มีโชคดีมาก121212"; break;
                }

            }
        }

        private void tbFullname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

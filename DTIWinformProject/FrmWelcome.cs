using System;
using System.Globalization;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {
            tslbUsername.Text = ShareData.loginName + " (" + ShareData.loginType + ")";
            timer1.Start();
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

        private void btOk_Click(object sender, EventArgs e)
        {
            //Validate UI
            if (tbName.Text.Trim().Length == 0)
            {
                ShareData.showWaringMSG("ป้อนชื่อด้วย....");
            }
            else if ( dtpBirthDate.Value.Year >= DateTime.Now.Year )
            {
                ShareData.showWaringMSG("ปีเกิดต้องน้อยกว่าปีปัจจุบัน....");
            }
            else
            {
                //นำข้อมูลไปแสดงผล โดยต้องคำนวณอายุด้วย แล้ววันเดือนปีเกิดต้องแสดงเป็นวันที่ไทย
                int age = DateTime.Now.Year - dtpBirthDate.Value.Year;

                string birthDate = dtpBirthDate.Value.ToString("วันที่ d เดือน MMMM พ.ศ. yyyy", new CultureInfo("th-TH"));

                //string gender;
                //if (rdMale.Checked == true)
                //{ 
                //    gender = "ชาย";
                //}
                //else
                //{
                //    gender = "หญิง";
                //}
                string gender = rdMale.Checked == true ? "ชาย" : "หญิง";

                //เอาข้อมูลทั้งหมดที่จะแสดงมาเชื่อมต่อกัน
                string dataShow = "ชื่อ : " + tbName.Text + "\n" +
                                  "วันเกิด : " + birthDate + "\n" +
                                  "อายุ : " + age + " ปี\n" +
                                  "เพศ : " + gender;

                //แสดงที่ Label: lbShowResult
                lbShowResult.Text = dataShow;
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            // Clear UI
            tbName.Text = ""; //หรือ tbName.Clear();
            dtpBirthDate.Value = DateTime.Now;
            rdMale.Checked = true;
            lbShowResult.Text = "Welcome";
            tbName.Focus();
        }
    }
}

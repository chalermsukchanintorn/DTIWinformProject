using System;
using System.Windows.Forms;

namespace DTIWinformProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ต้องการบอกจากโปรแกรมใช่ไหม", "ยืนยัน",
                               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            { 
                Application.Exit();
            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            tbUsername.Clear();
            tbPassword.Clear();
            rdStudent.Checked = true;
            //rdTeacher.Checked = false; ไม่จำเป็นเนื่องด้วย Concept การทำงานของ RadioButton
            tbUsername.Focus();
        }

        private void showWaringMSG(String mgs) {
            MessageBox.Show(mgs, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            //Validate UI
            if ( tbUsername.Text.Trim().Length == 0 )
            {
                //MessageBox.Show("ป้อนชื่อผู้ใช้ด้วย","คำเตือน",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showWaringMSG("ป้อนชื่อผู้ใช้ด้วย");
            }
            else if( tbPassword.Text.Trim().Length == 0 )
            {
                //MessageBox.Show("ป้อนรหัสผ่านด้วย", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showWaringMSG("ป้อนรหัสผ่านด้วย");
            }
            else if (tbPassword.Text.Trim().Length < 6)
            {
                //MessageBox.Show("ป้อนรหัสผ่านต้อง 6 ตัวขึ้นไป", "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                showWaringMSG("ป้อนรหัสผ่านต้อง 6 ตัวขึ้นไป");
            }
            else
            {
                //ตรวจสอบชื่อผู้ใช้/รหัสผ่าน (sau/123456789, dti/987654321) เมื่อเข้า FrmMainMenu
                if ( (tbUsername.Text.Trim().ToLower() != "sau" || tbPassword.Text.Trim().ToLower() != "123456789") &&
                     (tbUsername.Text.Trim().ToLower() != "dti" || tbPassword.Text.Trim().ToLower() != "987654321") )
                {
                    //ชื่อผู้ใช้รหัสผ่านไม่ถูกต้อง แสดงข้อความเตือน
                    showWaringMSG("ชื่อผู้ใช้รหัสผ่านไม่ถูกต้อง");
                }
                else
                {
                    //ชื่อผู้ใช้รหัสผ่านถูกต้อง เปิด FrmMainMenu พร้อมส่งชื่อผู้ใช้ไปแสดงด้วย
                    ShareData.loginName = tbUsername.Text.Trim();

                    if (rdStudent.Checked == true)
                    {
                        ShareData.loginType = "student";
                    }
                    else
                    {
                        ShareData.loginType = "teacher";
                    }

                    FrmMainMenu frmMainMenu = new FrmMainMenu();
                    frmMainMenu.Show();
                    Hide(); //ปิดหน้าจอตัวเอง
                }
            }
        }
    }
}

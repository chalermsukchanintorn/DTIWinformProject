using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DTIWinformProject
{
    internal class ShareData
    {
        public static String loginName;
        public static String loginType;

        public static void showWaringMSG(String mgs)
        {
            MessageBox.Show(mgs, "คำเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class LoginScreen : UserControl
    {
        Form1 form1;
        public LoginScreen(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            form1.ScreenChange(this, 1);
        }
    }
}

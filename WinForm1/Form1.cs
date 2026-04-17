using System.Windows.Forms;

namespace WinForm1
{
    public partial class Form1 : Form
    {
        LoginScreen loginScreen;
        DisplayScreen displayScreen;
        public Form1()
        {
            InitializeComponent();

            loginScreen = new LoginScreen(this);
            displayScreen = new DisplayScreen();
            panel1.Controls.Add(loginScreen);
        }
        public void ScreenChange(object screen, int code)
        {
            if (screen == loginScreen)
            {
                panel1.Controls.Clear();
                panel1.Controls.Add(displayScreen);
                displayScreen.Dock = DockStyle.Fill;

            }
        }
    }
}

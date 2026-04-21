namespace Calculator
{
    public partial class VeryCoolCalC : Form
    {
        // ตัวแปรสำหรับเก็บค่าและสถานะ
        private double resultValue = 0;
        private string operationPerformed = "";
        private Button? activeOperatorButton = null;
        private Color originalButtonColor;
        private bool isOperationPerformed = false;

        public VeryCoolCalC()
        {
            InitializeComponent();

            // ปรับ behavior ของ display
            txtDisplay.ReadOnly = true;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.TabStop = false;

            this.ActiveControl = null;
        }

        // 1. ฟังก์ชันสำหรับปุ่มตัวเลข (btn0 ถึง btn9)
        private void Number_Click(object sender, EventArgs e)
        {
            ResetOperatorColor();
            if ((txtDisplay.Text == "0") || (isOperationPerformed))
            {
                txtDisplay.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;

            // ป้องกันการกดจุดทศนิยมซ้ำ
            if (button.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text = txtDisplay.Text + button.Text;
                }
            }
            else
            {
                txtDisplay.Text = txtDisplay.Text + button.Text;
            }
        }

        // 2. ฟังก์ชันสำหรับปุ่มเครื่องหมาย (btnPlus, btnMinus, btnMultiply, btnDivide)
        private void Operator_Click(object sender, EventArgs e)
        {
            if (activeOperatorButton != null)
            {
                activeOperatorButton.BackColor = SystemColors.Control;
                activeOperatorButton.FlatStyle = FlatStyle.Standard;
            }

            Button button = (Button)sender;

            if (resultValue != 0)
            {
                btnEqual.PerformClick();
                operationPerformed = button.Text;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(txtDisplay.Text);
                isOperationPerformed = true;
            }

            originalButtonColor = button.BackColor;

            // เปลี่ยนสีปุ่มที่เพิ่งกด
            button.BackColor = Color.LightSkyBlue;

            // จำไว้ว่าปุ่มไหนถูกไฮไลต์อยู่
            activeOperatorButton = button;
        }

        // 3. ฟังก์ชันสำหรับปุ่มเท่ากับ (=)
        private void btnEqual_Click(object sender, EventArgs e)
        {
            ResetOperatorColor();
            switch (operationPerformed)
            {
                case "+":
                    txtDisplay.Text = (resultValue + double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (resultValue - double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (resultValue * double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    if (txtDisplay.Text == "0")
                    {
                        txtDisplay.Text = "Error";
                    }
                    else
                    {
                        txtDisplay.Text = (resultValue / double.Parse(txtDisplay.Text)).ToString();
                    }
                    break;
                default:
                    break;
            }

            // อัปเดตค่าผลลัพธ์และรีเซ็ตเครื่องหมาย
            if (txtDisplay.Text != "Error")
            {
                resultValue = double.Parse(txtDisplay.Text);
            }
            operationPerformed = "";
        }

        // 4. ฟังก์ชันสำหรับปุ่มล้างค่า (C)
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            resultValue = 0;
            operationPerformed = "";
        }

        // 5. ฟังก์ชันสำหรับปุ่มลบทีละตัว (Del)
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0 && txtDisplay.Text != "Error")
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);
            }

            if (txtDisplay.Text == "" || txtDisplay.Text == "-")
            {
                txtDisplay.Text = "0";
            }
        }

        // 6. ฟังก์ชันสำหรับปุ่มสลับค่าบวก/ลบ (+/-)
        private void btnSign_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text != "0" && txtDisplay.Text != "Error")
            {
                if (txtDisplay.Text.StartsWith("-"))
                {
                    txtDisplay.Text = txtDisplay.Text.Substring(1);
                }
                else
                {
                    txtDisplay.Text = "-" + txtDisplay.Text;
                }
            }
        }
        private void ResetOperatorColor()
        {
            if (activeOperatorButton != null)
            {
                activeOperatorButton.UseVisualStyleBackColor = true;
                activeOperatorButton.FlatStyle = FlatStyle.Standard;

                activeOperatorButton = null;
            }
        }
    }
}

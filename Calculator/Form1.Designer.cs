namespace Calculator
{
    partial class VeryCoolCalC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiply = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnEqual = new Button();
            btn0 = new Button();
            btnDivide = new Button();
            btmDelete = new Button();
            btnPoint = new Button();
            btnClear = new Button();
            btnSign = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = SystemColors.ControlLightLight;
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(8, 47);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(322, 44);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.Location = new Point(8, 179);
            btn7.Name = "btn7";
            btn7.Size = new Size(76, 76);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += Number_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(90, 179);
            btn8.Name = "btn8";
            btn8.Size = new Size(76, 76);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += Number_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(172, 179);
            btn9.Name = "btn9";
            btn9.Size = new Size(76, 76);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += Number_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(254, 97);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(76, 76);
            btnMultiply.TabIndex = 4;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += Operator_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(8, 261);
            btn4.Name = "btn4";
            btn4.Size = new Size(76, 76);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += Number_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(90, 261);
            btn5.Name = "btn5";
            btn5.Size = new Size(76, 76);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += Number_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(172, 261);
            btn6.Name = "btn6";
            btn6.Size = new Size(76, 76);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += Number_Click;
            // 
            // btnMinus
            // 
            btnMinus.Location = new Point(254, 179);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(76, 76);
            btnMinus.TabIndex = 8;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += Operator_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(254, 261);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(76, 76);
            btnPlus.TabIndex = 12;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += Operator_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(172, 343);
            btn3.Name = "btn3";
            btn3.Size = new Size(76, 76);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += Number_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(90, 343);
            btn2.Name = "btn2";
            btn2.Size = new Size(76, 76);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += Number_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(8, 343);
            btn1.Name = "btn1";
            btn1.Size = new Size(76, 76);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += Number_Click;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.LightSkyBlue;
            btnEqual.Location = new Point(254, 343);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(76, 158);
            btnEqual.TabIndex = 16;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(90, 425);
            btn0.Name = "btn0";
            btn0.Size = new Size(76, 76);
            btn0.TabIndex = 14;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += Number_Click;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(172, 97);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(76, 76);
            btnDivide.TabIndex = 20;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            btnDivide.Click += Operator_Click;
            // 
            // btmDelete
            // 
            btmDelete.Location = new Point(8, 97);
            btmDelete.Name = "btmDelete";
            btmDelete.Size = new Size(76, 76);
            btmDelete.TabIndex = 17;
            btmDelete.Text = "Del";
            btmDelete.UseVisualStyleBackColor = true;
            btmDelete.Click += btnDelete_Click;
            // 
            // btnPoint
            // 
            btnPoint.Location = new Point(172, 425);
            btnPoint.Name = "btnPoint";
            btnPoint.Size = new Size(76, 76);
            btnPoint.TabIndex = 21;
            btnPoint.Text = ".";
            btnPoint.UseVisualStyleBackColor = true;
            btnPoint.Click += Number_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(90, 97);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(76, 76);
            btnClear.TabIndex = 24;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSign
            // 
            btnSign.Location = new Point(8, 425);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(76, 76);
            btnSign.TabIndex = 22;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            btnSign.Click += btnSign_Click;
            // 
            // VeryCoolCalC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 510);
            Controls.Add(btnClear);
            Controls.Add(btnSign);
            Controls.Add(btnPoint);
            Controls.Add(btnDivide);
            Controls.Add(btmDelete);
            Controls.Add(btnEqual);
            Controls.Add(btn0);
            Controls.Add(btnPlus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMinus);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnMultiply);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtDisplay);
            Name = "VeryCoolCalC";
            Text = "VeryCoolCalC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiply;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMinus;
        private Button btnPlus;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnEqual;
        private Button btn0;
        private Button btnDivide;
        private Button btmDelete;
        private Button btnPoint;
        private Button btnClear;
        private Button btnSign;
    }
}

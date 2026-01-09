namespace Restaurant
{
    partial class Form1
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
            textBox1 = new TextBox();
            Send = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(495, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Send";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Send
            // 
            Send.Location = new Point(538, 35);
            Send.Name = "Send";
            Send.Size = new Size(75, 23);
            Send.TabIndex = 1;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 450);
            Controls.Add(Send);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Waiter Form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Send;
    }
}

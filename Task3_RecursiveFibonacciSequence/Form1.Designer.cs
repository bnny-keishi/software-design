namespace Task3_RecursiveFibonacciSequence
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
            txtFibonacciInput = new TextBox();
            txtExponentInput = new TextBox();
            txtBaseInput = new TextBox();
            button1 = new Button();
            button2 = new Button();
            lblFibonacciResult = new Label();
            lblPowerResult = new Label();
            SuspendLayout();
            // 
            // txtFibonacciInput
            // 
            txtFibonacciInput.Location = new Point(229, 79);
            txtFibonacciInput.Name = "txtFibonacciInput";
            txtFibonacciInput.Size = new Size(100, 23);
            txtFibonacciInput.TabIndex = 0;
            txtFibonacciInput.TextChanged += textBox1_TextChanged;
            // 
            // txtExponentInput
            // 
            txtExponentInput.Location = new Point(229, 233);
            txtExponentInput.Name = "txtExponentInput";
            txtExponentInput.Size = new Size(100, 23);
            txtExponentInput.TabIndex = 1;
            // 
            // txtBaseInput
            // 
            txtBaseInput.Location = new Point(229, 204);
            txtBaseInput.Name = "txtBaseInput";
            txtBaseInput.Size = new Size(100, 23);
            txtBaseInput.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(80, 79);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 3;
            button1.Text = "Calculate Fibonacci";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculateFibonacci_Click;
            // 
            // button2
            // 
            button2.Location = new Point(80, 218);
            button2.Name = "button2";
            button2.Size = new Size(122, 23);
            button2.TabIndex = 4;
            button2.Text = "Calculate Power";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCalculatePower_Click;
            // 
            // lblFibonacciResult
            // 
            lblFibonacciResult.AutoSize = true;
            lblFibonacciResult.Location = new Point(379, 84);
            lblFibonacciResult.Name = "lblFibonacciResult";
            lblFibonacciResult.Size = new Size(38, 15);
            lblFibonacciResult.TabIndex = 5;
            lblFibonacciResult.Text = "label1";
            // 
            // lblPowerResult
            // 
            lblPowerResult.AutoSize = true;
            lblPowerResult.Location = new Point(381, 218);
            lblPowerResult.Name = "lblPowerResult";
            lblPowerResult.Size = new Size(38, 15);
            lblPowerResult.TabIndex = 6;
            lblPowerResult.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(579, 450);
            Controls.Add(lblPowerResult);
            Controls.Add(lblFibonacciResult);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtBaseInput);
            Controls.Add(txtExponentInput);
            Controls.Add(txtFibonacciInput);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFibonacciInput;
        private TextBox txtExponentInput;
        private TextBox txtBaseInput;
        private Button button1;
        private Button button2;
        private Label lblFibonacciResult;
        private Label lblPowerResult;
    }
}

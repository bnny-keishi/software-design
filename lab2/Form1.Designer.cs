namespace lab2
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
            txtInput = new TextBox();
            lblResult = new Label();
            btnCalculateFactorial = new Button();
            btnCalculateSum = new Button();
            txtArrayInput = new TextBox();
            lblSumResult = new Label();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(163, 82);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(294, 85);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(10, 15);
            lblResult.TabIndex = 1;
            lblResult.Text = " ";
            // 
            // btnCalculateFactorial
            // 
            btnCalculateFactorial.Location = new Point(12, 81);
            btnCalculateFactorial.Name = "btnCalculateFactorial";
            btnCalculateFactorial.Size = new Size(122, 23);
            btnCalculateFactorial.TabIndex = 2;
            btnCalculateFactorial.Text = "Calculate Factorial";
            btnCalculateFactorial.UseVisualStyleBackColor = true;
            btnCalculateFactorial.Click += btnCalculateFactorial_Click;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(12, 130);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(122, 23);
            btnCalculateSum.TabIndex = 3;
            btnCalculateSum.Text = "Calculate Sum";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(163, 131);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(100, 23);
            txtArrayInput.TabIndex = 4;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(294, 134);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(38, 15);
            lblSumResult.TabIndex = 5;
            lblSumResult.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 218);
            Controls.Add(lblSumResult);
            Controls.Add(txtArrayInput);
            Controls.Add(btnCalculateSum);
            Controls.Add(btnCalculateFactorial);
            Controls.Add(lblResult);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Label lblResult;
        private Button btnCalculateFactorial;
        private Button btnCalculateSum;
        private TextBox txtArrayInput;
        private Label lblSumResult;
    }
}

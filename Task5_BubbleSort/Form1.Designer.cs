namespace Task5_BubbleSort
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
            btnSort = new Button();
            listBoxResult = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.Location = new Point(42, 66);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(99, 34);
            btnSort.TabIndex = 0;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 15;
            listBoxResult.Location = new Point(171, 66);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(300, 244);
            listBoxResult.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 30);
            label1.TabIndex = 2;
            label1.Text = "Bubble Sort";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 48);
            label2.Name = "label2";
            label2.Size = new Size(175, 15);
            label2.TabIndex = 3;
            label2.Text = "Original: 64, 34, 25, 12, 22, 11, 90";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxResult);
            Controls.Add(btnSort);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSort;
        private ListBox listBoxResult;
        private Label label1;
        private Label label2;
    }
}

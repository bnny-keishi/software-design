namespace Task5_CustomDescendingOrder
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
            label2 = new Label();
            label1 = new Label();
            listBoxResult = new ListBox();
            btnSort = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 48);
            label2.Name = "label2";
            label2.Size = new Size(160, 15);
            label2.TabIndex = 7;
            label2.Text = "Original:  6, 5, 8, 9, 4, 1, 3, 2, 7";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(258, 30);
            label1.TabIndex = 6;
            label1.Text = "Custom Descending Order";
            label1.Click += label1_Click;
            // 
            // listBoxResult
            // 
            listBoxResult.FormattingEnabled = true;
            listBoxResult.ItemHeight = 15;
            listBoxResult.Location = new Point(171, 66);
            listBoxResult.Name = "listBoxResult";
            listBoxResult.Size = new Size(300, 244);
            listBoxResult.TabIndex = 5;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(42, 66);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(99, 34);
            btnSort.TabIndex = 4;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(490, 450);
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

        private Label label2;
        private Label label1;
        private ListBox listBoxResult;
        private Button btnSort;
    }
}

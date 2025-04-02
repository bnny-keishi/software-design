namespace lab3
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
            listBoxBooks = new ListBox();
            btnShowBooks = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.ItemHeight = 15;
            listBoxBooks.Location = new Point(125, 21);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(515, 169);
            listBoxBooks.TabIndex = 0;
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(16, 21);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(103, 33);
            btnShowBooks.TabIndex = 1;
            btnShowBooks.Text = "Show";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 450);
            Controls.Add(btnShowBooks);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxBooks;
        private Button btnShowBooks;
    }
}

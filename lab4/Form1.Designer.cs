namespace lab4
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
            btnShowInfo = new Button();
            listBoxBooks = new ListBox();
            SuspendLayout();
            // 
            // btnShowInfo
            // 
            btnShowInfo.Location = new Point(353, 21);
            btnShowInfo.Name = "btnShowInfo";
            btnShowInfo.Size = new Size(94, 29);
            btnShowInfo.TabIndex = 3;
            btnShowInfo.Text = "Show Info";
            btnShowInfo.UseVisualStyleBackColor = true;
            btnShowInfo.Click += btnShowInfo_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(12, 65);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(776, 364);
            listBoxBooks.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowInfo);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowInfo;
        private ListBox listBoxBooks;
    }
}

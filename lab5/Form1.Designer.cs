namespace lab5
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
            label1 = new Label();
            txtboxAuthorName = new TextBox();
            btnAddBook = new Button();
            listBoxBooks = new ListBox();
            label2 = new Label();
            txtboxBookTitle = new TextBox();
            btnShowBooks = new Button();
            btnSearchBooks = new Button();
            txtboxBookID = new TextBox();
            label3 = new Label();
            btnDeleteBook = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 0;
            label1.Text = "Author:";
            // 
            // txtboxAuthorName
            // 
            txtboxAuthorName.Location = new Point(84, 18);
            txtboxAuthorName.Name = "txtboxAuthorName";
            txtboxAuthorName.Size = new Size(294, 27);
            txtboxAuthorName.TabIndex = 1;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(84, 107);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 52);
            btnAddBook.TabIndex = 2;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(402, 18);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(386, 424);
            listBoxBooks.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 60);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 4;
            label2.Text = "Title:";
            // 
            // txtboxBookTitle
            // 
            txtboxBookTitle.Location = new Point(84, 57);
            txtboxBookTitle.Name = "txtboxBookTitle";
            txtboxBookTitle.Size = new Size(294, 27);
            txtboxBookTitle.TabIndex = 5;
            // 
            // btnShowBooks
            // 
            btnShowBooks.Location = new Point(284, 107);
            btnShowBooks.Name = "btnShowBooks";
            btnShowBooks.Size = new Size(94, 52);
            btnShowBooks.TabIndex = 6;
            btnShowBooks.Text = "Show Books";
            btnShowBooks.UseVisualStyleBackColor = true;
            btnShowBooks.Click += btnShowBooks_Click;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Location = new Point(184, 107);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(94, 52);
            btnSearchBooks.TabIndex = 7;
            btnSearchBooks.Text = "Search Books";
            btnSearchBooks.UseVisualStyleBackColor = true;
            btnSearchBooks.Click += btnSearchBook_Click;
            // 
            // txtboxBookID
            // 
            txtboxBookID.Location = new Point(134, 248);
            txtboxBookID.Name = "txtboxBookID";
            txtboxBookID.Size = new Size(194, 27);
            txtboxBookID.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 214);
            label3.Name = "label3";
            label3.Size = new Size(242, 20);
            label3.TabIndex = 8;
            label3.Text = "Enter the Book ID to delete a Book.";
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(184, 290);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(94, 52);
            btnDeleteBook.TabIndex = 10;
            btnDeleteBook.Text = "Delete Book";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteBook);
            Controls.Add(txtboxBookID);
            Controls.Add(label3);
            Controls.Add(btnSearchBooks);
            Controls.Add(btnShowBooks);
            Controls.Add(txtboxBookTitle);
            Controls.Add(label2);
            Controls.Add(listBoxBooks);
            Controls.Add(btnAddBook);
            Controls.Add(txtboxAuthorName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtboxAuthorName;
        private Button btnAddBook;
        private ListBox listBoxBooks;
        private Label label2;
        private TextBox txtboxBookTitle;
        private Button btnShowBooks;
        private Button btnSearchBooks;
        private TextBox txtboxBookID;
        private Label label3;
        private Button btnDeleteBook;
    }
}

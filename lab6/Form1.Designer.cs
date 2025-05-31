namespace lab6
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
            txtboxBookTitle = new TextBox();
            label2 = new Label();
            btnAddBook = new Button();
            btnUpdateBook = new Button();
            btnSearchBooks = new Button();
            label3 = new Label();
            txtboxBookID = new TextBox();
            button1 = new Button();
            btnFetchBooks = new Button();
            listBoxBooks = new ListBox();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 0;
            label1.Text = "Author's Name:";
            // 
            // txtboxAuthorName
            // 
            txtboxAuthorName.Location = new Point(12, 32);
            txtboxAuthorName.Name = "txtboxAuthorName";
            txtboxAuthorName.Size = new Size(294, 27);
            txtboxAuthorName.TabIndex = 1;
            // 
            // txtboxBookTitle
            // 
            txtboxBookTitle.Location = new Point(12, 103);
            txtboxBookTitle.Name = "txtboxBookTitle";
            txtboxBookTitle.Size = new Size(294, 27);
            txtboxBookTitle.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Book Title:";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(12, 148);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 57);
            btnAddBook.TabIndex = 4;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(112, 148);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(94, 57);
            btnUpdateBook.TabIndex = 5;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Location = new Point(212, 148);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(94, 57);
            btnSearchBooks.TabIndex = 6;
            btnSearchBooks.Text = "Search Books";
            btnSearchBooks.UseVisualStyleBackColor = true;
            btnSearchBooks.Click += btnSearchBook_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 324);
            label3.Name = "label3";
            label3.Size = new Size(217, 20);
            label3.TabIndex = 8;
            label3.Text = "Enter Book ID to delete a book.";
            // 
            // txtboxBookID
            // 
            txtboxBookID.Location = new Point(75, 347);
            txtboxBookID.Name = "txtboxBookID";
            txtboxBookID.Size = new Size(172, 27);
            txtboxBookID.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(113, 380);
            button1.Name = "button1";
            button1.Size = new Size(94, 57);
            button1.TabIndex = 9;
            button1.Text = "Delete Book";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnDeleteBook_Click;
            // 
            // btnFetchBooks
            // 
            btnFetchBooks.Location = new Point(112, 231);
            btnFetchBooks.Name = "btnFetchBooks";
            btnFetchBooks.Size = new Size(94, 57);
            btnFetchBooks.TabIndex = 10;
            btnFetchBooks.Text = "Fetch Books";
            btnFetchBooks.UseVisualStyleBackColor = true;
            btnFetchBooks.Click += btnFetchBooks_Click;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(323, 29);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(465, 404);
            listBoxBooks.TabIndex = 11;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(393, 231);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(331, 29);
            progressBar.TabIndex = 12;
            progressBar.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar);
            Controls.Add(listBoxBooks);
            Controls.Add(btnFetchBooks);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtboxBookID);
            Controls.Add(btnSearchBooks);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnAddBook);
            Controls.Add(label2);
            Controls.Add(txtboxBookTitle);
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
        private TextBox txtboxBookTitle;
        private Label label2;
        private Button btnAddBook;
        private Button btnUpdateBook;
        private Button btnSearchBooks;
        private Label label3;
        private TextBox txtboxBookID;
        private Button button1;
        private Button btnFetchBooks;
        private ListBox listBoxBooks;
        private ProgressBar progressBar;
    }
}

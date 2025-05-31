namespace lab7
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
            txtboxBookTitle = new TextBox();
            listBoxBooks = new ListBox();
            txtboxAuthorName = new TextBox();
            label2 = new Label();
            btnAddBook = new Button();
            btnExportBooks = new Button();
            btnSearchBooks = new Button();
            btnImportBooks = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            lblPageNumber = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Book Title:";
            // 
            // txtboxBookTitle
            // 
            txtboxBookTitle.Location = new Point(12, 33);
            txtboxBookTitle.Name = "txtboxBookTitle";
            txtboxBookTitle.Size = new Size(316, 27);
            txtboxBookTitle.TabIndex = 1;
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(350, 10);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(438, 384);
            listBoxBooks.TabIndex = 2;
            // 
            // txtboxAuthorName
            // 
            txtboxAuthorName.Location = new Point(12, 94);
            txtboxAuthorName.Name = "txtboxAuthorName";
            txtboxAuthorName.Size = new Size(316, 27);
            txtboxAuthorName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 3;
            label2.Text = "Author Name:";
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(62, 138);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 56);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnExportBooks
            // 
            btnExportBooks.Location = new Point(185, 138);
            btnExportBooks.Name = "btnExportBooks";
            btnExportBooks.Size = new Size(94, 56);
            btnExportBooks.TabIndex = 6;
            btnExportBooks.Text = "Export Books";
            btnExportBooks.UseVisualStyleBackColor = true;
            btnExportBooks.Click += btnExportBooks_Click;
            // 
            // btnSearchBooks
            // 
            btnSearchBooks.Location = new Point(62, 214);
            btnSearchBooks.Name = "btnSearchBooks";
            btnSearchBooks.Size = new Size(94, 56);
            btnSearchBooks.TabIndex = 7;
            btnSearchBooks.Text = "Search Books";
            btnSearchBooks.UseVisualStyleBackColor = true;
            btnSearchBooks.Click += btnSearchBooks_Click;
            // 
            // btnImportBooks
            // 
            btnImportBooks.Location = new Point(185, 214);
            btnImportBooks.Name = "btnImportBooks";
            btnImportBooks.Size = new Size(94, 56);
            btnImportBooks.TabIndex = 8;
            btnImportBooks.Text = "Import Books";
            btnImportBooks.UseVisualStyleBackColor = true;
            btnImportBooks.Click += btnImportBooks_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(405, 400);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(94, 38);
            btnPrevious.TabIndex = 9;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPreviousPage_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(661, 400);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(94, 38);
            btnNext.TabIndex = 10;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNextPage_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.AutoSize = true;
            lblPageNumber.Location = new Point(505, 409);
            lblPageNumber.MinimumSize = new Size(150, 20);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(150, 20);
            lblPageNumber.TabIndex = 11;
            lblPageNumber.Text = "Page";
            lblPageNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPageNumber);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnImportBooks);
            Controls.Add(btnSearchBooks);
            Controls.Add(btnExportBooks);
            Controls.Add(btnAddBook);
            Controls.Add(txtboxAuthorName);
            Controls.Add(label2);
            Controls.Add(listBoxBooks);
            Controls.Add(txtboxBookTitle);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtboxBookTitle;
        private ListBox listBoxBooks;
        private TextBox txtboxAuthorName;
        private Label label2;
        private Button btnAddBook;
        private Button btnExportBooks;
        private Button btnSearchBooks;
        private Button btnImportBooks;
        private Button btnPrevious;
        private Button btnNext;
        private Label lblPageNumber;
    }
}

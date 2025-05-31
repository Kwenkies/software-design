namespace lab6
{
    partial class AsynchronousUpdateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtboxAuthorName = new TextBox();
            label1 = new Label();
            btnUpdateBook = new Button();
            label2 = new Label();
            txtboxBookTitle = new TextBox();
            lblAuthorName = new Label();
            lblBookTitle = new Label();
            SuspendLayout();
            // 
            // txtboxAuthorName
            // 
            txtboxAuthorName.Location = new Point(12, 32);
            txtboxAuthorName.Name = "txtboxAuthorName";
            txtboxAuthorName.Size = new Size(432, 27);
            txtboxAuthorName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 1;
            label1.Text = "Author's Name:";
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(181, 159);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(94, 60);
            btnUpdateBook.TabIndex = 2;
            btnUpdateBook.Text = "Update Book";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 72);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 3;
            label2.Text = "Book Title:";
            // 
            // txtboxBookTitle
            // 
            txtboxBookTitle.Location = new Point(12, 99);
            txtboxBookTitle.Name = "txtboxBookTitle";
            txtboxBookTitle.Size = new Size(432, 27);
            txtboxBookTitle.TabIndex = 4;
            // 
            // lblAuthorName
            // 
            lblAuthorName.AutoSize = true;
            lblAuthorName.Location = new Point(128, 9);
            lblAuthorName.Name = "lblAuthorName";
            lblAuthorName.Size = new Size(0, 20);
            lblAuthorName.TabIndex = 5;
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.Location = new Point(97, 72);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(0, 20);
            lblBookTitle.TabIndex = 6;
            // 
            // AsynchronousUpdateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 259);
            Controls.Add(lblBookTitle);
            Controls.Add(lblAuthorName);
            Controls.Add(txtboxBookTitle);
            Controls.Add(label2);
            Controls.Add(btnUpdateBook);
            Controls.Add(label1);
            Controls.Add(txtboxAuthorName);
            Name = "AsynchronousUpdateForm";
            Text = "Update Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtboxAuthorName;
        private Label label1;
        private Button btnUpdateBook;
        private Label label2;
        private TextBox txtboxBookTitle;
        public Label lblAuthorName;
        public Label lblBookTitle;
    }
}
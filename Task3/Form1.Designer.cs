namespace Task3
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
            btnShowinfo = new Button();
            SuspendLayout();
            // 
            // listBoxBooks
            // 
            listBoxBooks.FormattingEnabled = true;
            listBoxBooks.Location = new Point(218, 104);
            listBoxBooks.Name = "listBoxBooks";
            listBoxBooks.Size = new Size(505, 264);
            listBoxBooks.TabIndex = 0;
            // 
            // btnShowinfo
            // 
            btnShowinfo.Location = new Point(46, 104);
            btnShowinfo.Name = "btnShowinfo";
            btnShowinfo.Size = new Size(94, 29);
            btnShowinfo.TabIndex = 1;
            btnShowinfo.Text = "Show Info";
            btnShowinfo.UseVisualStyleBackColor = true;
            btnShowinfo.Click += btnShowinfo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowinfo);
            Controls.Add(listBoxBooks);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxBooks;
        private Button btnShowinfo;
    }
}

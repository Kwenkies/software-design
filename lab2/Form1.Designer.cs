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
            btn = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(368, 188);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(125, 27);
            txtInput.TabIndex = 0;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(585, 195);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(52, 20);
            lblResult.TabIndex = 1;
            lblResult.Text = "Result:";
            // 
            // btn
            // 
            btn.Location = new Point(156, 186);
            btn.Name = "btn";
            btn.Size = new Size(94, 29);
            btn.TabIndex = 2;
            btn.Text = "Calculate";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btnCalculateFactorial_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 486);
            Controls.Add(btn);
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
        private Button btn;
    }
}

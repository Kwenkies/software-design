namespace Task2
{
    partial class Task2
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
            txtArrayInput = new TextBox();
            btnCalculateSum = new Button();
            lblSumResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(245, 115);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "Sum of Array Elements";
            // 
            // txtArrayInput
            // 
            txtArrayInput.Location = new Point(245, 167);
            txtArrayInput.Name = "txtArrayInput";
            txtArrayInput.Size = new Size(356, 27);
            txtArrayInput.TabIndex = 1;
            // 
            // btnCalculateSum
            // 
            btnCalculateSum.Location = new Point(98, 167);
            btnCalculateSum.Name = "btnCalculateSum";
            btnCalculateSum.Size = new Size(94, 29);
            btnCalculateSum.TabIndex = 3;
            btnCalculateSum.Text = "Calculate";
            btnCalculateSum.UseVisualStyleBackColor = true;
            btnCalculateSum.Click += btnCalculateSum_Click;
            // 
            // lblSumResult
            // 
            lblSumResult.AutoSize = true;
            lblSumResult.Location = new Point(245, 228);
            lblSumResult.Name = "lblSumResult";
            lblSumResult.Size = new Size(52, 20);
            lblSumResult.TabIndex = 4;
            lblSumResult.Text = "Result:";
            // 
            // Task2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSumResult);
            Controls.Add(btnCalculateSum);
            Controls.Add(txtArrayInput);
            Controls.Add(label1);
            Name = "Task2";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtArrayInput;
        private Button btnCalculateSum;
        private Label lblSumResult;
    }
}

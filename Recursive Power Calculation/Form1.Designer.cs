namespace Recursive_Power_Calculation
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
            textBoxN = new TextBox();
            textBoxX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            labelResult = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(345, 174);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(125, 27);
            textBoxN.TabIndex = 0;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(345, 117);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(125, 27);
            textBoxX.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 120);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 2;
            label1.Text = "Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 181);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 3;
            label2.Text = "Exponent";
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(345, 242);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(52, 20);
            labelResult.TabIndex = 4;
            labelResult.Text = "Result:";
            // 
            // button1
            // 
            button1.Location = new Point(41, 117);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxX);
            Controls.Add(textBoxN);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxN;
        private TextBox textBoxX;
        private Label label1;
        private Label label2;
        private Label labelResult;
        private Button button1;
    }
}

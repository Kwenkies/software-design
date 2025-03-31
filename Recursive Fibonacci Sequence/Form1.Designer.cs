namespace Recursive_Fibonacci_Sequence
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
            textInput = new TextBox();
            labelResult = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textInput
            // 
            textInput.Location = new Point(289, 156);
            textInput.Name = "textInput";
            textInput.Size = new Size(181, 27);
            textInput.TabIndex = 0;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(540, 163);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(52, 20);
            labelResult.TabIndex = 1;
            labelResult.Text = "Result:";
            // 
            // button1
            // 
            button1.Location = new Point(134, 159);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(labelResult);
            Controls.Add(textInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textInput;
        private Label labelResult;
        private Button button1;
    }
}

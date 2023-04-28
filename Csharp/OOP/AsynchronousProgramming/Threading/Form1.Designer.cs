namespace Threading
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
            buttonForLoop = new Button();
            labelResult = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonForLoop
            // 
            buttonForLoop.Location = new Point(218, 74);
            buttonForLoop.Name = "buttonForLoop";
            buttonForLoop.Size = new Size(75, 23);
            buttonForLoop.TabIndex = 0;
            buttonForLoop.Text = "Execute";
            buttonForLoop.UseVisualStyleBackColor = true;
            buttonForLoop.Click += buttonForLoop_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(235, 110);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(38, 15);
            labelResult.TabIndex = 1;
            labelResult.Text = "label1";
            // 
            // button1
            // 
            button1.Location = new Point(355, 74);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 324);
            Controls.Add(button1);
            Controls.Add(labelResult);
            Controls.Add(buttonForLoop);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonForLoop;
        private Label labelResult;
        private Button button1;
    }
}
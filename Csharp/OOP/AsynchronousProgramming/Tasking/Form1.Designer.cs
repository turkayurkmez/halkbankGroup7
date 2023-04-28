namespace Tasking
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
            button1 = new Button();
            labelResult = new Label();
            buttonForLoop = new Button();
            progressBar1 = new ProgressBar();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(229, 102);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(109, 138);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(38, 15);
            labelResult.TabIndex = 4;
            labelResult.Text = "label1";
            // 
            // buttonForLoop
            // 
            buttonForLoop.Location = new Point(92, 102);
            buttonForLoop.Name = "buttonForLoop";
            buttonForLoop.Size = new Size(75, 23);
            buttonForLoop.TabIndex = 3;
            buttonForLoop.Text = "Execute";
            buttonForLoop.UseVisualStyleBackColor = true;
            buttonForLoop.Click += buttonForLoop_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(142, 180);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 23);
            progressBar1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(880, 460);
            button2.Name = "button2";
            button2.Size = new Size(174, 23);
            button2.TabIndex = 7;
            button2.Text = "Get Data From Web";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(357, 29);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(697, 425);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 495);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(labelResult);
            Controls.Add(buttonForLoop);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label labelResult;
        private Button buttonForLoop;
        private ProgressBar progressBar1;
        private Button button2;
        private RichTextBox richTextBox1;
    }
}
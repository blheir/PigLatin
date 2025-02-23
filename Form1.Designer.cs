namespace PigLatin
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
            userWord = new TextBox();
            label2 = new Label();
            pigWord = new Label();
            oinkButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 255);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(141, 89);
            label1.Name = "label1";
            label1.Size = new Size(73, 21);
            label1.TabIndex = 0;
            label1.Text = "PigLatin";
            // 
            // userWord
            // 
            userWord.BackColor = Color.FromArgb(192, 255, 192);
            userWord.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userWord.Location = new Point(178, 166);
            userWord.Name = "userWord";
            userWord.Size = new Size(100, 24);
            userWord.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 255, 192);
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(64, 169);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Enter your word:";
            // 
            // pigWord
            // 
            pigWord.AutoSize = true;
            pigWord.BackColor = Color.FromArgb(255, 192, 255);
            pigWord.Font = new Font("Comic Sans MS", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pigWord.ForeColor = Color.Black;
            pigWord.Location = new Point(178, 230);
            pigWord.Name = "pigWord";
            pigWord.Size = new Size(0, 16);
            pigWord.TabIndex = 3;
            // 
            // oinkButton
            // 
            oinkButton.BackColor = Color.FromArgb(255, 192, 255);
            oinkButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            oinkButton.Location = new Point(64, 227);
            oinkButton.Name = "oinkButton";
            oinkButton.Size = new Size(75, 23);
            oinkButton.TabIndex = 4;
            oinkButton.Text = "Oink!";
            oinkButton.UseVisualStyleBackColor = false;
            oinkButton.Click += oinkButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._41mlwEcGTuL__AC_UF894_1000_QL80_;
            ClientSize = new Size(800, 450);
            Controls.Add(oinkButton);
            Controls.Add(pigWord);
            Controls.Add(label2);
            Controls.Add(userWord);
            Controls.Add(label1);
            Name = "Form1";
            Text = "PigLatin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userWord;
        private Label label2;
        private Label pigWord;
        private Button oinkButton;
    }
}

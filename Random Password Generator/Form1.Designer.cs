namespace Random_Password_Generator
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
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordLengthLabel = new System.Windows.Forms.Label();
            this.LengthSlide = new System.Windows.Forms.TrackBar();
            this.CopyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LengthSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLabel.Location = new System.Drawing.Point(41, 38);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(297, 76);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLengthLabel
            // 
            this.PasswordLengthLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLengthLabel.Location = new System.Drawing.Point(41, 150);
            this.PasswordLengthLabel.Name = "PasswordLengthLabel";
            this.PasswordLengthLabel.Size = new System.Drawing.Size(297, 76);
            this.PasswordLengthLabel.TabIndex = 1;
            this.PasswordLengthLabel.Text = "Password Length: 5";
            this.PasswordLengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LengthSlide
            // 
            this.LengthSlide.LargeChange = 1;
            this.LengthSlide.Location = new System.Drawing.Point(41, 250);
            this.LengthSlide.Maximum = 20;
            this.LengthSlide.Minimum = 5;
            this.LengthSlide.Name = "LengthSlide";
            this.LengthSlide.Size = new System.Drawing.Size(297, 56);
            this.LengthSlide.TabIndex = 2;
            this.LengthSlide.Value = 5;
            this.LengthSlide.Scroll += new System.EventHandler(this.LengthSlide_Scroll);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(94, 312);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(181, 51);
            this.CopyButton.TabIndex = 3;
            this.CopyButton.Text = "Copy The Password";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 423);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.LengthSlide);
            this.Controls.Add(this.PasswordLengthLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LengthSlide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label PasswordLabel;
        private Label PasswordLengthLabel;
        private TrackBar LengthSlide;
        private Button CopyButton;
    }
}
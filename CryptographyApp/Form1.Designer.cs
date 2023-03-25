
namespace CryptographyApp
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
            this.textToEncryptLB = new System.Windows.Forms.RichTextBox();
            this.textEncryptedLB = new System.Windows.Forms.RichTextBox();
            this.textDecryptedLB = new System.Windows.Forms.RichTextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textToEncryptLB
            // 
            this.textToEncryptLB.Location = new System.Drawing.Point(12, 58);
            this.textToEncryptLB.Name = "textToEncryptLB";
            this.textToEncryptLB.Size = new System.Drawing.Size(211, 248);
            this.textToEncryptLB.TabIndex = 0;
            this.textToEncryptLB.Text = "";
            // 
            // textEncryptedLB
            // 
            this.textEncryptedLB.Location = new System.Drawing.Point(331, 58);
            this.textEncryptedLB.Name = "textEncryptedLB";
            this.textEncryptedLB.Size = new System.Drawing.Size(211, 248);
            this.textEncryptedLB.TabIndex = 1;
            this.textEncryptedLB.Text = "";
            // 
            // textDecryptedLB
            // 
            this.textDecryptedLB.Location = new System.Drawing.Point(653, 58);
            this.textDecryptedLB.Name = "textDecryptedLB";
            this.textDecryptedLB.Size = new System.Drawing.Size(211, 248);
            this.textDecryptedLB.TabIndex = 2;
            this.textDecryptedLB.Text = "";
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(239, 158);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(75, 23);
            this.encryptBtn.TabIndex = 3;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(561, 158);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(75, 23);
            this.decryptBtn.TabIndex = 4;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Text to encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Encrypted text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(653, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Decrypted text";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 346);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.textDecryptedLB);
            this.Controls.Add(this.textEncryptedLB);
            this.Controls.Add(this.textToEncryptLB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textToEncryptLB;
        private System.Windows.Forms.RichTextBox textEncryptedLB;
        private System.Windows.Forms.RichTextBox textDecryptedLB;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


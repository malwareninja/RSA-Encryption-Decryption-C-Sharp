namespace RSA_Encryption_Decryption
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlainTextInput = new System.Windows.Forms.TextBox();
            this.CipherText = new System.Windows.Forms.TextBox();
            this.PlainTextOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EncButton = new System.Windows.Forms.Button();
            this.DecButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlainTextInput
            // 
            this.PlainTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainTextInput.Location = new System.Drawing.Point(428, 204);
            this.PlainTextInput.Multiline = true;
            this.PlainTextInput.Name = "PlainTextInput";
            this.PlainTextInput.Size = new System.Drawing.Size(429, 91);
            this.PlainTextInput.TabIndex = 0;
            // 
            // CipherText
            // 
            this.CipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CipherText.Location = new System.Drawing.Point(428, 334);
            this.CipherText.Multiline = true;
            this.CipherText.Name = "CipherText";
            this.CipherText.Size = new System.Drawing.Size(429, 91);
            this.CipherText.TabIndex = 1;
            // 
            // PlainTextOutput
            // 
            this.PlainTextOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainTextOutput.Location = new System.Drawing.Point(428, 467);
            this.PlainTextOutput.Multiline = true;
            this.PlainTextOutput.Name = "PlainTextOutput";
            this.PlainTextOutput.Size = new System.Drawing.Size(705, 91);
            this.PlainTextOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Plain Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ciphertext";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Plain Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(944, 153);
            this.label4.TabIndex = 6;
            this.label4.Text = "RSA Algorithm";
            // 
            // EncButton
            // 
            this.EncButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncButton.Location = new System.Drawing.Point(915, 208);
            this.EncButton.Name = "EncButton";
            this.EncButton.Size = new System.Drawing.Size(218, 74);
            this.EncButton.TabIndex = 7;
            this.EncButton.Text = "Encrypt";
            this.EncButton.UseVisualStyleBackColor = true;
            this.EncButton.Click += new System.EventHandler(this.EncButton_Click);
            // 
            // DecButton
            // 
            this.DecButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DecButton.Location = new System.Drawing.Point(915, 341);
            this.DecButton.Name = "DecButton";
            this.DecButton.Size = new System.Drawing.Size(218, 74);
            this.DecButton.TabIndex = 8;
            this.DecButton.Text = "Decrypt";
            this.DecButton.UseVisualStyleBackColor = true;
            this.DecButton.Click += new System.EventHandler(this.DecButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 645);
            this.Controls.Add(this.DecButton);
            this.Controls.Add(this.EncButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlainTextOutput);
            this.Controls.Add(this.CipherText);
            this.Controls.Add(this.PlainTextInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "RSA Encryption-Decryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PlainTextInput;
        private System.Windows.Forms.TextBox CipherText;
        private System.Windows.Forms.TextBox PlainTextOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EncButton;
        private System.Windows.Forms.Button DecButton;
    }
}


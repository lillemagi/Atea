namespace AteaMessage
{
    partial class AteaConsole
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.AteaWebbLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AteaMessage.Properties.Resources.atea_rgb;
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(12, 161);
            this.messageBox.MaxLength = 160;
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(418, 105);
            this.messageBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Skriv ditt meddelande (max 160 tecken)";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(343, 272);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(87, 38);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Sänd";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // AteaWebbLinkLabel
            // 
            this.AteaWebbLinkLabel.AutoSize = true;
            this.AteaWebbLinkLabel.Location = new System.Drawing.Point(137, 348);
            this.AteaWebbLinkLabel.Name = "AteaWebbLinkLabel";
            this.AteaWebbLinkLabel.Size = new System.Drawing.Size(124, 20);
            this.AteaWebbLinkLabel.TabIndex = 4;
            this.AteaWebbLinkLabel.TabStop = true;
            this.AteaWebbLinkLabel.Text = "Gå till webbsida!";
            this.AteaWebbLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AteaWebbLinkLabel_LinkClicked);
            // 
            // AteaConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(443, 448);
            this.Controls.Add(this.AteaWebbLinkLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AteaConsole";
            this.Text = "Atea Meddelande App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.LinkLabel AteaWebbLinkLabel;
    }
}


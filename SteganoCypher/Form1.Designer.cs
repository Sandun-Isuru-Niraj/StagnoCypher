namespace SteganoCypher
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_message = new System.Windows.Forms.RichTextBox();
            this.dect_message = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_decryptPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.lbl4 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.image = new System.Windows.Forms.PictureBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Controls.Add(this.btn_encrypt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_message);
            this.groupBox1.Location = new System.Drawing.Point(12, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 213);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt";
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(179, 165);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(104, 23);
            this.btn_open.TabIndex = 5;
            this.btn_open.Text = "Open File";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(34, 165);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(104, 23);
            this.btn_encrypt.TabIndex = 4;
            this.btn_encrypt.Text = "Encrypt";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password: (For Best Security)";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(161, 125);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(154, 20);
            this.txt_password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Message Neet to be Encrypt";
            // 
            // txt_message
            // 
            this.txt_message.Location = new System.Drawing.Point(15, 39);
            this.txt_message.Name = "txt_message";
            this.txt_message.Size = new System.Drawing.Size(300, 80);
            this.txt_message.TabIndex = 0;
            this.txt_message.Text = "";
            // 
            // dect_message
            // 
            this.dect_message.Location = new System.Drawing.Point(11, 117);
            this.dect_message.Name = "dect_message";
            this.dect_message.Size = new System.Drawing.Size(313, 80);
            this.dect_message.TabIndex = 6;
            this.dect_message.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_decryptPassword);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn_decrypt);
            this.groupBox2.Controls.Add(this.dect_message);
            this.groupBox2.Controls.Add(this.lbl4);
            this.groupBox2.Location = new System.Drawing.Point(351, 281);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 213);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decrypt";
            // 
            // txt_decryptPassword
            // 
            this.txt_decryptPassword.Location = new System.Drawing.Point(14, 45);
            this.txt_decryptPassword.Name = "txt_decryptPassword";
            this.txt_decryptPassword.Size = new System.Drawing.Size(300, 20);
            this.txt_decryptPassword.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save as Text File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(41, 71);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(92, 23);
            this.btn_decrypt.TabIndex = 8;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(11, 21);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(158, 13);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Password for Decryption (If Any)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(694, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // image
            // 
            this.image.Image = global::SteganoCypher.Properties.Resources.Untitled_1;
            this.image.Location = new System.Drawing.Point(86, 26);
            this.image.MaximumSize = new System.Drawing.Size(529, 245);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(529, 245);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 501);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.image);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(710, 540);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StagnoCypher v1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_message;
        private System.Windows.Forms.RichTextBox dect_message;
        private System.Windows.Forms.TextBox txt_decryptPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}


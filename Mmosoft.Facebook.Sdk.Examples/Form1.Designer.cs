namespace Mmosoft.Facebook.Sdk.Examples
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
            this.components = new System.ComponentModel.Container();
            this.btnPostMyWall = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPostGroup = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDgroup = new System.Windows.Forms.TextBox();
            this.ListImage = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPostMyWall
            // 
            this.btnPostMyWall.Location = new System.Drawing.Point(526, 270);
            this.btnPostMyWall.Name = "btnPostMyWall";
            this.btnPostMyWall.Size = new System.Drawing.Size(102, 23);
            this.btnPostMyWall.TabIndex = 0;
            this.btnPostMyWall.Text = "Đăng lên tường";
            this.btnPostMyWall.UseVisualStyleBackColor = true;
            this.btnPostMyWall.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 87);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập tài khoản Facebok của bạn";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Mmosoft.Facebook.Sdk.Examples.Properties.Resources.facebook;
            this.pictureBox2.Location = new System.Drawing.Point(6, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(200, 51);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(289, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(200, 22);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(289, 20);
            this.txtUsername.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // btnPostGroup
            // 
            this.btnPostGroup.Location = new System.Drawing.Point(404, 271);
            this.btnPostGroup.Name = "btnPostGroup";
            this.btnPostGroup.Size = new System.Drawing.Size(102, 23);
            this.btnPostGroup.TabIndex = 3;
            this.btnPostGroup.Text = "Đăng lên group";
            this.btnPostGroup.UseVisualStyleBackColor = true;
            this.btnPostGroup.Click += new System.EventHandler(this.btnPostGroup_Click);
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(12, 118);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(616, 134);
            this.txtContent.TabIndex = 4;
            this.txtContent.Text = "";
            this.txtContent.TextChanged += new System.EventHandler(this.txtContent_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nhập ID group:";
            // 
            // txtIDgroup
            // 
            this.txtIDgroup.Location = new System.Drawing.Point(101, 273);
            this.txtIDgroup.Name = "txtIDgroup";
            this.txtIDgroup.Size = new System.Drawing.Size(289, 20);
            this.txtIDgroup.TabIndex = 10;
            // 
            // ListImage
            // 
            this.ListImage.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ListImage.ImageSize = new System.Drawing.Size(16, 16);
            this.ListImage.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mmosoft.Facebook.Sdk.Examples.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(530, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(404, 318);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 11;
            this.btnInput.Text = "Input file";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(717, 21);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(227, 231);
            this.pb2.TabIndex = 12;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb1_Click);
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(717, 273);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(227, 20);
            this.tb2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 494);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtIDgroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.btnPostGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPostMyWall);
            this.Name = "Form1";
            this.Text = "Tự động đăng tin lên tường Facebook | Group Facebook - http://laptrinhvb.net";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPostMyWall;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnPostGroup;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDgroup;
        private System.Windows.Forms.ImageList ListImage;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.TextBox tb2;
    }
}
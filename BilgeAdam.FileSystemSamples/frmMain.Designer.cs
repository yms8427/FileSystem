namespace BilgeAdam.FileSystemSamples
{
    partial class frmMain
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
            this.btnCreateDir = new System.Windows.Forms.Button();
            this.btnRemoveDir = new System.Windows.Forms.Button();
            this.btnGetDir = new System.Windows.Forms.Button();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.btnSelectDir = new System.Windows.Forms.Button();
            this.btnFileCreate = new System.Windows.Forms.Button();
            this.btnFileRemove = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFileRead = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.pibPhoto = new System.Windows.Forms.PictureBox();
            this.pgr = new System.Windows.Forms.PropertyGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateDir
            // 
            this.btnCreateDir.Location = new System.Drawing.Point(12, 51);
            this.btnCreateDir.Name = "btnCreateDir";
            this.btnCreateDir.Size = new System.Drawing.Size(136, 23);
            this.btnCreateDir.TabIndex = 0;
            this.btnCreateDir.Text = "Klasör Oluştur";
            this.btnCreateDir.UseVisualStyleBackColor = true;
            this.btnCreateDir.Click += new System.EventHandler(this.btnCreateDir_Click);
            // 
            // btnRemoveDir
            // 
            this.btnRemoveDir.Location = new System.Drawing.Point(12, 80);
            this.btnRemoveDir.Name = "btnRemoveDir";
            this.btnRemoveDir.Size = new System.Drawing.Size(136, 23);
            this.btnRemoveDir.TabIndex = 0;
            this.btnRemoveDir.Text = "Klasör Sil";
            this.btnRemoveDir.UseVisualStyleBackColor = true;
            this.btnRemoveDir.Click += new System.EventHandler(this.btnRemoveDir_Click);
            // 
            // btnGetDir
            // 
            this.btnGetDir.Location = new System.Drawing.Point(12, 109);
            this.btnGetDir.Name = "btnGetDir";
            this.btnGetDir.Size = new System.Drawing.Size(136, 23);
            this.btnGetDir.TabIndex = 0;
            this.btnGetDir.Text = "Klasör Bilgileri";
            this.btnGetDir.UseVisualStyleBackColor = true;
            this.btnGetDir.Click += new System.EventHandler(this.btnGetDir_Click);
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(155, 12);
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.Size = new System.Drawing.Size(218, 20);
            this.txtParameter.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 143);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klasör Bilgileri";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(92, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(129, 20);
            this.textBox4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dosya Sayısı";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(92, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(129, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Klasör Sayısı";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(92, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(129, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Değişiklik Tarihi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // btnSelectDir
            // 
            this.btnSelectDir.Location = new System.Drawing.Point(379, 10);
            this.btnSelectDir.Name = "btnSelectDir";
            this.btnSelectDir.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDir.TabIndex = 3;
            this.btnSelectDir.Text = "Seç";
            this.btnSelectDir.UseVisualStyleBackColor = true;
            this.btnSelectDir.Click += new System.EventHandler(this.btnSelectDir_Click);
            // 
            // btnFileCreate
            // 
            this.btnFileCreate.Location = new System.Drawing.Point(311, 51);
            this.btnFileCreate.Name = "btnFileCreate";
            this.btnFileCreate.Size = new System.Drawing.Size(110, 23);
            this.btnFileCreate.TabIndex = 4;
            this.btnFileCreate.Text = "Dosya Oluştur";
            this.btnFileCreate.UseVisualStyleBackColor = true;
            this.btnFileCreate.Click += new System.EventHandler(this.btnFileCreate_Click);
            // 
            // btnFileRemove
            // 
            this.btnFileRemove.Location = new System.Drawing.Point(311, 80);
            this.btnFileRemove.Name = "btnFileRemove";
            this.btnFileRemove.Size = new System.Drawing.Size(110, 23);
            this.btnFileRemove.TabIndex = 4;
            this.btnFileRemove.Text = "Dosya Sil";
            this.btnFileRemove.UseVisualStyleBackColor = true;
            this.btnFileRemove.Click += new System.EventHandler(this.btnFileRemove_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(311, 109);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Dosya Özellikleri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFileRead
            // 
            this.btnFileRead.Location = new System.Drawing.Point(427, 51);
            this.btnFileRead.Name = "btnFileRead";
            this.btnFileRead.Size = new System.Drawing.Size(110, 23);
            this.btnFileRead.TabIndex = 4;
            this.btnFileRead.Text = "Dosya Oku";
            this.btnFileRead.UseVisualStyleBackColor = true;
            this.btnFileRead.Click += new System.EventHandler(this.btnFileRead_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(427, 80);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(110, 23);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "Dosya Oku (Dialog)";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(427, 109);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(110, 23);
            this.btnLoadImage.TabIndex = 4;
            this.btnLoadImage.Text = "Fotoğraf Yükle";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(379, 161);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(158, 20);
            this.txtFileName.TabIndex = 5;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(379, 187);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(158, 88);
            this.txtContent.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Adı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(343, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "İçerik";
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // pibPhoto
            // 
            this.pibPhoto.Location = new System.Drawing.Point(12, 301);
            this.pibPhoto.Name = "pibPhoto";
            this.pibPhoto.Size = new System.Drawing.Size(226, 146);
            this.pibPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibPhoto.TabIndex = 6;
            this.pibPhoto.TabStop = false;
            // 
            // pgr
            // 
            this.pgr.Location = new System.Drawing.Point(311, 281);
            this.pgr.Name = "pgr";
            this.pgr.Size = new System.Drawing.Size(226, 254);
            this.pgr.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 547);
            this.Controls.Add(this.pgr);
            this.Controls.Add(this.pibPhoto);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.btnFileRemove);
            this.Controls.Add(this.btnFileRead);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFileCreate);
            this.Controls.Add(this.btnSelectDir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtParameter);
            this.Controls.Add(this.btnGetDir);
            this.Controls.Add(this.btnRemoveDir);
            this.Controls.Add(this.btnCreateDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Dosya Yönetimi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateDir;
        private System.Windows.Forms.Button btnRemoveDir;
        private System.Windows.Forms.Button btnGetDir;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button btnSelectDir;
        private System.Windows.Forms.Button btnFileCreate;
        private System.Windows.Forms.Button btnFileRemove;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFileRead;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.PictureBox pibPhoto;
        private System.Windows.Forms.PropertyGrid pgr;
    }
}


using BilgeAdam.FileSystemSamples.Helpers;
using System;
using System.IO;
using System.Windows.Forms;

namespace BilgeAdam.FileSystemSamples
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCreateDir_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(txtParameter.Text);
        }

        private void btnRemoveDir_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(txtParameter.Text))
            {
                MessageBox.Show("Klasör bulunamadı");
                return;
            }
            if (DirectoryHelper.IsEmpty(txtParameter.Text))
            {
                Directory.Delete(txtParameter.Text);
            }
            else
            {
                var result = MessageBox.Show("Klasör boş değil\nYine de silmek istiyor musunuz?", "Dosya Sistemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Directory.Delete(txtParameter.Text, true);
                }
            }
        }

        private void btnGetDir_Click(object sender, EventArgs e)
        {
            var info = new DirectoryInfo(txtParameter.Text);
            textBox1.Text = info.Name;
            textBox2.Text = info.LastWriteTime.ToString();
            textBox3.Text = Directory.GetDirectories(txtParameter.Text).Length.ToString();
            textBox4.Text = Directory.GetFiles(txtParameter.Text).Length.ToString();
        }

        private void btnSelectDir_Click(object sender, EventArgs e)
        {
            fbd.ShowNewFolderButton = false;
            fbd.Description = "Klasör seçeceksin işte";
            var result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtParameter.Text = fbd.SelectedPath;
            }
        }

        private void btnFileCreate_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Path.Combine(txtParameter.Text, txtFileName.Text), txtContent.Text);
        }

        private void btnFileRead_Click(object sender, EventArgs e)
        {
            txtContent.Text = File.ReadAllText(Path.Combine(txtParameter.Text, txtFileName.Text));
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            ofd.FileName = string.Empty;
            ofd.Filter = "Metin Dosyaları|*.txt|Class Dosyaları|*.cs|Tüm Dosyalar|*.*";
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtContent.Text = File.ReadAllText(ofd.FileName);
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            ofd.FileName = string.Empty;
            ofd.Filter = "Resim Dosyaları|*.png;*.jpg;*.jpeg";
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK)
            {
                pibPhoto.ImageLocation = ofd.FileName;
            }
        }
    }
}

using BilgeAdam.FileSystem.Editor.Helpers;
using BilgeAdam.FileSystem.Editor.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.FileSystem.Editor
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        internal Settings ToolBarSettings { get; set; }
        public string FileName { get; set; }
        private void frmMain_Load(object sender, EventArgs e)
        {
            ToolBarSettings = ToolBarHelper.GetSettings();
            tsAccess.Visible = ToolBarSettings.AccessBarVisible;
            tsbView_Access.Checked = ToolBarSettings.AccessBarVisible;

            tsClipboard.Visible = ToolBarSettings.ClipboardBarVisible;
            tsbView_Clipboard.Checked = ToolBarSettings.ClipboardBarVisible;

            tsColor.Visible = ToolBarSettings.ColorBarVisible;
            tsbView_Color.Checked = ToolBarSettings.ColorBarVisible;
        }

        private void tsbView_Access_Click(object sender, EventArgs e)
        {
            tsAccess.Visible = !tsAccess.Visible;
            tsbView_Access.Checked = tsAccess.Visible;
            ToolBarSettings.AccessBarVisible = tsAccess.Visible;
            ToolBarHelper.SetSettings(ToolBarSettings);
        }

        private void tsbView_Clipboard_Click(object sender, EventArgs e)
        {
            tsClipboard.Visible = !tsClipboard.Visible;
            tsbView_Clipboard.Checked = tsClipboard.Visible;
            ToolBarSettings.ClipboardBarVisible = tsClipboard.Visible;
            ToolBarHelper.SetSettings(ToolBarSettings);
        }

        private void tsbView_Color_Click(object sender, EventArgs e)
        {
            tsColor.Visible = !tsColor.Visible;
            tsbView_Color.Checked = tsColor.Visible;
            ToolBarSettings.ColorBarVisible = tsColor.Visible;
            ToolBarHelper.SetSettings(ToolBarSettings);
        }

        private void tsbEdit_Font_Click(object sender, EventArgs e)
        {
            using (var fd = new FontDialog())
            {
                fd.ShowColor = true;
                var result = fd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    rtbSection.Font = fd.Font;
                    rtbSection.ForeColor = fd.Color;
                }
            }
        }

        private void tsbFile_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsbFile_Save_Click(object sender, EventArgs e)
        {
            //rtbSection.SaveFile(FileName + 2, RichTextBoxStreamType.RichText);
            using (var fs = new FileStream(FileName, FileMode.Truncate))
            {
                using (var writer = new StreamWriter(fs, Encoding.UTF8))
                {
                    writer.WriteLine(rtbSection.Text);
                }
            }
        }

        private void tsbFile_Open_Click(object sender, EventArgs e)
        {
            
            var fd = new OpenFileDialog
            {
                Filter = "Can Dosyaları|*.can",
                FileName = "",
                Multiselect = false,
                Title = "Bir dosya seç"
            };
            var result = fd.ShowDialog();
            if (result == DialogResult.OK)
            {
                FileName = fd.FileName;
                //rtbSection.LoadFile(FileName, RichTextBoxStreamType.RichText);
                using (var reader = new StreamReader(fd.FileName, Encoding.UTF8))
                {
                    rtbSection.Text = reader.ReadToEnd();
                }
            }
        }

        private void SetColor(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem mi)
            {
                SetSelectedTextColor(mi.Tag.ToString());
            }
            else if (sender is ToolStripButton tb)
            {
                SetSelectedTextColor(tb.Text);
            }
        }

        private void SetSelectedTextColor(string colorName)
        {
            var color = Color.FromName(colorName);

            if (!string.IsNullOrWhiteSpace(rtbSection.SelectedText))
            {
                rtbSection.SelectionColor = color;
            }
        }

        private void tsbEdit_Bold_Click(object sender, EventArgs e)
        {
            //TODO: newStyle = style & ~FontStyle.Bold
            if (!string.IsNullOrWhiteSpace(rtbSection.SelectedText))
            {
                var style = rtbSection.SelectionFont.Style | FontStyle.Bold;
                rtbSection.SelectionFont = new Font(rtbSection.SelectionFont.FontFamily, rtbSection.SelectionFont.Size, style);
            }
        }

        private void tsbEdit_Italic_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbSection.SelectedText))
            {
                var style = rtbSection.SelectionFont.Style | FontStyle.Italic;
                rtbSection.SelectionFont = new Font(rtbSection.SelectionFont.FontFamily, rtbSection.SelectionFont.Size, style);
            }
        }

        private void tsbEdit_Stroke_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbSection.SelectedText))
            {
                var style = rtbSection.SelectionFont.Style | FontStyle.Strikeout;
                rtbSection.SelectionFont = new Font(rtbSection.SelectionFont.FontFamily, rtbSection.SelectionFont.Size, style);
            }
        }

        private void tsbCut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbSection.SelectedText))
            {
                Clipboard.SetText(rtbSection.SelectedText);
                rtbSection.SelectedText = string.Empty;
            }
        }

        private void tsbCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(rtbSection.SelectedText))
            {
                Clipboard.SetText(rtbSection.SelectedText);
            }
        }

        private void tsbPaste_Click(object sender, EventArgs e)
        {
            if(Clipboard.ContainsText())
            {
                rtbSection.SelectedText = Clipboard.GetText();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Mdash64
{
    public partial class Form1 : Form
    {
        byte[] rawhash;

        public Form1()
        {
            InitializeComponent();
            this.cmbOutput.SelectedIndex = 0;
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            DialogResult dialRes = this.fdPick.ShowDialog();
            if (dialRes == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    using (var md5 = MD5.Create())
                    {
                        using (var stream = this.fdPick.OpenFile())
                        {
                            this.rawhash = md5.ComputeHash(stream);
                        }
                    }
                    this.cmbOutput_SelectedIndexChanged(this, new EventArgs());
                }
                catch (Exception ex)
                {
                    this.textBox1.Text = string.Format("Exception occured:\r\n{0}", ex);
                }
            }
        }

        private void setHashString(string hash)
        {
            this.textBox1.Text = string.Format("Hash as {0} (copied to clipboard):\r\n\r\n{1}", this.cmbOutput.SelectedText, hash);
            Clipboard.SetText(hash);
        }

        private string getBase64Hash()
        {
            if (this.rawhash != null && this.rawhash.Length > 0)
            {
                return Convert.ToBase64String(this.rawhash);
            }
            return string.Empty;
        }

        private string getHexHash()
        {
            if (this.rawhash != null && this.rawhash.Length > 0)
            {
                return BitConverter.ToString(this.rawhash).Replace("-", string.Empty);
            }
            return string.Empty;
        }

        private string getRawHash(System.Text.Encoding enc)
        {
            if (this.rawhash != null && this.rawhash.Length > 0)
            {
                return enc.GetString(this.rawhash);
            }
            return string.Empty;
        }

        private void cmbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hash = string.Empty;
            switch (this.cmbOutput.SelectedItem as string)
            {
                case "Hex (lc)":
                    hash = this.getHexHash().ToLower();
                    break;
                case "Hex (uc)":
                    hash = this.getHexHash().ToUpper();
                    break;
                case "Base64":
                    hash = this.getBase64Hash();
                    break;
                case "UTF-8 (raw)":
                    hash = this.getRawHash(System.Text.Encoding.UTF8);
                    break;
            }
            if (!string.IsNullOrEmpty(hash))
            {
                this.setHashString(hash);
            }
        }
    }
}

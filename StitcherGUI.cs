using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdfStitcher
{
    public partial class StitcherGUI : Form
    {
        private StitcherBuilder stitcherBuilder;
        private bool loaded;

        internal StitcherGUI(StitcherBuilder stitcherBuilder)
        {
            InitializeComponent();

            this.stitcherBuilder = stitcherBuilder;
            loaded = false;
        }

        private void StitcherGUI_Load(object sender, EventArgs e)
        {
            txtOrigin.Text = @stitcherBuilder.Origin;
            txtDestination.Text = @stitcherBuilder.Destination;
            if (stitcherBuilder.Destination != stitcherBuilder.Origin)
                chkSameDestination.Checked = false;
            chkSubfolders.Checked = stitcherBuilder.Recursive;
            if (stitcherBuilder.Pattern != null)
            {
                rdoRegex.Checked = true;
                txtRegex.Text = stitcherBuilder.Pattern;
            }                
            else if (stitcherBuilder.Files != null)
            {
                rdoListFiles.Checked = true;
                txtFiles.Text = string.Join(" ", stitcherBuilder.Files.Select(s => "\"" + s + "\""));
            }

            if (stitcherBuilder.Rotation % 90 != 0)
                cboRotate.SelectedIndex = 0;
            else
            {
                switch (stitcherBuilder.Rotation)
                {
                    case 90:
                        cboRotate.SelectedIndex = 1;
                        break;
                    case 180:
                        cboRotate.SelectedIndex = 0;
                        break;
                    case 270:
                        cboRotate.SelectedIndex = 3;
                        break;
                    default:
                        cboRotate.SelectedIndex = 0;
                        break;
                }
            }

            txtOutputName.Text = stitcherBuilder.Name;
            chkShow.Checked = stitcherBuilder.Show;

            loaded = true;
        }

        #region Control Handlers
        private void ChkSameDestination_CheckedChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                txtDestination.Enabled = !chkSameDestination.Checked;
                txtDestination.ReadOnly = chkSameDestination.Checked;
                btnBrowseDestination.Enabled = !chkSameDestination.Checked;
            }
        }

        private void RdoListFiles_CheckedChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                txtFiles.ReadOnly = !rdoListFiles.Checked;
                btnBrowsePdfFiles.Enabled = rdoListFiles.Checked;
            }
        }

        private void RdoRegex_CheckedChanged(object sender, EventArgs e)
        {
            if (loaded)
                txtRegex.ReadOnly = !rdoRegex.Checked;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            stitcherBuilder.Canceled = true;
            this.Close();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (OutputNameIsValid())
            {
                stitcherBuilder.Origin = txtOrigin.Text;
                stitcherBuilder.Destination = txtDestination.Text;
                stitcherBuilder.Name = txtOutputName.Text;
                stitcherBuilder.Recursive = chkSubfolders.Checked;
                stitcherBuilder.Show = chkShow.Checked;
                stitcherBuilder.Rotation = cboRotate.SelectedIndex * 90;
                if (rdoAllFiles.Checked)
                {
                    stitcherBuilder.Files = null;
                    stitcherBuilder.Pattern = null;
                }
                else if (rdoListFiles.Checked)
                {
                    stitcherBuilder.Files = txtFiles.Text.Split(' ');
                    stitcherBuilder.Pattern = null;
                }
                else
                {
                    stitcherBuilder.Files = null;
                    stitcherBuilder.Pattern = txtRegex.Text;
                }

                stitcherBuilder.Canceled = false;
                this.Close();
            }
        }

        private void BtnBrowseOrigin_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    txtOrigin.Text = fbd.SelectedPath;                
            }
        }

        private void BtnBrowseDestination_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    txtDestination.Text = fbd.SelectedPath;
            }
        }

        private void BtnBrowsePdfFiles_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = txtOrigin.Text;
                ofd.DefaultExt = "*.pdf";
                ofd.Multiselect = true;

                DialogResult result = ofd.ShowDialog();

                if (result == DialogResult.OK && ofd.FileNames != null)
                    txtFiles.Text = string.Join(" ", ofd.FileNames.Select(s => "\"" + s + "\""));
            }
        }

        private void TxtOrigin_TextChanged(object sender, EventArgs e)
        {
            if (loaded)
            {
                if (chkSameDestination.Checked)
                    txtDestination.Text = txtOrigin.Text;
            }
        }
        #endregion

        #region Functions
        private bool OutputNameIsValid()
        {
            if (System.IO.File.Exists(txtDestination.Text + "\\" + txtOutputName.Text + ".pdf"))
            {
                errorProvider1.SetError(txtOutputName, "File Name is not valid!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtOutputName, "");
                return true;
            }
        }
        #endregion
    }
}

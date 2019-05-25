using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchResizer
{
    public partial class BatchResizeForm : Form
    {
        private enum ResizeType
        {
            ShrinkToMax = 0, GrowToMin, ResizeExact, ByPercent
        }

        private IProgress<string> FileResizingProgress;
        private IProgress<string> FileResizedProgress;
        private IProgress<string> ErrorProgress;

        private bool errorsOccurred;
        private bool isCancelled;
        private DateTime lastStatusUpdate;

        public BatchResizeForm()
        {
            InitializeComponent();
            FileResizingProgress = new Progress<string>(ReportFileResizing);
            ErrorProgress = new Progress<string>(ReportError);
            resizeTypeCb.SelectedIndex = 0;
            currentFileLbl.Text = string.Empty;
            heightLbl.Text = "Max Height";
            heightLbl.Text = "Max Width";
        }

        private void chooseFolderBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.ShowNewFolderButton = false;
                fbd.Description = "Choose root folder";
                if (fbd.ShowDialog() == DialogResult.OK)
                    selectedFolderTxt.Text = fbd.SelectedPath;
            }
        }

        private void resizeBtn_Click(object sender, EventArgs e)
        {
            string root = selectedFolderTxt.Text;
            int height = (int)heightNud.Value;
            int width = (int)widthNud.Value;

            if (!Directory.Exists(root))
            {
                MessageBox.Show("Invalid folder path.");
                return;
            }

            if (replaceOriginalsCb.Checked && MessageBox.Show(
                    "Are you completely, totally sure you trust me not to delete your original files?\n" +
                    "Should I overwrite your original files with the resized versions?",
                    "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            ResizeAllImages(root, (ResizeType)resizeTypeCb.SelectedIndex, height, width, replaceOriginalsCb.Checked);
        }

        private async void ResizeAllImages(string root, ResizeType resizeType, int height, int width, bool replaceOriginal)
        {
            isCancelled = false;
            foreach (Control control in Controls)
                if (!(control is Label))
                    control.Enabled = false;
            cancelBtn.Enabled = true;

            await Task.Run(() => ResizeImagesInFolder(root, resizeType, height, width, replaceOriginal));

            if (isCancelled)
                MessageBox.Show("Batch resizing was cancelled.");
            else
                MessageBox.Show("Done!");

            if(errorsOccurred)
                MessageBox.Show("Errors occurred while attempting to resize files. You can view the error log in .\\errorlog.txt");

            errorsOccurred = false;
            isCancelled = false;
            foreach (Control control in Controls)
                if (!(control is Label))
                    control.Enabled = true;
            selectedFolderTxt.Text = string.Empty;
            cancelBtn.Enabled = false;
            currentFileLbl.Text = string.Empty;
        }

        private void ResizeImagesInFolder(string folderPath, ResizeType resizeType, int width, int height, bool replaceOriginal)
        {
            string[] fileTypes = { ".jpg", ".jpeg", ".png", ".bmp" }; //Add support for gifs??
            foreach (string file in Directory.GetFiles(folderPath))
            {
                if (isCancelled) return;
                bool isValid = false;
                foreach (string filetype in fileTypes)
                    if (file.EndsWith(filetype))
                    {
                        isValid = true;
                        break;
                    }
                if (isValid)
                    ResizeImage(file, resizeType, width, height, replaceOriginal);
            }

            foreach (string folder in Directory.GetDirectories(folderPath))
                ResizeImagesInFolder(folder, resizeType, width, height, replaceOriginal);
        }

        private void ResizeImage(string filepath, ResizeType resizeType, int width, int height, bool replaceOriginal)
        {
            if (isCancelled) return;

            try
            {
                FileResizingProgress.Report("Resizing " + filepath);
                Bitmap bmp = new Bitmap(filepath);
                float xScale, yScale;

                switch (resizeType)
                {
                    case ResizeType.ShrinkToMax:
                        if (bmp.PhysicalDimension.Width <= width && bmp.PhysicalDimension.Height <= height)
                            //Todo: Copy image to folder if necessary
                            return;
                        else
                            xScale = yScale = Math.Min(width / bmp.PhysicalDimension.Width,
                                height / bmp.PhysicalDimension.Height);
                        break;

                    case ResizeType.GrowToMin:
                        if (bmp.PhysicalDimension.Width >= width && bmp.PhysicalDimension.Height >= height)
                            //Todo: Copy image to folder if necessary
                            return;
                        else
                            xScale = yScale = Math.Max(width / bmp.PhysicalDimension.Width,
                                height / bmp.PhysicalDimension.Height);
                        break;

                    case ResizeType.ResizeExact:
                        if ((int)bmp.PhysicalDimension.Width == width && (int)bmp.PhysicalDimension.Height == height)
                            //Todo: Copy image to folder if necessary
                            return;
                        else
                        {
                            xScale = width / bmp.PhysicalDimension.Width;
                            yScale = height / bmp.PhysicalDimension.Height;
                        }

                        break;

                    case ResizeType.ByPercent:
                        xScale = (float)width / 100;
                        yScale = (float)height / 100;
                        break;

                    default:
                        MessageBox.Show("Programmer messed up. Invalid Resize Type.");
                        return;
                }

                if (isCancelled) return;

                using (Bitmap smallBmp = new Bitmap(bmp,
                    new Size((int)(bmp.PhysicalDimension.Width * xScale),
                        (int)(bmp.PhysicalDimension.Height * yScale))))
                {
                    bmp.Dispose();
                    ImageFormat imgFormat = ImageFormat.Jpeg;
                    if (filepath.EndsWith(".jpg") || filepath.EndsWith(".jpeg"))
                        imgFormat = ImageFormat.Jpeg;
                    else if (filepath.EndsWith(".bmp"))
                        imgFormat = ImageFormat.Bmp;
                    else if (filepath.EndsWith(".png"))
                        imgFormat = ImageFormat.Png;

                    if (isCancelled) return;

                    if (replaceOriginal)
                    {
                        File.Delete(filepath);
                        smallBmp.Save(filepath, ImageFormat.Jpeg);
                    }
                    else
                    {
                        string prePath = filepath.Substring(0, filepath.LastIndexOf('.'));
                        string extension = filepath.Substring(filepath.LastIndexOf('.'));
                        string newFilePath = prePath;
                        do
                        {
                            newFilePath = newFilePath + "_resized";
                        } while (File.Exists(newFilePath + extension));

                        smallBmp.Save(newFilePath + extension, imgFormat);
                    }
                }
            }
            catch (AccessViolationException ex)
            {
                ErrorProgress.Report($"Access Violation Error in {filepath}: {ex.Message}");
            }
            catch (Exception ex)
            {
                ErrorProgress.Report($"Error resizing {filepath}: {ex.Message}");
            }
        }

        private void replaceOriginalsCb_CheckedChanged(object sender, EventArgs e)
        {
            if (replaceOriginalsCb.Checked)
            {
                if (MessageBox.Show(
                        "Are you completely, totally sure you trust me not to delete your original files?\n" +
                        "Should I overwrite your original files with the resized versions?",
                        "Are you sure?", MessageBoxButtons.YesNo) == DialogResult.No)
                    replaceOriginalsCb.Checked = false;
            }
        }

        private void ReportFileResizing(string message)
        {
            if (DateTime.Now - lastStatusUpdate >= TimeSpan.FromSeconds(1))
            {
                currentFileLbl.Text = message;
                lastStatusUpdate = DateTime.Now;
            }
        }

        private void ReportError(string message)
        {
            errorsOccurred = true;
            File.AppendAllText(@".\errorlog.txt", message);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "Batch Resizer program version 1.0\n" +
                             "2018\n\n" +
                             "Written by Kyle Akerstrom\n" +
                             "kakerstrom@gmail.com\n\n" +
                             "Currently supports the following formats:\n" +
                             ".jpg, .png, .bmp\n\n" +
                             "I did my best to keep your files safe,\n" +
                             "but you still use this software at your own risk!\n\n";

            MessageBox.Show(message, "About Batch Resizer", MessageBoxButtons.OK, MessageBoxIcon.None);
        }

        private void resizeTypeCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((ResizeType)resizeTypeCb.SelectedIndex)
            {
                case ResizeType.ShrinkToMax:
                    widthLbl.Text = "Max Width";
                    heightLbl.Text = "Max Height";
                    break;
                case ResizeType.GrowToMin:
                    widthLbl.Text = "Min Width";
                    heightLbl.Text = "Min Height";
                    break;
                case ResizeType.ResizeExact:
                    widthLbl.Text = "Width";
                    heightLbl.Text = "Height";
                    break;
                case ResizeType.ByPercent:
                    widthLbl.Text = "% Width";
                    heightLbl.Text = "% Height";
                    break;
            }
        }

        private void Nud_Enter(object sender, EventArgs e)
        {
            ((NumericUpDown)sender).Select(0, ((NumericUpDown)sender).Text.Length);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            isCancelled = true;
        }
    }
}

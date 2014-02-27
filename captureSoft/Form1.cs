using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captureSoft
{
    public partial class ScreenCap : Form
    {
        public ScreenCap()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fileDiagBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                   (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.fileDiagBtn.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.fileDiagBtn.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 3:
                        this.fileDiagBtn.Image.Save(fs,
                           System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }

                fs.Close();
            }
        }

        private void screenShotBtn_Click(object sender, EventArgs e)
        {
            //Allow 250 milliseconds for the screen to repaint itself 
            //(we don't want to include this form in the capture)
            System.Threading.Thread.Sleep(250);

            Rectangle bounds = Screen.GetBounds(Screen.GetBounds(Point.Empty));
            string fi = "";

            if (ScreenPath != "")
            {
                fi = new FileInfo(ScreenPath).Extension;
            }

            ScreenShot.CaptureImage(showCursor, curSize, curPos,
                Point.Empty, Point.Empty, bounds, ScreenPath, fi);
        }
    }
}

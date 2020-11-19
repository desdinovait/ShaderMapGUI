using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ShaderMapGUI
{
    public partial class Form1 : Form
    {
        string currentDirectory = string.Empty;
        public Form1()
        {
            InitializeComponent();
            currentDirectory = Environment.CurrentDirectory.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonOpenDiffuse_Click(object sender, EventArgs e)
        {
            if (openFileDiffuse.ShowDialog() == DialogResult.OK)
            {
                labelDiffuse.Text = openFileDiffuse.FileName;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //Parametri
            string dispParameters = textDispSmooth.Text + "," + textDispLevel.Text + "," + textDispBlur.Text + ",*";
            string normParameters = textNormLevel.Text + "," + textNormIntensity.Text + ",*,*" ;
            string specParameters = textSpecLevel.Text + "," + textSpecBrightness.Text + "," + textSpecContrast.Text + ",*";

            //Crea la stringa
            const string quote = "\"";
            StringBuilder str = new StringBuilder();
            str.AppendLine("CD " + quote + labelWorkingExe.Text + quote);
            str.AppendLine("START /WAIT shadermap.exe cdiff " + quote + labelDiffuse.Text + quote + " -disp (" + dispParameters + ") -norm (" + normParameters + ") -spec (" + specParameters + ") -v");

            //Mostra la preview (se definita)
            if (checkPreview.Checked)
            {
                string dirOnly = Path.GetDirectoryName(labelDiffuse.Text);
                string filenameOnly = Path.GetFileNameWithoutExtension(labelDiffuse.Text);

                string diffFilename = quote + labelDiffuse.Text + quote;
                string dispFilename = quote + dirOnly + @"\" + filenameOnly + "_DISP.bmp" + quote;
                string normFilename = quote + dirOnly + @"\" + filenameOnly + "_NORM.tga" + quote;
                string specFilename = quote + dirOnly + @"\" + filenameOnly + "_SPEC.bmp" + quote;

                str.AppendLine("START /WAIT shadermap.exe 3dprv -diff (" + diffFilename + ") " + "-norm (" + normFilename + ") " + "-spec (" + specFilename + ") " + "-disp (" + dispFilename + ")" );

                if (checkCustom.Checked)
                {
                    if (File.Exists(labelCustom.Text))
                    {
                        str.Append(" -x (" + quote + labelCustom.Text + quote + ", 0)");
                    }
                }
                str.Append(" -v");
            }

            //Crea il file temporaneo
            string tempFile = currentDirectory + "\\temp.bat";
            StreamWriter file = File.CreateText(tempFile);
            file.Flush();
            file.Write(str.ToString());
            file.Close();

            Thread.Sleep(1000);

            //Avvia il processo
            Process.Start("explorer", tempFile);

        }

        private void trackDispSmooth_Scroll(object sender, EventArgs e)
        {
            textDispSmooth.Text = trackDispSmooth.Value.ToString();
        }

        private void trackDispLevel_Scroll(object sender, EventArgs e)
        {
            textDispLevel.Text = trackDispLevel.Value.ToString();
        }

        private void trackDispBlur_Scroll(object sender, EventArgs e)
        {
            textDispBlur.Text = trackDispBlur.Value.ToString();
        }


        private void buttonDispPreview_Click(object sender, EventArgs e)
        {
            string dirOnly = Path.GetDirectoryName(labelDiffuse.Text);
            string filenameOnly = Path.GetFileNameWithoutExtension(labelDiffuse.Text);
            string dispFilename = dirOnly + @"\" + filenameOnly + "_DISP.bmp";
            if (File.Exists(dispFilename))
            {
                Bitmap bitm = new Bitmap(dispFilename);
                picturePreview.Image = Image.FromHbitmap(bitm.GetHbitmap());
                bitm.Dispose();
                bitm = null;
            }
            picturePreview.Invalidate();
        }

        private void buttonDiffpreview_Click(object sender, EventArgs e)
        {
            if (File.Exists(labelDiffuse.Text))
            {
                picturePreview.Image = Image.FromFile(labelDiffuse.Text);
            }
        }

        private void trackNormLevel_Scroll(object sender, EventArgs e)
        {
            textNormLevel.Text = trackNormLevel.Value.ToString();
        }

        private void trackNormIntensity_Scroll(object sender, EventArgs e)
        {
            textNormIntensity.Text = trackNormIntensity.Value.ToString();
        }

        private void trackSpecLevel_Scroll(object sender, EventArgs e)
        {
            textSpecLevel.Text = trackSpecLevel.Value.ToString();
        }

        private void trackSpecBrightness_Scroll(object sender, EventArgs e)
        {
            textSpecBrightness.Text = trackSpecBrightness.Value.ToString();
        }

        private void trackSpecContrast_Scroll(object sender, EventArgs e)
        {
            textSpecContrast.Text = trackSpecContrast.Value.ToString();
        }

        private void buttonNormPreview_Click(object sender, EventArgs e)
        {
            string dirOnly = Path.GetDirectoryName(labelDiffuse.Text);
            string filenameOnly = Path.GetFileNameWithoutExtension(labelDiffuse.Text);
            string normFilename = dirOnly + @"\" + filenameOnly + "_NORM.tga";
            if (File.Exists(normFilename))
            {
                Bitmap bitm = new Bitmap(normFilename);
                picturePreview.Image = Image.FromHbitmap(bitm.GetHbitmap());
                bitm.Dispose();
                bitm = null;
            }
            picturePreview.Invalidate();
        }

        private void buttonSpecPreview_Click(object sender, EventArgs e)
        {
            string dirOnly = Path.GetDirectoryName(labelDiffuse.Text);
            string filenameOnly = Path.GetFileNameWithoutExtension(labelDiffuse.Text);
            string specFilename = dirOnly + @"\" + filenameOnly + "_SPEC.bmp";
            if (File.Exists(specFilename))
            {
                Bitmap bitm = new Bitmap(specFilename);
                picturePreview.Image = Image.FromHbitmap(bitm.GetHbitmap());
                bitm.Dispose();
                bitm = null;
            }
            picturePreview.Invalidate();
        }

        private void checkCustom_CheckedChanged(object sender, EventArgs e)
        {
            buttonCustom.Enabled = checkCustom.Checked;
        }

        private void buttonCustom_Click(object sender, EventArgs e)
        {
            if (openFileCustom.ShowDialog() == DialogResult.OK)
            {
                labelCustom.Text = openFileCustom.FileName;
            }
        }
    }
}
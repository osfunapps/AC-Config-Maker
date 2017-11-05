using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Config_Maker.project;

namespace AC_Config_Maker
{
    public partial class Form1 : Form
    {
        private string FILE_MADE = "File Made!";
        private string WINDOW_INFO = "Information";

        private const char HOT = 'H', COLD = 'C', WIND = 'W';

        public Form1()
        {
            InitializeComponent();
        }

        private void foldersRTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void outputFolderTB_TextChanged(object sender, EventArgs e)
        {
        }

        private void outputFolderBrowseBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = outputFolderDialog.ShowDialog();
            if (result == DialogResult.OK && outputFolderDialog.SelectedPath.Length > 0)
            {
                outputFolderTB.Text = outputFolderDialog.SelectedPath;
            }
        }


        private void GoBtn_Click(object sender, EventArgs e)
        {
            XmlFileWriter xmlFileWriter = new XmlFileWriter(outputFolderTB.Text, foldersRTB.Text, minDegreeDUD.Text, maxDegreeDUD.Text, GetModesList(), fanSpeedTB.Value, degreeTypeCB.Text, acDisplayCB.Checked);
            xmlFileWriter.WriteXml();
            MessageBox.Show(FILE_MADE, WINDOW_INFO);
        }

        private List<char> GetModesList()
        {
            List<char> modesList = new List<char>();

            if (coldCB.Checked)
                modesList.Add(COLD);

            if (hotCB.Checked)
                modesList.Add(HOT);

            if (windCB.Checked)
                modesList.Add(WIND);
            return modesList;
        }


        private void DragEnterHandler(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void IrCodesPathDropHandler(object sender, DragEventArgs e)
        {
            outputFolderTB.Text = TitleExporter(((string[])e.Data.GetData(DataFormats.FileDrop, false))[0], false);
        }

        private string TitleExporter(string fileLongStr, bool onlyFileName)
        {
            if (onlyFileName) return fileLongStr.ToString().Substring(fileLongStr.ToString().LastIndexOf("\\") + 1);
            return fileLongStr.ToString().Substring(fileLongStr.ToString().IndexOf("FileName: ") + 1);
        }

        private void outputFolderDialog_HelpRequest(object sender, EventArgs e)
        {
        }



        private void OutputFolderDropHandler(object sender, DragEventArgs e)
        {
            outputFolderTB.Text = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];
        }

        private void logBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(Logger.GetTxt(), Logger.TITLE);
        }



        private void Swing_Click(object sender, EventArgs e)
        {
                foldersRTB.AppendText(TextTemplateHandler.SWING_TXT);
        }

        private void FanSpeed_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.FAN_SPEED_TXT);
        }

        private void TempUpBtn_Click(object sender, EventArgs e)
        {
                foldersRTB.AppendText(TextTemplateHandler.TEMP_UP_TXT);
        }

        private void TempDownBtn_Click(object sender, EventArgs e)
        {
                foldersRTB.AppendText(TextTemplateHandler.TEMP_DOWN_TXT);
        }

        private void modesBtn_Click(object sender, EventArgs e)
        {
                foldersRTB.AppendText(TextTemplateHandler.MODE_TXT);
        }

        private void acDisplayCB_CheckedChanged(object sender, EventArgs e)
        {
            EnableGBs(acDisplayCB.Checked);
        }

        private void EnableGBs(bool @checked)
        {
            degreesGB.Enabled = @checked;
            fanSpeedGB.Enabled = @checked;
            modesGB.Enabled = @checked;
        }

        private void degreeTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PowerBtn_Click(object sender, EventArgs e)
        {
            if (!acDisplayCB.Checked) { 
                foldersRTB.AppendText(TextTemplateHandler.POWER_NO_DISPLAY_1_TXT);
                foldersRTB.AppendText(TextTemplateHandler.POWER_NO_DISPLAY_2_TXT);
            }
            else { 
                foldersRTB.AppendText(TextTemplateHandler.POWER_1_TXT);
                foldersRTB.AppendText(TextTemplateHandler.POWER_2_TXT);
            }
        }

    }
}

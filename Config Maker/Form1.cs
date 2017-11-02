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
            XmlFileWriter xmlFileWriter = new XmlFileWriter(outputFolderTB.Text, foldersRTB.Text, minDegreeDUD.Text, maxDegreeDUD.Text, GetModesList(), fanSpeedTB.Value, degreeTypeCB.Text);
            xmlFileWriter.WriteXml();
            MessageBox.Show(FILE_MADE);
        }

        private List<char> GetModesList()
        {
            List<char> modesList = new List<char>();

            if (hotCB.Checked)
                modesList.Add(HOT);
            if (coldCB.Checked)
                modesList.Add(COLD);
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



        private void Numbers_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.SWING_TXT);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.FAN_SPEED_TXT);
        }

        private void navigationBtn_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.TEMP_UP_TXT);

        }

        private void channelBtn_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.TEMP_DOWN_TXT);
        }

        private void colorsBrn_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.MODE_TXT);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void volumeBtn_Click(object sender, EventArgs e)
        {
            foldersRTB.AppendText(TextTemplateHandler.POWER_1_TXT);
            foldersRTB.AppendText(TextTemplateHandler.POWER_2_TXT);
        }

    }
}

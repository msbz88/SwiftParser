using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spire.Xls;

namespace SwiftParserForm {
    public partial class FormSwiftParser : Form {
        private string MasterDirPath { get; set; }
        private string TestDirPath { get; set; }
        private string ResultDirPath { get; set; }

        public FormSwiftParser() {
            InitializeComponent();
        }

        private void ButtonLoadFilesClick(object sender, EventArgs e) {
            ClearWindowLog();
            ClearMessages();
            textBoxResultPath.Text = "";
            string userInitialDirectory = @"I:\VT Execution\";
            if (!Directory.Exists(userInitialDirectory)) {
                userInitialDirectory = @"C:\";
            } 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = userInitialDirectory;
            openFileDialog.Title = "Master files directory";
            ShowInfoMessage("Waiting for Master directory...");
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                MasterDirPath = Path.GetDirectoryName(openFileDialog.FileName);
                AddInfoToWindowLog("Master files directory:", MasterDirPath);
                openFileDialog.InitialDirectory = MasterDirPath;
                ClearMessages();
            } else {
                ShowWarningMessage("Cancelled by user");
                return;
            }
            openFileDialog.Title = "Test files directory";
            ShowInfoMessage("Waiting for Test directory...");
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                TestDirPath = Path.GetDirectoryName(openFileDialog.FileName);
                AddInfoToWindowLog("Test files directory:", TestDirPath);
                if (ResultDirPath == "" || ResultDirPath==null) {
                    HandleResultsSave(TestDirPath);
                }
                ClearMessages();
            } else {
                ShowWarningMessage("Cancelled by user");
                ClearWindowLog();
            }
        }

        private void AddInfoToWindowLog(string title, string message) {
            richTextBoxLog.AppendText(title);
            int titleStartIndex = richTextBoxLog.Text.Length - title.Length;
            richTextBoxLog.Select(titleStartIndex, title.Length);
            richTextBoxLog.SelectionFont = new Font(richTextBoxLog.SelectionFont, FontStyle.Bold);
            richTextBoxLog.AppendText(Environment.NewLine);
            richTextBoxLog.AppendText(message);
            int messageStartIndex = richTextBoxLog.Text.Length - message.Length;
            richTextBoxLog.Select(messageStartIndex, message.Length);
            richTextBoxLog.SelectionColor = Color.Gray;
            richTextBoxLog.AppendText(Environment.NewLine);
            richTextBoxLog.ScrollToCaret();
        }

        private void ClearWindowLog() {
            richTextBoxLog.Text = "";
        }

        private void ShowWarningMessage(string warningMessage) {
            labelMessageToUser.ForeColor = Color.Red;
            labelMessageToUser.Text = warningMessage;
        }

        private void ShowInfoMessage(string infoMessage) {
            labelMessageToUser.ForeColor = Color.RoyalBlue;
            labelMessageToUser.Text = infoMessage;
        }

        private void ClearMessages() {
            labelMessageToUser.Text = "";
        }

        private void HandleResultsSave(string dirPath) {
            string today = DateTime.Now.ToShortDateString();
            today = today.Replace(".", "-");
            textBoxResultPath.Text = dirPath + @"\Swift_test_results_" + today + ".xls";
            ResultDirPath = dirPath;
            labelResultPath.ForeColor = Color.RoyalBlue;
            labelResultPath.Text = "Specify where to save result, otherwise it will be saved here:";
        }

        private void ButtonResultLocationClick(object sender, EventArgs e) {
            ClearMessages();
            string userInitialDirectory = @"I:\VT Execution\";
            if (!Directory.Exists(userInitialDirectory)) {
                userInitialDirectory = @"C:\";
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = userInitialDirectory;
            openFileDialog.Title = "Result file";
            ShowInfoMessage("Waiting for result file...");
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string extention = Path.GetExtension(openFileDialog.FileName);
                if (extention != ".xls" && extention != ".xlsx") {
                    ShowWarningMessage("The result file should be excel file");
                } else {
                    ResultDirPath = openFileDialog.FileName;
                    textBoxResultPath.Text = ResultDirPath;
                    ShowInfoMessage("Path for result file has been changed");
                    labelResultPath.Text = "";
                }
            } else { ClearMessages(); }
            
        }
    }
}

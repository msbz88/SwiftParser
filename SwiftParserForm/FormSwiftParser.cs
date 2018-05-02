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

namespace SwiftParserForm {
    public partial class FormSwiftParser : Form {
        private string MasterDirPath { get; set; }
        private string TestDirPath { get; set; }

        public FormSwiftParser() {
            InitializeComponent();
        }

        private void ButtonLoadFilesClick(object sender, EventArgs e) {
            ClearWindowLog();
            string userInitialDirectory = @"I:\VT Execution\";
            if (!Directory.Exists(userInitialDirectory)) {
                userInitialDirectory = @"C:\";
            } 

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = userInitialDirectory;
            openFileDialog.Title = "Master files directory";
            ShowInfoMessage("Waiting for Master directory...");
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                MasterDirPath = openFileDialog.FileName;
                AddInfoToWindowLog("Master files directory:", MasterDirPath);
                openFileDialog.InitialDirectory = MasterDirPath;
                ClearMessages();
            } else {
                ShowInfoMessage("Cancelled by user");
                return;
            }

            openFileDialog.Title = "Test files directory";
            ShowInfoMessage("Waiting for Test directory...");
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                TestDirPath = openFileDialog.FileName;
                AddInfoToWindowLog("Test files directory:", TestDirPath);
                ClearMessages();
            } else {
                ShowInfoMessage("Cancelled by user");
                richTextBoxLog.Text = "";
            }
        }

        private void AddInfoToWindowLog(string title, string message) {
            richTextBoxLog.AppendText(title);
            richTextBoxLog.Select(richTextBoxLog.Text.IndexOf(title), title.Length);
            richTextBoxLog.SelectionFont = new Font(richTextBoxLog.Font, FontStyle.Bold);
            richTextBoxLog.AppendText(Environment.NewLine);

            richTextBoxLog.AppendText(message);
            richTextBoxLog.Select(richTextBoxLog.Text.IndexOf(message), message.Length);
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


    }
}

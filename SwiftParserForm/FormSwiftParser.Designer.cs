namespace SwiftParserForm {
    partial class FormSwiftParser {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonLoadFiles = new System.Windows.Forms.Button();
            this.buttonShowResults = new System.Windows.Forms.Button();
            this.buttonExecute = new System.Windows.Forms.Button();
            this.textBoxResultPath = new System.Windows.Forms.TextBox();
            this.labelResultPath = new System.Windows.Forms.Label();
            this.labelMessageToUser = new System.Windows.Forms.Label();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.buttonResultLocation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLoadFiles
            // 
            this.buttonLoadFiles.Location = new System.Drawing.Point(7, 21);
            this.buttonLoadFiles.Name = "buttonLoadFiles";
            this.buttonLoadFiles.Size = new System.Drawing.Size(75, 25);
            this.buttonLoadFiles.TabIndex = 0;
            this.buttonLoadFiles.Text = "Load files";
            this.buttonLoadFiles.UseVisualStyleBackColor = true;
            this.buttonLoadFiles.Click += new System.EventHandler(this.ButtonLoadFilesClick);
            // 
            // buttonShowResults
            // 
            this.buttonShowResults.Location = new System.Drawing.Point(252, 21);
            this.buttonShowResults.Name = "buttonShowResults";
            this.buttonShowResults.Size = new System.Drawing.Size(75, 25);
            this.buttonShowResults.TabIndex = 3;
            this.buttonShowResults.Text = "Show results";
            this.buttonShowResults.UseVisualStyleBackColor = true;
            // 
            // buttonExecute
            // 
            this.buttonExecute.Location = new System.Drawing.Point(130, 21);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(75, 25);
            this.buttonExecute.TabIndex = 2;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseVisualStyleBackColor = true;
            // 
            // textBoxResultPath
            // 
            this.textBoxResultPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxResultPath.Location = new System.Drawing.Point(43, 67);
            this.textBoxResultPath.Name = "textBoxResultPath";
            this.textBoxResultPath.Size = new System.Drawing.Size(284, 20);
            this.textBoxResultPath.TabIndex = 4;
            this.textBoxResultPath.TabStop = false;
            // 
            // labelResultPath
            // 
            this.labelResultPath.AutoSize = true;
            this.labelResultPath.Location = new System.Drawing.Point(4, 49);
            this.labelResultPath.Name = "labelResultPath";
            this.labelResultPath.Size = new System.Drawing.Size(0, 13);
            this.labelResultPath.TabIndex = 5;
            // 
            // labelMessageToUser
            // 
            this.labelMessageToUser.AutoSize = true;
            this.labelMessageToUser.Location = new System.Drawing.Point(4, 288);
            this.labelMessageToUser.Name = "labelMessageToUser";
            this.labelMessageToUser.Size = new System.Drawing.Size(0, 13);
            this.labelMessageToUser.TabIndex = 6;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxLog.Location = new System.Drawing.Point(7, 95);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(320, 190);
            this.richTextBoxLog.TabIndex = 5;
            this.richTextBoxLog.TabStop = false;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.WordWrap = false;
            // 
            // buttonResultLocation
            // 
            this.buttonResultLocation.Location = new System.Drawing.Point(7, 67);
            this.buttonResultLocation.Name = "buttonResultLocation";
            this.buttonResultLocation.Size = new System.Drawing.Size(30, 20);
            this.buttonResultLocation.TabIndex = 1;
            this.buttonResultLocation.Text = "/";
            this.buttonResultLocation.UseVisualStyleBackColor = true;
            this.buttonResultLocation.Click += new System.EventHandler(this.ButtonResultLocationClick);
            // 
            // FormSwiftParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 306);
            this.Controls.Add(this.buttonResultLocation);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.labelMessageToUser);
            this.Controls.Add(this.labelResultPath);
            this.Controls.Add(this.textBoxResultPath);
            this.Controls.Add(this.buttonExecute);
            this.Controls.Add(this.buttonShowResults);
            this.Controls.Add(this.buttonLoadFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSwiftParser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swift Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLoadFiles;
        private System.Windows.Forms.Button buttonShowResults;
        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.TextBox textBoxResultPath;
        private System.Windows.Forms.Label labelResultPath;
        private System.Windows.Forms.Label labelMessageToUser;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button buttonResultLocation;
    }
}


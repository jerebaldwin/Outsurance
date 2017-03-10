namespace Directory
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSourceFile = new System.Windows.Forms.TextBox();
            this.btnImportData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSource = new System.Windows.Forms.Button();
            this.txtFileOne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFiletwo = new System.Windows.Forms.TextBox();
            this.btnExportFiles = new System.Windows.Forms.Button();
            this.btnClearData = new System.Windows.Forms.Button();
            this.btnClearFiles = new System.Windows.Forms.Button();
            this.pbImport = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenerateTextFiles = new System.Windows.Forms.Button();
            this.txtProcessedRecords = new System.Windows.Forms.TextBox();
            this.txtTotalRecords = new System.Windows.Forms.TextBox();
            this.lbOf = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSourceFile
            // 
            this.txtSourceFile.Location = new System.Drawing.Point(107, 12);
            this.txtSourceFile.Name = "txtSourceFile";
            this.txtSourceFile.Size = new System.Drawing.Size(368, 20);
            this.txtSourceFile.TabIndex = 0;
            // 
            // btnImportData
            // 
            this.btnImportData.Location = new System.Drawing.Point(107, 38);
            this.btnImportData.Name = "btnImportData";
            this.btnImportData.Size = new System.Drawing.Size(104, 23);
            this.btnImportData.TabIndex = 1;
            this.btnImportData.Text = "Import Data";
            this.btnImportData.UseVisualStyleBackColor = true;
            this.btnImportData.Click += new System.EventHandler(this.btnImportData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Data Source :";
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(494, 10);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(104, 23);
            this.btnSource.TabIndex = 3;
            this.btnSource.Text = "Browse for File";
            this.btnSource.UseVisualStyleBackColor = true;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // txtFileOne
            // 
            this.txtFileOne.Location = new System.Drawing.Point(12, 171);
            this.txtFileOne.Multiline = true;
            this.txtFileOne.Name = "txtFileOne";
            this.txtFileOne.Size = new System.Drawing.Size(276, 311);
            this.txtFileOne.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "FILE ONE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "FILE TWO";
            // 
            // txtFiletwo
            // 
            this.txtFiletwo.Location = new System.Drawing.Point(382, 171);
            this.txtFiletwo.Multiline = true;
            this.txtFiletwo.Name = "txtFiletwo";
            this.txtFiletwo.Size = new System.Drawing.Size(280, 311);
            this.txtFiletwo.TabIndex = 6;
            // 
            // btnExportFiles
            // 
            this.btnExportFiles.Location = new System.Drawing.Point(226, 488);
            this.btnExportFiles.Name = "btnExportFiles";
            this.btnExportFiles.Size = new System.Drawing.Size(211, 23);
            this.btnExportFiles.TabIndex = 8;
            this.btnExportFiles.Text = "Export Text Files";
            this.btnExportFiles.UseVisualStyleBackColor = true;
            this.btnExportFiles.Click += new System.EventHandler(this.btnExportFiles_Click);
            // 
            // btnClearData
            // 
            this.btnClearData.Location = new System.Drawing.Point(226, 38);
            this.btnClearData.Name = "btnClearData";
            this.btnClearData.Size = new System.Drawing.Size(104, 23);
            this.btnClearData.TabIndex = 10;
            this.btnClearData.Text = "Clear Data";
            this.btnClearData.UseVisualStyleBackColor = true;
            this.btnClearData.Click += new System.EventHandler(this.btnClearData_Click);
            // 
            // btnClearFiles
            // 
            this.btnClearFiles.Location = new System.Drawing.Point(226, 517);
            this.btnClearFiles.Name = "btnClearFiles";
            this.btnClearFiles.Size = new System.Drawing.Size(211, 23);
            this.btnClearFiles.TabIndex = 11;
            this.btnClearFiles.Text = "Clear";
            this.btnClearFiles.UseVisualStyleBackColor = true;
            this.btnClearFiles.Click += new System.EventHandler(this.btnClearFiles_Click);
            // 
            // pbImport
            // 
            this.pbImport.Location = new System.Drawing.Point(107, 67);
            this.pbImport.Name = "pbImport";
            this.pbImport.Size = new System.Drawing.Size(368, 23);
            this.pbImport.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Progress:";
            // 
            // btnGenerateTextFiles
            // 
            this.btnGenerateTextFiles.Location = new System.Drawing.Point(15, 114);
            this.btnGenerateTextFiles.Name = "btnGenerateTextFiles";
            this.btnGenerateTextFiles.Size = new System.Drawing.Size(647, 23);
            this.btnGenerateTextFiles.TabIndex = 15;
            this.btnGenerateTextFiles.Text = "Generate Text Files";
            this.btnGenerateTextFiles.UseVisualStyleBackColor = true;
            this.btnGenerateTextFiles.Click += new System.EventHandler(this.btnGenerateTextFiles_Click);
            // 
            // txtProcessedRecords
            // 
            this.txtProcessedRecords.Location = new System.Drawing.Point(494, 69);
            this.txtProcessedRecords.Name = "txtProcessedRecords";
            this.txtProcessedRecords.Size = new System.Drawing.Size(38, 20);
            this.txtProcessedRecords.TabIndex = 16;
            // 
            // txtTotalRecords
            // 
            this.txtTotalRecords.Location = new System.Drawing.Point(560, 69);
            this.txtTotalRecords.Name = "txtTotalRecords";
            this.txtTotalRecords.Size = new System.Drawing.Size(38, 20);
            this.txtTotalRecords.TabIndex = 17;
            // 
            // lbOf
            // 
            this.lbOf.AutoSize = true;
            this.lbOf.Location = new System.Drawing.Point(536, 73);
            this.lbOf.Name = "lbOf";
            this.lbOf.Size = new System.Drawing.Size(21, 13);
            this.lbOf.TabIndex = 18;
            this.lbOf.Text = "OF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "RECORDS";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 559);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbOf);
            this.Controls.Add(this.txtTotalRecords);
            this.Controls.Add(this.txtProcessedRecords);
            this.Controls.Add(this.btnGenerateTextFiles);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbImport);
            this.Controls.Add(this.btnClearFiles);
            this.Controls.Add(this.btnClearData);
            this.Controls.Add(this.btnExportFiles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFiletwo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFileOne);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImportData);
            this.Controls.Add(this.txtSourceFile);
            this.Name = "Main";
            this.Text = "Outsurance Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSourceFile;
        private System.Windows.Forms.Button btnImportData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.TextBox txtFileOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFiletwo;
        private System.Windows.Forms.Button btnExportFiles;
        private System.Windows.Forms.Button btnClearData;
        private System.Windows.Forms.Button btnClearFiles;
        private System.Windows.Forms.ProgressBar pbImport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenerateTextFiles;
        private System.Windows.Forms.TextBox txtProcessedRecords;
        private System.Windows.Forms.TextBox txtTotalRecords;
        private System.Windows.Forms.Label lbOf;
        private System.Windows.Forms.Label label5;
    }
}


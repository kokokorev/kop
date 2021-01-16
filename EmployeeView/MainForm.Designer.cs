namespace EmployeeView
{
    partial class MainForm
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.controlDataTreeTable = new WindowsFormsControlLibrary.Data.ControlDataTreeTable();
            this.createEmployeeButton = new System.Windows.Forms.Button();
            this.backupSaveButton = new System.Windows.Forms.Button();
            this.componentBackupXml = new NonVisualComponents.Kokorev.ComponentBackupXml(this.components);
            this.buttonWordPosition = new System.Windows.Forms.Button();
            this.buttonWordVacation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.controlDataTableTable = new WindowsFormsControlLibrary.Data.ControlDataTableTable();
            this.buttonLoadFromBackup = new System.Windows.Forms.Button();
            this.componentLoadXml = new NonVisualComponents.Nazarova.ComponentLoadXml(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExcelReportPhone = new System.Windows.Forms.Button();
            this.buttonExcelSubvision = new System.Windows.Forms.Button();
            this.componentDiagramExcel = new NonVisualComponents.ComponentDiagramExcel(this.components);
            this.SuspendLayout();
            // 
            // controlDataTreeTable
            // 
            this.controlDataTreeTable.Location = new System.Drawing.Point(12, 12);
            this.controlDataTreeTable.Name = "controlDataTreeTable";
            this.controlDataTreeTable.Size = new System.Drawing.Size(620, 369);
            this.controlDataTreeTable.TabIndex = 1;
            // 
            // createEmployeeButton
            // 
            this.createEmployeeButton.Location = new System.Drawing.Point(638, 12);
            this.createEmployeeButton.Name = "createEmployeeButton";
            this.createEmployeeButton.Size = new System.Drawing.Size(109, 23);
            this.createEmployeeButton.TabIndex = 2;
            this.createEmployeeButton.Text = "Создать";
            this.createEmployeeButton.UseVisualStyleBackColor = true;
            this.createEmployeeButton.Click += new System.EventHandler(this.createEmployeeButton_Click);
            // 
            // backupSaveButton
            // 
            this.backupSaveButton.Location = new System.Drawing.Point(638, 41);
            this.backupSaveButton.Name = "backupSaveButton";
            this.backupSaveButton.Size = new System.Drawing.Size(109, 23);
            this.backupSaveButton.TabIndex = 3;
            this.backupSaveButton.Text = "Создать бэкап";
            this.backupSaveButton.UseVisualStyleBackColor = true;
            this.backupSaveButton.Click += new System.EventHandler(this.backupSaveButton_Click);
            // 
            // buttonWordPosition
            // 
            this.buttonWordPosition.Location = new System.Drawing.Point(638, 125);
            this.buttonWordPosition.Name = "buttonWordPosition";
            this.buttonWordPosition.Size = new System.Drawing.Size(109, 23);
            this.buttonWordPosition.TabIndex = 4;
            this.buttonWordPosition.Text = "По должностям";
            this.buttonWordPosition.UseVisualStyleBackColor = true;
            this.buttonWordPosition.Click += new System.EventHandler(this.buttonWordPosition_Click);
            // 
            // buttonWordVacation
            // 
            this.buttonWordVacation.Location = new System.Drawing.Point(638, 154);
            this.buttonWordVacation.Name = "buttonWordVacation";
            this.buttonWordVacation.Size = new System.Drawing.Size(109, 23);
            this.buttonWordVacation.TabIndex = 5;
            this.buttonWordVacation.Text = "По отпускам";
            this.buttonWordVacation.UseVisualStyleBackColor = true;
            this.buttonWordVacation.Click += new System.EventHandler(this.buttonWordVacation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(638, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Отчеты в Word";
            // 
            // controlDataTableTable
            // 
            this.controlDataTableTable.Location = new System.Drawing.Point(753, 12);
            this.controlDataTableTable.Name = "controlDataTableTable";
            this.controlDataTableTable.SelectedRowIndex = -1;
            this.controlDataTableTable.Size = new System.Drawing.Size(620, 369);
            this.controlDataTableTable.TabIndex = 1;
            // 
            // buttonLoadFromBackup
            // 
            this.buttonLoadFromBackup.Location = new System.Drawing.Point(638, 70);
            this.buttonLoadFromBackup.Name = "buttonLoadFromBackup";
            this.buttonLoadFromBackup.Size = new System.Drawing.Size(109, 23);
            this.buttonLoadFromBackup.TabIndex = 7;
            this.buttonLoadFromBackup.Text = "Загрузить";
            this.buttonLoadFromBackup.UseVisualStyleBackColor = true;
            this.buttonLoadFromBackup.Click += new System.EventHandler(this.buttonLoadFromBackup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Отчеты в Excel";
            // 
            // buttonExcelReportPhone
            // 
            this.buttonExcelReportPhone.Location = new System.Drawing.Point(638, 196);
            this.buttonExcelReportPhone.Name = "buttonExcelReportPhone";
            this.buttonExcelReportPhone.Size = new System.Drawing.Size(109, 23);
            this.buttonExcelReportPhone.TabIndex = 9;
            this.buttonExcelReportPhone.Text = "Телефоны";
            this.buttonExcelReportPhone.UseVisualStyleBackColor = true;
            this.buttonExcelReportPhone.Click += new System.EventHandler(this.buttonExcelReportPhone_Click);
            // 
            // buttonExcelSubvision
            // 
            this.buttonExcelSubvision.Location = new System.Drawing.Point(638, 225);
            this.buttonExcelSubvision.Name = "buttonExcelSubvision";
            this.buttonExcelSubvision.Size = new System.Drawing.Size(109, 23);
            this.buttonExcelSubvision.TabIndex = 10;
            this.buttonExcelSubvision.Text = "Отделы";
            this.buttonExcelSubvision.UseVisualStyleBackColor = true;
            this.buttonExcelSubvision.Click += new System.EventHandler(this.buttonExcelSubvision_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 393);
            this.Controls.Add(this.buttonExcelSubvision);
            this.Controls.Add(this.buttonExcelReportPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoadFromBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonWordVacation);
            this.Controls.Add(this.buttonWordPosition);
            this.Controls.Add(this.backupSaveButton);
            this.Controls.Add(this.createEmployeeButton);
            this.Controls.Add(this.controlDataTreeTable);
            this.Controls.Add(this.controlDataTableTable);
            this.Name = "MainForm";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private WindowsFormsControlLibrary.Data.ControlDataTreeTable controlDataTreeTable;
        private System.Windows.Forms.Button createEmployeeButton;
        private System.Windows.Forms.Button backupSaveButton;
        private NonVisualComponents.Kokorev.ComponentBackupXml componentBackupXml;
        private System.Windows.Forms.Button buttonWordPosition;
        private System.Windows.Forms.Button buttonWordVacation;
        private System.Windows.Forms.Label label1;

        private WindowsFormsControlLibrary.Data.ControlDataTableTable controlDataTableTable;
        private System.Windows.Forms.Button buttonLoadFromBackup;
        private NonVisualComponents.Nazarova.ComponentLoadXml componentLoadXml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonExcelReportPhone;
        private System.Windows.Forms.Button buttonExcelSubvision;
        private NonVisualComponents.ComponentDiagramExcel componentDiagramExcel;
    }
}


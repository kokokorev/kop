using System.ComponentModel;

namespace EmployeeView
{
    partial class CreateEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.controlSelectedComboBoxEnum = new WindowsFormsControlLibrary.Selected.ControlSelectedComboBoxEnum();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fioTextBox = new System.Windows.Forms.TextBox();
            this.controlInputRegexDate = new WindowsFormsControlLibrary.Input.ControlInputRegexDate();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxWorkForm = new System.Windows.Forms.TextBox();
            this.controlSelectedComboBoxEnumSubvision = new WindowsFormsControlLibrary.Selected.ControlSelectedComboBoxEnum();
            this.SuspendLayout();
            // 
            // controlSelectedComboBoxEnum
            // 
            this.controlSelectedComboBoxEnum.Location = new System.Drawing.Point(12, 64);
            this.controlSelectedComboBoxEnum.Name = "controlSelectedComboBoxEnum";
            this.controlSelectedComboBoxEnum.SelectedIndex = -1;
            this.controlSelectedComboBoxEnum.SelectedItem = null;
            this.controlSelectedComboBoxEnum.Size = new System.Drawing.Size(237, 25);
            this.controlSelectedComboBoxEnum.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(175, 223);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ФИО";
            // 
            // fioTextBox
            // 
            this.fioTextBox.Location = new System.Drawing.Point(12, 25);
            this.fioTextBox.Name = "fioTextBox";
            this.fioTextBox.Size = new System.Drawing.Size(237, 20);
            this.fioTextBox.TabIndex = 6;
            // 
            // controlInputRegexDate
            // 
            this.controlInputRegexDate.Email = "";
            this.controlInputRegexDate.Location = new System.Drawing.Point(12, 108);
            this.controlInputRegexDate.Name = "controlInputRegexDate";
            this.controlInputRegexDate.Size = new System.Drawing.Size(237, 20);
            this.controlInputRegexDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Начало отпуска";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Подразделение";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Рабочий телефон";
            // 
            // textBoxWorkForm
            // 
            this.textBoxWorkForm.Location = new System.Drawing.Point(12, 197);
            this.textBoxWorkForm.Name = "textBoxWorkForm";
            this.textBoxWorkForm.Size = new System.Drawing.Size(237, 20);
            this.textBoxWorkForm.TabIndex = 14;
            // 
            // controlSelectedComboBoxEnumSubvision
            // 
            this.controlSelectedComboBoxEnumSubvision.Location = new System.Drawing.Point(12, 152);
            this.controlSelectedComboBoxEnumSubvision.Name = "controlSelectedComboBoxEnumSubvision";
            this.controlSelectedComboBoxEnumSubvision.SelectedIndex = -1;
            this.controlSelectedComboBoxEnumSubvision.SelectedItem = null;
            this.controlSelectedComboBoxEnumSubvision.Size = new System.Drawing.Size(237, 25);
            this.controlSelectedComboBoxEnumSubvision.TabIndex = 15;
            // 
            // CreateEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 254);
            this.Controls.Add(this.controlSelectedComboBoxEnumSubvision);
            this.Controls.Add(this.textBoxWorkForm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.controlInputRegexDate);
            this.Controls.Add(this.fioTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.controlSelectedComboBoxEnum);
            this.Name = "CreateEmployeeForm";
            this.Text = "Добавить сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WindowsFormsControlLibrary.Selected.ControlSelectedComboBoxEnum controlSelectedComboBoxEnum;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fioTextBox;
        private WindowsFormsControlLibrary.Input.ControlInputRegexDate controlInputRegexDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxWorkForm;
        private WindowsFormsControlLibrary.Selected.ControlSelectedComboBoxEnum controlSelectedComboBoxEnumSubvision;
    }
}
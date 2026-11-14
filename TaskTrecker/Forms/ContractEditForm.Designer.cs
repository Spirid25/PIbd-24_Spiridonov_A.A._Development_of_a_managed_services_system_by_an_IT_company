namespace TaskTrecker.Forms
{
    partial class ContractEditForm : Form
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
            comboBoxClient = new ComboBox();
            comboBoxEmployee = new ComboBox();
            comboBoxStatus = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // comboBoxClient
            // 
            comboBoxClient.FormattingEnabled = true;
            comboBoxClient.Location = new Point(148, 49);
            comboBoxClient.Name = "comboBoxClient";
            comboBoxClient.Size = new Size(121, 23);
            comboBoxClient.TabIndex = 0;
            // 
            // comboBoxEmployee
            // 
            comboBoxEmployee.FormattingEnabled = true;
            comboBoxEmployee.Location = new Point(148, 113);
            comboBoxEmployee.Name = "comboBoxEmployee";
            comboBoxEmployee.Size = new Size(121, 23);
            comboBoxEmployee.TabIndex = 1;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(148, 176);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(121, 23);
            comboBoxStatus.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 49);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Клиент";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 113);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 4;
            label2.Text = "Сотрудник";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 179);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 5;
            label3.Text = "Статус";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(24, 322);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(194, 322);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отменв";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ContractEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 402);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxStatus);
            Controls.Add(comboBoxEmployee);
            Controls.Add(comboBoxClient);
            Name = "ContractsEditForm";
            Text = "ContractsEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxClient;
        private ComboBox comboBoxEmployee;
        private ComboBox comboBoxStatus;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
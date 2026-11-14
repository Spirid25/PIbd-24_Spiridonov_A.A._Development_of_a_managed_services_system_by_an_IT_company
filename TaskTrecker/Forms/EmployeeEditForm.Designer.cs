namespace TaskTrecker.Forms
{
    partial class EmployeeEditForm
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
            label = new Label();
            label2 = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            buttonSave = new Button();
            buttonDelete = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(17, 64);
            label.Name = "label";
            label.Size = new Size(31, 15);
            label.TabIndex = 0;
            label.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 144);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Фамилия";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(139, 68);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(100, 23);
            textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(139, 136);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(100, 23);
            textBoxLastName.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(36, 285);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(194, 285);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "Отмена";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonCancel_Click;
            // 
            // EmployeeEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 364);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(label2);
            Controls.Add(label);
            Name = "EmployeeEditForm";
            Text = "EmployeeEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private Label label2;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Button buttonSave;
        private Button buttonDelete;
    }
}
namespace TaskTrecker.Forms
{
    partial class ClientEditForm : Form
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
            textBoxName = new TextBox();
            Name = new Label();
            textBoxInn = new TextBox();
            label1 = new Label();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(134, 48);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Location = new Point(23, 48);
            Name.Name = "Name";
            Name.Size = new Size(59, 15);
            Name.TabIndex = 1;
            Name.Text = "Название";
            // 
            // textBoxInn
            // 
            textBoxInn.Location = new Point(134, 116);
            textBoxInn.Name = "textBoxInn";
            textBoxInn.Size = new Size(100, 23);
            textBoxInn.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 116);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 3;
            label1.Text = "ИНН";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(34, 235);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(187, 235);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ClientEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 292);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(label1);
            Controls.Add(textBoxInn);
            Controls.Add(Name);
            Controls.Add(textBoxName);
            Text = "ClientEditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label Name;
        private TextBox textBoxInn;
        private Label label1;
        private Button buttonSave;
        private Button buttonCancel;
    }
}
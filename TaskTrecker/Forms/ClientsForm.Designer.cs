namespace TaskTrecker.Forms
{
    partial class ClientsForm
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
            dataGridViewClients = new DataGridView();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(12, 12);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.Size = new Size(636, 426);
            dataGridViewClients.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(666, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(122, 122);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += btnAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(666, 160);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(122, 122);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += btnUpdate_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(666, 316);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(122, 122);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "-";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += btnDelete_Click;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewClients);
            Name = "ClientsForm";
            Text = "ClientsForm";
            Load += ClientsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewClients;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
    }
}
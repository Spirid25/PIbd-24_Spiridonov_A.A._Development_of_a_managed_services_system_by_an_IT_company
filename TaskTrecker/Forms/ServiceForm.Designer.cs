namespace TaskTrecker.Forms
{
    partial class ServiceForm
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
            dataGridViewData = new DataGridView();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            buttonDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewData
            // 
            dataGridViewData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData.Location = new Point(12, 12);
            dataGridViewData.Name = "dataGridViewData";
            dataGridViewData.Size = new Size(615, 426);
            dataGridViewData.TabIndex = 0;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(645, 12);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(143, 115);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(645, 165);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(143, 120);
            buttonUpdate.TabIndex = 2;
            buttonUpdate.Text = "UPDATE";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(645, 321);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(143, 117);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "-";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // ServiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonAdd);
            Controls.Add(dataGridViewData);
            Name = "ServiceForm";
            Text = "ServicesForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewData;
        private Button buttonAdd;
        private Button buttonUpdate;
        private Button buttonDelete;
    }
}
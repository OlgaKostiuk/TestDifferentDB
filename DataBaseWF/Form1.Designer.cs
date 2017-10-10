namespace DataBaseWF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.boxId = new System.Windows.Forms.TextBox();
            this.boxFirstName = new System.Windows.Forms.TextBox();
            this.boxLastName = new System.Windows.Forms.TextBox();
            this.boxAge = new System.Windows.Forms.TextBox();
            this.bCreate = new System.Windows.Forms.Button();
            this.bRead = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SQLSwitcher = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(3, 3);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(418, 310);
            this.dataGrid.TabIndex = 0;
            // 
            // boxId
            // 
            this.boxId.Location = new System.Drawing.Point(3, 319);
            this.boxId.Name = "boxId";
            this.boxId.Size = new System.Drawing.Size(100, 20);
            this.boxId.TabIndex = 1;
            // 
            // boxFirstName
            // 
            this.boxFirstName.Location = new System.Drawing.Point(109, 319);
            this.boxFirstName.Name = "boxFirstName";
            this.boxFirstName.Size = new System.Drawing.Size(100, 20);
            this.boxFirstName.TabIndex = 2;
            // 
            // boxLastName
            // 
            this.boxLastName.Location = new System.Drawing.Point(215, 319);
            this.boxLastName.Name = "boxLastName";
            this.boxLastName.Size = new System.Drawing.Size(100, 20);
            this.boxLastName.TabIndex = 3;
            // 
            // boxAge
            // 
            this.boxAge.Location = new System.Drawing.Point(321, 319);
            this.boxAge.Name = "boxAge";
            this.boxAge.Size = new System.Drawing.Size(100, 20);
            this.boxAge.TabIndex = 4;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(3, 367);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(100, 23);
            this.bCreate.TabIndex = 5;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // bRead
            // 
            this.bRead.Location = new System.Drawing.Point(109, 367);
            this.bRead.Name = "bRead";
            this.bRead.Size = new System.Drawing.Size(100, 23);
            this.bRead.TabIndex = 6;
            this.bRead.Text = "Read";
            this.bRead.UseVisualStyleBackColor = true;
            this.bRead.Click += new System.EventHandler(this.bRead_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(215, 367);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(100, 23);
            this.bUpdate.TabIndex = 7;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(321, 367);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(100, 23);
            this.bDelete.TabIndex = 8;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "FirstName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "LastName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Age";
            // 
            // SQLSwitcher
            // 
            this.SQLSwitcher.FormattingEnabled = true;
            this.SQLSwitcher.Location = new System.Drawing.Point(427, 12);
            this.SQLSwitcher.Name = "SQLSwitcher";
            this.SQLSwitcher.Size = new System.Drawing.Size(110, 21);
            this.SQLSwitcher.TabIndex = 13;
            this.SQLSwitcher.SelectedIndexChanged += new System.EventHandler(this.SQLSwitcher_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 403);
            this.Controls.Add(this.SQLSwitcher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bRead);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.boxAge);
            this.Controls.Add(this.boxLastName);
            this.Controls.Add(this.boxFirstName);
            this.Controls.Add(this.boxId);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox boxId;
        private System.Windows.Forms.TextBox boxFirstName;
        private System.Windows.Forms.TextBox boxLastName;
        private System.Windows.Forms.TextBox boxAge;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Button bRead;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SQLSwitcher;
    }
}


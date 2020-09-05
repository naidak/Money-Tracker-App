namespace MoneyTracker_pokusaj_3
{
    partial class MainForm_3cs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_3cs));
            this.label1 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tranDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.counterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyTrackertableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MoneyTracker_pokusaj_3.DataSet1();
            this.addTr = new System.Windows.Forms.Button();
            this.pay = new System.Windows.Forms.RadioButton();
            this.income = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.moneyTracker_tableTableAdapter = new MoneyTracker_pokusaj_3.DataSet1TableAdapters.MoneyTracker_tableTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTrackertableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(58, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter value:";
            // 
            // value
            // 
            this.value.BackColor = System.Drawing.Color.White;
            this.value.Location = new System.Drawing.Point(61, 40);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(705, 22);
            this.value.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionValueDataGridViewTextBoxColumn,
            this.tranDescriptionDataGridViewTextBoxColumn,
            this.transDateDataGridViewTextBoxColumn,
            this.transTypeDataGridViewCheckBoxColumn,
            this.counterIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.moneyTrackertableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(705, 446);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // transactionValueDataGridViewTextBoxColumn
            // 
            this.transactionValueDataGridViewTextBoxColumn.DataPropertyName = "TransactionValue";
            this.transactionValueDataGridViewTextBoxColumn.HeaderText = "TransactionValue";
            this.transactionValueDataGridViewTextBoxColumn.Name = "transactionValueDataGridViewTextBoxColumn";
            // 
            // tranDescriptionDataGridViewTextBoxColumn
            // 
            this.tranDescriptionDataGridViewTextBoxColumn.DataPropertyName = "TranDescription";
            this.tranDescriptionDataGridViewTextBoxColumn.HeaderText = "TranDescription";
            this.tranDescriptionDataGridViewTextBoxColumn.Name = "tranDescriptionDataGridViewTextBoxColumn";
            // 
            // transDateDataGridViewTextBoxColumn
            // 
            this.transDateDataGridViewTextBoxColumn.DataPropertyName = "TransDate";
            this.transDateDataGridViewTextBoxColumn.HeaderText = "TransDate";
            this.transDateDataGridViewTextBoxColumn.Name = "transDateDataGridViewTextBoxColumn";
            // 
            // transTypeDataGridViewCheckBoxColumn
            // 
            this.transTypeDataGridViewCheckBoxColumn.DataPropertyName = "transType";
            this.transTypeDataGridViewCheckBoxColumn.HeaderText = "transType";
            this.transTypeDataGridViewCheckBoxColumn.Name = "transTypeDataGridViewCheckBoxColumn";
            // 
            // counterIDDataGridViewTextBoxColumn
            // 
            this.counterIDDataGridViewTextBoxColumn.DataPropertyName = "CounterID";
            this.counterIDDataGridViewTextBoxColumn.HeaderText = "CounterID";
            this.counterIDDataGridViewTextBoxColumn.Name = "counterIDDataGridViewTextBoxColumn";
            this.counterIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moneyTrackertableBindingSource
            // 
            this.moneyTrackertableBindingSource.DataMember = "MoneyTracker_table";
            this.moneyTrackertableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addTr
            // 
            this.addTr.BackColor = System.Drawing.Color.White;
            this.addTr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTr.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addTr.Location = new System.Drawing.Point(628, 183);
            this.addTr.Name = "addTr";
            this.addTr.Size = new System.Drawing.Size(138, 32);
            this.addTr.TabIndex = 3;
            this.addTr.Text = "Add Transaction";
            this.addTr.UseVisualStyleBackColor = false;
            this.addTr.Click += new System.EventHandler(this.addTr_Click);
            // 
            // pay
            // 
            this.pay.AutoSize = true;
            this.pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(255)))), ((int)(((byte)(229)))));
            this.pay.Checked = true;
            this.pay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pay.Location = new System.Drawing.Point(61, 211);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(95, 25);
            this.pay.TabIndex = 4;
            this.pay.TabStop = true;
            this.pay.Text = "Payment";
            this.pay.UseVisualStyleBackColor = false;
            // 
            // income
            // 
            this.income.AutoSize = true;
            this.income.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(255)))), ((int)(((byte)(229)))));
            this.income.Cursor = System.Windows.Forms.Cursors.Hand;
            this.income.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.income.Location = new System.Drawing.Point(186, 211);
            this.income.Name = "income";
            this.income.Size = new System.Drawing.Size(86, 25);
            this.income.TabIndex = 5;
            this.income.Text = "Income";
            this.income.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(58, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Description:";
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.White;
            this.description.ForeColor = System.Drawing.Color.Black;
            this.description.Location = new System.Drawing.Point(61, 102);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(705, 71);
            this.description.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(58, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Please choose:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(59, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Transactions:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker1.Location = new System.Drawing.Point(295, 211);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 26);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // moneyTracker_tableTableAdapter
            // 
            this.moneyTracker_tableTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.White;
            this.buttonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdate.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdate.Location = new System.Drawing.Point(628, 234);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(138, 32);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // MainForm_3cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(255)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(834, 737);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.income);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.addTr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm_3cs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Money Tracker";
            this.Load += new System.EventHandler(this.MainForm_3cs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyTrackertableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addTr;
        private System.Windows.Forms.RadioButton pay;
        private System.Windows.Forms.RadioButton income;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource moneyTrackertableBindingSource;
        private DataSet1TableAdapters.MoneyTracker_tableTableAdapter moneyTracker_tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tranDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn transTypeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdate;
    }
}
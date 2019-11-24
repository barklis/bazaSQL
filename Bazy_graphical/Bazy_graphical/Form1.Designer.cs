namespace Bazy_graphical
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.value_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comment_box = new System.Windows.Forms.TextBox();
            this.insert_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.database1DataSet = new Bazy_graphical.Database1DataSet();
            this.measurementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.measurementsTableAdapter = new Bazy_graphical.Database1DataSetTableAdapters.MeasurementsTableAdapter();
            this.list_id = new System.Windows.Forms.ListBox();
            this.list_value = new System.Windows.Forms.ListBox();
            this.list_comment = new System.Windows.Forms.ListBox();
            this.list_time = new System.Windows.Forms.ListBox();
            this.sql_table = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // value_box
            // 
            this.value_box.Location = new System.Drawing.Point(71, 24);
            this.value_box.Name = "value_box";
            this.value_box.Size = new System.Drawing.Size(128, 20);
            this.value_box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Comment";
            // 
            // comment_box
            // 
            this.comment_box.Location = new System.Drawing.Point(71, 59);
            this.comment_box.Name = "comment_box";
            this.comment_box.Size = new System.Drawing.Size(128, 20);
            this.comment_box.TabIndex = 3;
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(260, 24);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(80, 43);
            this.insert_button.TabIndex = 4;
            this.insert_button.Text = "Insert";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(346, 24);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(80, 43);
            this.delete_button.TabIndex = 5;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(432, 24);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(80, 43);
            this.update_button.TabIndex = 6;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // measurementsBindingSource
            // 
            this.measurementsBindingSource.DataMember = "Measurements";
            this.measurementsBindingSource.DataSource = this.database1DataSet;
            // 
            // measurementsTableAdapter
            // 
            this.measurementsTableAdapter.ClearBeforeFill = true;
            // 
            // list_id
            // 
            this.list_id.FormattingEnabled = true;
            this.list_id.Location = new System.Drawing.Point(17, 99);
            this.list_id.Name = "list_id";
            this.list_id.Size = new System.Drawing.Size(78, 329);
            this.list_id.TabIndex = 7;
            // 
            // list_value
            // 
            this.list_value.FormattingEnabled = true;
            this.list_value.Location = new System.Drawing.Point(221, 99);
            this.list_value.Name = "list_value";
            this.list_value.Size = new System.Drawing.Size(78, 329);
            this.list_value.TabIndex = 8;
            // 
            // list_comment
            // 
            this.list_comment.FormattingEnabled = true;
            this.list_comment.Location = new System.Drawing.Point(334, 99);
            this.list_comment.Name = "list_comment";
            this.list_comment.Size = new System.Drawing.Size(78, 329);
            this.list_comment.TabIndex = 9;
            // 
            // list_time
            // 
            this.list_time.FormattingEnabled = true;
            this.list_time.Location = new System.Drawing.Point(121, 99);
            this.list_time.Name = "list_time";
            this.list_time.Size = new System.Drawing.Size(78, 329);
            this.list_time.TabIndex = 10;
            // 
            // sql_table
            // 
            this.sql_table.AutoGenerateColumns = false;
            this.sql_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sql_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.valueDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.sql_table.DataSource = this.measurementsBindingSource;
            this.sql_table.Location = new System.Drawing.Point(428, 99);
            this.sql_table.Name = "sql_table";
            this.sql_table.Size = new System.Drawing.Size(357, 328);
            this.sql_table.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sql_table);
            this.Controls.Add(this.list_time);
            this.Controls.Add(this.list_comment);
            this.Controls.Add(this.list_value);
            this.Controls.Add(this.list_id);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.comment_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.value_box);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.measurementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sql_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox value_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox comment_box;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button update_button;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource measurementsBindingSource;
        private Database1DataSetTableAdapters.MeasurementsTableAdapter measurementsTableAdapter;
        private System.Windows.Forms.ListBox list_id;
        private System.Windows.Forms.ListBox list_value;
        private System.Windows.Forms.ListBox list_comment;
        private System.Windows.Forms.ListBox list_time;
        private System.Windows.Forms.DataGridView sql_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}


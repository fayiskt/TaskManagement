namespace dotnet_test
{
    partial class Task_list
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
            this.dB_taskDataSet = new dotnet_test.DB_taskDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new dotnet_test.DB_taskDataSetTableAdapters.TableTableAdapter();
            this.taskidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logout_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.duedate_picker = new System.Windows.Forms.DateTimePicker();
            this.status_box = new System.Windows.Forms.ComboBox();
            this.statusCheckbox = new System.Windows.Forms.CheckBox();
            this.dateCheckBox = new System.Windows.Forms.CheckBox();
            this.listView = new System.Windows.Forms.DataGridView();
            this.reset_filter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dB_taskDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // dB_taskDataSet
            // 
            this.dB_taskDataSet.DataSetName = "DB_taskDataSet";
            this.dB_taskDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dB_taskDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // taskidDataGridViewTextBoxColumn
            // 
            this.taskidDataGridViewTextBoxColumn.DataPropertyName = "Taskid";
            this.taskidDataGridViewTextBoxColumn.HeaderText = "Taskid";
            this.taskidDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.taskidDataGridViewTextBoxColumn.Name = "taskidDataGridViewTextBoxColumn";
            this.taskidDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            this.titleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "Duedate";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "Duedate";
            this.duedateDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            this.duedateDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 22;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(760, 371);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(102, 45);
            this.logout_button.TabIndex = 2;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter by Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filter by Date";
            // 
            // duedate_picker
            // 
            this.duedate_picker.Location = new System.Drawing.Point(188, 476);
            this.duedate_picker.Name = "duedate_picker";
            this.duedate_picker.Size = new System.Drawing.Size(182, 26);
            this.duedate_picker.TabIndex = 15;
            this.duedate_picker.ValueChanged += new System.EventHandler(this.duedate_picker_ValueChanged);
            // 
            // status_box
            // 
            this.status_box.FormattingEnabled = true;
            this.status_box.Items.AddRange(new object[] {
            "Complete",
            "Incomplete"});
            this.status_box.Location = new System.Drawing.Point(188, 434);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(182, 28);
            this.status_box.TabIndex = 14;
            this.status_box.SelectedIndexChanged += new System.EventHandler(this.status_box_SelectedIndexChanged);
            this.status_box.TextChanged += new System.EventHandler(this.status_box_TextChanged);
            // 
            // statusCheckbox
            // 
            this.statusCheckbox.AutoSize = true;
            this.statusCheckbox.Location = new System.Drawing.Point(390, 438);
            this.statusCheckbox.Name = "statusCheckbox";
            this.statusCheckbox.Size = new System.Drawing.Size(107, 24);
            this.statusCheckbox.TabIndex = 16;
            this.statusCheckbox.Text = "Not Active";
            this.statusCheckbox.UseVisualStyleBackColor = true;
            this.statusCheckbox.CheckedChanged += new System.EventHandler(this.statusCheckbox_CheckedChanged);
            // 
            // dateCheckBox
            // 
            this.dateCheckBox.AutoSize = true;
            this.dateCheckBox.Location = new System.Drawing.Point(390, 480);
            this.dateCheckBox.Name = "dateCheckBox";
            this.dateCheckBox.Size = new System.Drawing.Size(107, 24);
            this.dateCheckBox.TabIndex = 17;
            this.dateCheckBox.Text = "Not Active";
            this.dateCheckBox.UseVisualStyleBackColor = true;
            this.dateCheckBox.CheckedChanged += new System.EventHandler(this.dateCheckBox_CheckedChanged);
            // 
            // listView
            // 
            this.listView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView.Location = new System.Drawing.Point(71, 59);
            this.listView.Name = "listView";
            this.listView.RowTemplate.Height = 28;
            this.listView.Size = new System.Drawing.Size(791, 292);
            this.listView.TabIndex = 18;
            // 
            // reset_filter
            // 
            this.reset_filter.Location = new System.Drawing.Point(390, 527);
            this.reset_filter.Name = "reset_filter";
            this.reset_filter.Size = new System.Drawing.Size(138, 37);
            this.reset_filter.TabIndex = 19;
            this.reset_filter.Text = "Reset Filter";
            this.reset_filter.UseVisualStyleBackColor = true;
            this.reset_filter.Click += new System.EventHandler(this.reset_filter_Click);
            // 
            // Task_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 606);
            this.Controls.Add(this.reset_filter);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.dateCheckBox);
            this.Controls.Add(this.statusCheckbox);
            this.Controls.Add(this.duedate_picker);
            this.Controls.Add(this.status_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logout_button);
            this.Name = "Task_list";
            this.Text = "Task list";
            this.Load += new System.EventHandler(this.Task_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_taskDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_taskDataSet dB_taskDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private DB_taskDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn taskidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker duedate_picker;
        private System.Windows.Forms.ComboBox status_box;
        private System.Windows.Forms.CheckBox statusCheckbox;
        private System.Windows.Forms.CheckBox dateCheckBox;
        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.Button reset_filter;
    }
}
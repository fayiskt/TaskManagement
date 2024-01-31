namespace dotnet_test
{
    partial class task_management_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.title_box = new System.Windows.Forms.TextBox();
            this.description_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.status_box = new System.Windows.Forms.ComboBox();
            this.add_button = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.taskGridView = new System.Windows.Forms.DataGridView();
            this.refresh_button = new System.Windows.Forms.Button();
            this.duedate_picker = new System.Windows.Forms.DateTimePicker();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.logout_button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // title_box
            // 
            this.title_box.Location = new System.Drawing.Point(158, 84);
            this.title_box.Name = "title_box";
            this.title_box.Size = new System.Drawing.Size(178, 26);
            this.title_box.TabIndex = 1;
            // 
            // description_box
            // 
            this.description_box.Location = new System.Drawing.Point(158, 130);
            this.description_box.Multiline = true;
            this.description_box.Name = "description_box";
            this.description_box.Size = new System.Drawing.Size(178, 79);
            this.description_box.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Due Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // status_box
            // 
            this.status_box.FormattingEnabled = true;
            this.status_box.Items.AddRange(new object[] {
            "Complete",
            "Incomplete"});
            this.status_box.Location = new System.Drawing.Point(158, 275);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(178, 28);
            this.status_box.TabIndex = 7;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(158, 330);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(75, 37);
            this.add_button.TabIndex = 8;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(248, 330);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(75, 37);
            this.update_button.TabIndex = 9;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(340, 330);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(75, 37);
            this.delete_button.TabIndex = 10;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // taskGridView
            // 
            this.taskGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskGridView.Location = new System.Drawing.Point(447, 38);
            this.taskGridView.Name = "taskGridView";
            this.taskGridView.RowTemplate.Height = 28;
            this.taskGridView.Size = new System.Drawing.Size(777, 284);
            this.taskGridView.TabIndex = 11;
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(1081, 330);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(143, 35);
            this.refresh_button.TabIndex = 12;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // duedate_picker
            // 
            this.duedate_picker.Location = new System.Drawing.Point(154, 226);
            this.duedate_picker.Name = "duedate_picker";
            this.duedate_picker.Size = new System.Drawing.Size(182, 26);
            this.duedate_picker.TabIndex = 13;
            // 
            // id_box
            // 
            this.id_box.Location = new System.Drawing.Point(158, 38);
            this.id_box.Name = "id_box";
            this.id_box.Size = new System.Drawing.Size(178, 26);
            this.id_box.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // logout_button2
            // 
            this.logout_button2.Location = new System.Drawing.Point(1088, 401);
            this.logout_button2.Name = "logout_button2";
            this.logout_button2.Size = new System.Drawing.Size(136, 33);
            this.logout_button2.TabIndex = 16;
            this.logout_button2.Text = "Logout";
            this.logout_button2.UseVisualStyleBackColor = true;
            this.logout_button2.Click += new System.EventHandler(this.logout_button2_Click);
            // 
            // task_management_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 446);
            this.Controls.Add(this.logout_button2);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.duedate_picker);
            this.Controls.Add(this.refresh_button);
            this.Controls.Add(this.taskGridView);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.status_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.description_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title_box);
            this.Controls.Add(this.label1);
            this.Name = "task_management_form";
            this.Text = "Task Management";
            this.Load += new System.EventHandler(this.task_management_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title_box;
        private System.Windows.Forms.TextBox description_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox status_box;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.DataGridView taskGridView;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.DateTimePicker duedate_picker;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button logout_button2;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace dotnet_test
{
    public partial class Task_list : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\USER\Documents\DB_task.mdf;Integrated Security = True; Connect Timeout = 30");
        public Task_list()
        {
            InitializeComponent();
        }


        public void display_task()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table]";
            cmd.ExecuteNonQuery();
            DataTable dtable = new DataTable();
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            dadapter.Fill(dtable);
            listView.DataSource = dtable;
            connection.Close();
        }

        public void statusFilter()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table] WHERE Status = @Status";
            cmd.Parameters.AddWithValue("@Status", status_box.Text);
            cmd.ExecuteNonQuery();
            DataTable dtable = new DataTable();
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            dadapter.Fill(dtable);
            listView.DataSource = dtable;
            connection.Close();
            statusCheckbox.Checked = true;
        }
        public void dateFilter()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table] WHERE Duedate = @Duedate";
            cmd.Parameters.AddWithValue("@Duedate", duedate_picker.Value.Date);

            cmd.ExecuteNonQuery();
            DataTable dtable = new DataTable();
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            dadapter.Fill(dtable);
            listView.DataSource = dtable;
            connection.Close();
        }

        public void bothFilter()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Table] WHERE Duedate = @Duedate AND Status = @Status";
            cmd.Parameters.AddWithValue("@Duedate", duedate_picker.Value.Date);
            cmd.Parameters.AddWithValue("@Status", status_box.Text);
            cmd.ExecuteNonQuery();
            DataTable dtable = new DataTable();
            SqlDataAdapter dadapter = new SqlDataAdapter(cmd);
            dadapter.Fill(dtable);
            listView.DataSource = dtable;
            connection.Close();
        }

        private void Task_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_taskDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.dB_taskDataSet.Table);
            display_task();
        }


        

        private void logout_button_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            this.Hide();
            login.Show();

        }

        private void status_box_TextChanged(object sender, EventArgs e)
        {
            statusCheckbox.Checked = true;
            if (true == dateCheckBox.Checked)
            {
                bothFilter();
            }
            else
            {
                statusFilter();
            }

        }

        private void duedate_picker_ValueChanged(object sender, EventArgs e)
        {
            dateCheckBox.Checked = true;
            if (true == statusCheckbox.Checked)
            {
                bothFilter();
            }
            else
            {
                dateFilter();
            }
        }

        private void status_box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void statusCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (true == statusCheckbox.Checked)
            {
                statusCheckbox.Text = "Active";
            }
            else
            {
                statusCheckbox.Text = "Not active";
                if(true == dateCheckBox.Checked)
                {
                    dateFilter();
                }
                else
                {
                    display_task();
                }
            }
        }

        private void dateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (true == dateCheckBox.Checked)
            {
                dateCheckBox.Text = "Active";
            }
            else
            {
                dateCheckBox.Text = "Not active";
                if (true == statusCheckbox.Checked)
                {
                    statusFilter();
                }
                else
                {
                    display_task();
                }
            }
        }

        private void reset_filter_Click(object sender, EventArgs e)
        {
            dateCheckBox.Checked = false;
            statusCheckbox.Checked = false;
            status_box.Text = "";
            duedate_picker.Value = new DateTime(2024, 01, 01);
            display_task();

        }
    }
    
}

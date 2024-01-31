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
    public partial class task_management_form : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\USER\Documents\DB_task.mdf;Integrated Security = True; Connect Timeout = 30");
        public task_management_form()
        {
            InitializeComponent();
        }

        private void task_management_form_Load(object sender, EventArgs e)
        {
            display_task();
        }

        private void add_button_Click(object sender, EventArgs e)
        {
            if ("" != id_box.Text)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "INSERT INTO [Table] (Taskid, Title, Description, Duedate, Status) VALUES (@Taskid, @Title, @Description, @Duedate, @Status)";

                    cmd.Parameters.AddWithValue("@Taskid", id_box.Text);
                    cmd.Parameters.AddWithValue("@Title", title_box.Text);
                    cmd.Parameters.AddWithValue("@Description", description_box.Text);
                    cmd.Parameters.AddWithValue("@Duedate", duedate_picker.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", status_box.Text);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                    title_box.Text = "";
                    description_box.Text = "";
                    status_box.Text = "";
                    display_task();
                    MessageBox.Show("Task added successfully");
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Tak ID cannot be empty !");
            }
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
            taskGridView.DataSource = dtable;
            connection.Close();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            display_task();
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if ("" != id_box.Text)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "DELETE FROM [Table] WHERE Taskid = @Taskid";
                    cmd.Parameters.AddWithValue("@Taskid", id_box.Text);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                    title_box.Text = "";
                    description_box.Text = "";
                    status_box.Text = "";
                    display_task();
                    MessageBox.Show("Task deleted successfully");
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                    connection.Close();
                }
            }
            else
            {
               MessageBox.Show("Task ID cannot be empty !");
            }
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if ("" != id_box.Text)
            {
                try
                {
                    connection.Open();
                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = "UPDATE [Table] SET Title = @Title, Description = @Description, Duedate = @Duedate, Status = @Status WHERE Taskid = @Taskid";

                    cmd.Parameters.AddWithValue("@Taskid", id_box.Text);
                    cmd.Parameters.AddWithValue("@Title", title_box.Text);
                    cmd.Parameters.AddWithValue("@Description", description_box.Text);
                    cmd.Parameters.AddWithValue("@Duedate", duedate_picker.Value.Date);
                    cmd.Parameters.AddWithValue("@Status", status_box.Text);

                    cmd.ExecuteNonQuery();
                    connection.Close();
                    title_box.Text = "";
                    description_box.Text = "";
                    status_box.Text = "";
                    display_task();
                    MessageBox.Show("Task added successfully");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Tak ID cannot be empty !");
            }
        }

        private void logout_button2_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            this.Hide();
            login.Show();
        }
    }
}

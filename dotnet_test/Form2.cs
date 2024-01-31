using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_test
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        task_management_form taskForm = new task_management_form();
        Task_list taskList = new Task_list();

        private void login_button_Click(object sender, EventArgs e)
        {
            
            if("admin" == usernamebox.Text && "admin" == password_box.Text)
            {
                this.Hide();
                taskForm.Show();

            }
            else
            {
                this.Hide();
                taskList.Show();
            }
        }
    }
}

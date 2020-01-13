using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARTIS_manager
{
    public partial class User_page : Form
    {
        
        public User_page()
        {
            InitializeComponent();
            
            
        }

        private void User_page_Load(object sender, EventArgs e)
        {
            UserList.DataSource = Program.ARTISLABclient.getSysAdminList(Program.token);


        
        }

        private void add_button_Click(object sender, EventArgs e)
        {



            String answer = Program.ARTISLABclient.addSysAdmin(usrname_box.Text, fName_box.Text, lName_box.Text, Program.token);
            if (answer.Equals("SUCCESS"))
            {
                alert1.Visible = true;
                timer.Start();
            }
            else
            {
                err1.Visible = true;
                timer.Start();
            }

            fName_box.Text = "";
            lName_box.Text = "";
            usrname_box.Text = "";

            UserList.DataSource = Program.ARTISLABclient.getSysAdminList(Program.token);
            
        }

        private void delete_button_Click(object sender, EventArgs e)
        {

            DialogResult result;
            string question = "Are you sure you want to DELETE this ADMIN user?";
            string title = "DELETE ADMIN";
            result = MessageBox.Show(question, title, MessageBoxButtons.YesNo); if (result == DialogResult.Yes)
            {
                String answer = Program.ARTISLABclient.deleteUser(usrname_box.Text, Program.token);
                if (answer.Equals("SUCCESS"))
                {
                    alert2.Visible = true;
                    timer.Start();
                }
                else
                {
                    err2.Visible = true;
                    timer.Start();
                }


                fName_box.Text = "";
                lName_box.Text = "";
                usrname_box.Text = "";
            }

            UserList.DataSource = Program.ARTISLABclient.getSysAdminList(Program.token);


           
            

        }

        private void UserList_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void UserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string userNamePass = UserList.CurrentRow.Cells[0].Value.ToString();

            Users_form user_inst = new Users_form(userNamePass);
            user_inst.Show();
        }

        private void UserList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                UserList.CurrentCell = UserList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userNamePass = UserList.CurrentRow.Cells[0].Value.ToString();

            Users_form user_inst = new Users_form(userNamePass);
            user_inst.Show();
        }

        private void sunsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ARTISref.User dude = Program.ARTISLABclient.getUser(UserList.CurrentRow.Cells[0].Value.ToString(), Program.token);
            dude.status = "Sunset";
            dude.sunsetdate = System.DateTime.Now;

            Program.ARTISLABclient.saveUser(dude, Program.token);

            UserList.DataSource = Program.ARTISLABclient.getSysAdminList(Program.token);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string question = "Are you sure you want to DELETE this ADMIN user?";
            string title = "DELETE ADMIN";
            result = MessageBox.Show(question, title, MessageBoxButtons.YesNo); if (result == DialogResult.Yes)
            {
                Program.ARTISLABclient.deleteUser(UserList.CurrentRow.Cells[0].Value.ToString(), Program.token);
                fName_box.Text = "";
                lName_box.Text = "";
                usrname_box.Text = "";
            }

            UserList.DataSource = Program.ARTISLABclient.getSysAdminList(Program.token);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            alert1.Visible = false;
            alert2.Visible = false;
            err1.Visible = false;
            err2.Visible = false;
        }

        private void User_page_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

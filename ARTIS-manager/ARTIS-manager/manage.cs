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
    public partial class manage_form : Form
    {
        public manage_form()
        {
            InitializeComponent();
        }

        private void manage_form_Load(object sender, EventArgs e)
        {
            manageList.DataSource = Program.ARTISLABclient.searchUsers(typeDropDown.Text, statusDropDown.Text, /*search.Text*/"Bstark", Convert.ToInt32(Math.Round(numDaysInactive.Value, 0)), Convert.ToInt32(Math.Round(daysusedin90.Value, 0)), Program.token);
            typeDropDown.DataSource = Program.ARTISLABclient.getUserTypeList();
            typeDropDown.DisplayMember = "UserType";
            typeDropDown.ValueMember = "UserType";

            statusDropDown.DataSource = Program.ARTISLABclient.getUserStatusList();
            statusDropDown.DisplayMember = "Status";
            statusDropDown.ValueMember = "Status";
        }

        private void typeDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            manageList.DataSource = Program.ARTISLABclient.searchUsers(typeDropDown.Text, statusDropDown.Text, search.Text, Convert.ToInt32(Math.Round(numDaysInactive.Value, 0)), Convert.ToInt32(Math.Round(daysusedin90.Value, 0)), Program.token);
        }

        private void statusDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            manageList.DataSource = Program.ARTISLABclient.searchUsers(typeDropDown.Text, statusDropDown.Text, search.Text, Convert.ToInt32(Math.Round(numDaysInactive.Value, 0)), Convert.ToInt32(Math.Round(daysusedin90.Value, 0)), Program.token);
        }

        private void daysusedin90_ValueChanged(object sender, EventArgs e)
        {
            manageList.DataSource = Program.ARTISLABclient.searchUsers(typeDropDown.Text, statusDropDown.Text, search.Text, Convert.ToInt32(Math.Round(numDaysInactive.Value, 0)), Convert.ToInt32(Math.Round(daysusedin90.Value, 0)), Program.token);
        }

        private void numDaysInactive_ValueChanged(object sender, EventArgs e)
        {
            manageList.DataSource = Program.ARTISLABclient.searchUsers(typeDropDown.Text, statusDropDown.Text, search.Text, Convert.ToInt32(Math.Round(numDaysInactive.Value, 0)), Convert.ToInt32(Math.Round(daysusedin90.Value, 0)), Program.token);
        }

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            manageList.DataSource = Program.ARTISLABclient.searchUsers(typeDropDown.Text, statusDropDown.Text, search.Text, Convert.ToInt32(Math.Round(numDaysInactive.Value, 0)), Convert.ToInt32(Math.Round(daysusedin90.Value, 0)), Program.token);
        }

        private void manageList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string userNamePass = manageList.CurrentRow.Cells[0].Value.ToString();

            Users_form user_inst = new Users_form(userNamePass);
            user_inst.Show();
        }

        private void sunset_Click(object sender, EventArgs e)
        {

            



            //manageList.SelectedRows.Clear();
            ARTISref.User dude;

            DialogResult result;
            string question = "Are you sure you want to Sunset the displayed Users?";
            string title = "Sunset User";
            result = MessageBox.Show(question, title, MessageBoxButtons.YesNo); if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow r in manageList.Rows)
                {
                    dude = Program.ARTISLABclient.getUser(manageList.CurrentRow.Cells[0].Value.ToString(), Program.token);
                    dude.status = "Sunset";
                    dude.sunsetdate = System.DateTime.Now;

                    String answer =Program.ARTISLABclient.saveUser(dude, Program.token);

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
                }

                manageList.DataSource = Program.ARTISLABclient.searchUsers(typeDropDown.Text, statusDropDown.Text, search.Text, Convert.ToInt32(Math.Round(numDaysInactive.Value, 0)), Convert.ToInt32(Math.Round(daysusedin90.Value, 0)), Program.token);
            }
        }

        private void sunset_retire_button_Click(object sender, EventArgs e)
        {
            String answer= Program.ARTISLABclient.sunsetRetiredUsers(typeDropDown.Text, 7, Program.token);

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

            manageList.DataSource = Program.ARTISLABclient.searchUsers(typeDropDown.Text, statusDropDown.Text, search.Text, Convert.ToInt32(Math.Round(numDaysInactive.Value, 0)), Convert.ToInt32(Math.Round(daysusedin90.Value, 0)), Program.token);
        }

        private void manageList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                manageList.CurrentCell = manageList.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
        }

        private void sunsetUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ARTISref.User dude = Program.ARTISLABclient.getUser(manageList.CurrentRow.Cells[0].Value.ToString(), Program.token);
            dude.status = "Sunset";
            dude.sunsetdate = System.DateTime.Now;

            Program.ARTISLABclient.saveUser(dude, Program.token);

            manageList.DataSource = Program.ARTISLABclient.searchUsers(typeDropDown.Text, statusDropDown.Text, search.Text, Convert.ToInt32(Math.Round(numDaysInactive.Value, 0)), Convert.ToInt32(Math.Round(daysusedin90.Value, 0)), Program.token);
        }

        private void activateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ARTISref.User dude = Program.ARTISLABclient.getUser(manageList.CurrentRow.Cells[0].Value.ToString(), Program.token);
            dude.status = "Active";
            dude.sunsetdate = dude.estsunsetdate;

            Program.ARTISLABclient.saveUser(dude, Program.token);

            manageList.DataSource = Program.ARTISLABclient.searchUsers(typeDropDown.Text, statusDropDown.Text, search.Text, Convert.ToInt32(Math.Round(numDaysInactive.Value, 0)), Convert.ToInt32(Math.Round(daysusedin90.Value, 0)), Program.token);

        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string userNamePass = manageList.CurrentRow.Cells[0].Value.ToString();

            Users_form user_inst = new Users_form(userNamePass);
            user_inst.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            alert1.Visible = false;
            alert2.Visible = false;
            err1.Visible = false;
            err2.Visible = false;
        }

        private void manage_form_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

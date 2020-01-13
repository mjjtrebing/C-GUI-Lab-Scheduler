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
    public partial class Users_form : Form
    {
        String encap;
        public Users_form(String user)
        {
            InitializeComponent();
            encap = user;
        }

        private void Users_form_Load(object sender, EventArgs e)
        {
            ARTISref.User dude= Program.ARTISLABclient.getUser(encap, Program.token);



            if (dude.usertype != null)
            {
                //createdate = dude.createdate;
                if (dude.usertype.Equals("Student"))
                {
                    student_rad.Checked = true;
                    facstaff_rad.Checked = false;
                }
                if (dude.usertype.Equals("FacStaff"))
                {
                    facstaff_rad.Checked = true;
                    student_rad.Checked = false;
                }
            }
            user_Box.Text = dude.username;
            sunsetStatus.Text = dude.status;
            notes_Box.Text = dude.notes;
            userName_Box.Text = dude.username;
            fName_Box.Text = dude.firstname;
            lName_Box.Text = dude.lastname;
            if (dude.createdate.ToString() != null)
            {
                //createdate.Text = dude.createdate.ToString();
            }
            estDate.Text = dude.estsunsetdate.ToString();
            Sunset_datepick.Text = dude.sunsetdate.ToString();


            privUsesTable.DataSource = dude.PrivUseSet;
            pastReservTable.DataSource = dude.PastReservations;
            futurereservTable.DataSource = dude.FutureReservations;

            futurereservTable.Visible = false;
            pastReservTable.Visible = false;
            privUsesTable.Visible = true;
        }

        private void privilegesetButton_Click(object sender, EventArgs e)
        {
            futurereservTable.Visible = false;
            pastReservTable.Visible = false;
            privUsesTable.Visible = true;

            //privilegesetButton.BackColor = Color.Navy;
        }

        private void pastReservButton_Click(object sender, EventArgs e)
        {
            futurereservTable.Visible = false;
            pastReservTable.Visible = true;
            privUsesTable.Visible = false;
        }

        private void futureReserveButton_Click(object sender, EventArgs e)
        {
            futurereservTable.Visible = true;
            pastReservTable.Visible = false;
            privUsesTable.Visible = false;

        }

        private void save_button_Click(object sender, EventArgs e)
        {


            Program.ARTISLABclient.deleteUser(encap, Program.token); //this may be wrong
            String sting = "";
            if (student_rad.Checked == true)
            {
                sting = "Student";
            }
            else
            {
                sting = "FacStaff";
            }


            ARTISref.User dude = Program.ARTISLABclient.addNewUser(user_Box.Text, sting, Program.token);
            dude.username = user_Box.Text;
            dude.firstname = fName_Box.Text;
            dude.lastname = lName_Box.Text;
            dude.notes = notes_Box.Text;
            dude.status = "Active";



            String answer = Program.ARTISLABclient.saveUser(dude, Program.token);
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



            if (dude.usertype.Equals("Student"))
            {
                student_rad.Checked = true;
                facstaff_rad.Checked = false;
            }
            if (dude.usertype.Equals("FacStaff"))
            {
                facstaff_rad.Checked = true;
                student_rad.Checked = false;
            }
            sunsetStatus.Text = dude.status;
            notes_Box.Text = dude.notes;
            userName_Box.Text = dude.username;
            fName_Box.Text = dude.firstname;
            lName_Box.Text = dude.lastname;
            if (dude.createdate.ToString() != null)
            {
                //createdate.Text = dude.createdate.ToString();
            }
            estDate.Text = dude.estsunsetdate.ToString();
            Sunset_datepick.Text = dude.sunsetdate.ToString();

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string question = "Are you sure you want to DELETE this User?";
            string title = "DELETE User";
            result = MessageBox.Show(question, title, MessageBoxButtons.YesNo); if (result == DialogResult.Yes)
            {
                String answer = Program.ARTISLABclient.deleteUser(user_Box.Text, Program.token);

                if (answer.Equals("SUCCESS"))
                {
                    alert4.Visible = true;
                    timer.Start();
                }
                else
                {
                    err4.Visible = true;
                    timer.Start();
                }



                userName_Box.Text = "";
                user_Box.Text = "";
                fName_Box.Text = "";
                lName_Box.Text = "";
                notes_Box.Text = "";
                Sunset_datepick.Text = "";
                student_rad.Checked = true;
            }


        }

        private void sunset_button_Click(object sender, EventArgs e)
        {
            ARTISref.User dude = Program.ARTISLABclient.getUser(encap, Program.token);

            dude.sunsetdate = System.DateTime.Now;
            dude.status = "Sunset";

            String answer = Program.ARTISLABclient.saveUser(dude, Program.token);


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




            if (dude.usertype.Equals("Student"))
            {
                student_rad.Checked = true;
                facstaff_rad.Checked = false;
            }
            if (dude.usertype.Equals("FacStaff"))
            {
                facstaff_rad.Checked = true;
                student_rad.Checked = false;
            }
            sunsetStatus.Text = dude.status;
            notes_Box.Text = dude.notes;
            userName_Box.Text = dude.username;
            fName_Box.Text = dude.firstname;
            lName_Box.Text = dude.lastname;
            if (dude.createdate.ToString() != null)
            {
                //createdate.Text = dude.createdate.ToString();
            }
            estDate.Text = dude.estsunsetdate.ToString();
            Sunset_datepick.Text = dude.sunsetdate.ToString();
        }

        private void reactivate_button_Click(object sender, EventArgs e)
        {
            ARTISref.User dude = Program.ARTISLABclient.getUser(encap, Program.token);

            dude.sunsetdate = dude.estsunsetdate;
            dude.status = "Active";

            String answer = Program.ARTISLABclient.saveUser(dude, Program.token);
            if (answer.Equals("SUCCESS"))
            {
                alert3.Visible = true;
                timer.Start();
            }
            else
            {
                err3.Visible = true;
                timer.Start();
            }



            if (dude.usertype.Equals("Student"))
            {
                student_rad.Checked = true;
                facstaff_rad.Checked = false;
            }
            if (dude.usertype.Equals("FacStaff"))
            {
                facstaff_rad.Checked = true;
                student_rad.Checked = false;
            }
            sunsetStatus.Text = dude.status;
            notes_Box.Text = dude.notes;
            userName_Box.Text = dude.username;
            fName_Box.Text = dude.firstname;
            lName_Box.Text = dude.lastname;
            if (dude.createdate.ToString() != null)
            {
                //createdate.Text = dude.createdate.ToString();
            }
            estDate.Text = dude.estsunsetdate.ToString();
            Sunset_datepick.Text = dude.sunsetdate.ToString();
        }

        private void Find_User_Click(object sender, EventArgs e)
        {
            ARTISref.User dude = Program.ARTISLABclient.getUser(user_Box.Text, Program.token);

            if (dude.usertype != null)
            {
                alert5.Visible = true;
                timer.Start();
                if (dude.usertype.Equals("Student"))
                {
                    student_rad.Checked = true;
                    facstaff_rad.Checked = false;
                }
                if (dude.usertype.Equals("FacStaff"))
                {
                    facstaff_rad.Checked = true;
                    student_rad.Checked = false;
                }
                sunsetStatus.Text = dude.status;
                notes_Box.Text = dude.notes;
                userName_Box.Text = dude.username;
                fName_Box.Text = dude.firstname;
                lName_Box.Text = dude.lastname;
                if (dude.createdate.ToString() != null)
                {
                    //createdate.Text = dude.createdate.ToString();
                }
                estDate.Text = dude.estsunsetdate.ToString();
                Sunset_datepick.Text = dude.sunsetdate.ToString();
            }
            else
            {
                err5.Visible = true;
                timer.Start();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            alert1.Visible = false;
            alert2.Visible = false;
            alert3.Visible = false;
            alert4.Visible = false;
            alert5.Visible = false;
            err1.Visible = false;
            err2.Visible = false;
            err3.Visible = false;
            err4.Visible = false;
            err5.Visible = false;


        }

        private void Users_form_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}

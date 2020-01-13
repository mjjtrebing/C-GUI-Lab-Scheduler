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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
           Program.token = Program.ARTISLABclient.logIn(usr.Text, pwd.Text);//program.token is now global in program.cs so it can be referenced everywhere. need it for all methods.
            //now nothing needs to be passed to other form.
            
            
            
            //lbl.Text = Program.token;
            if(Program.token.Equals("ERROR:DENIED") || Program.token.Equals("ERROR:DBMS FAILURE") || Program.token.Equals("ERROR: Invalid Credentials")) //ERROR: Invalid Credentials
            {
                //do nothing
                alert.Visible = true;
            }
            else
            {
                alert.Visible = false;
               this.Close();
            }
        }

        private void pwd_Enter(object sender, EventArgs e)
        {
            Program.token = Program.ARTISLABclient.logIn(usr.Text, pwd.Text);//program.token is now global in program.cs so it can be referenced everywhere. need it for all methods.
                                                                            //now nothing needs to be passed to other form.



            //lbl.Text = token;
            if (Program.token.Equals("ERROR:DENIED") || Program.token.Equals("ERROR:DBMS FAILURE") || Program.token.Equals("ERROR: Invalid Credentials")) //ERROR: Invalid Credentials
            {
                //do nothing
            }
            else
            {
                this.Close();
            }
        }

        private void usr_Enter(object sender, EventArgs e)
        {
            Program.token = Program.ARTISLABclient.logIn(usr.Text, pwd.Text);//program.token is now global in program.cs so it can be referenced everywhere. need it for all methods.
                                                                            //now nothing needs to be passed to other form.



            //lbl.Text = token;
            if (Program.token.Equals("ERROR:DENIED") || Program.token.Equals("ERROR:DBMS FAILURE") || Program.token.Equals("ERROR: Invalid Credentials")) //ERROR: Invalid Credentials
            {
                //do nothing
            }
            else
            {
                this.Close();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();//kills the running program
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

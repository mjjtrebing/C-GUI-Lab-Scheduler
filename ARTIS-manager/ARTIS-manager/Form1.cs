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
    public partial class Landing : Form
    {
        public Landing()
        {
            InitializeComponent();
        }

        private void Landing_Load(object sender, EventArgs e)
        {
            Login log = new Login();
            log.ShowDialog();

            if(Program.token.Equals("ERROR: Invalid Credentials"))
            {
                
                System.Windows.Forms.Application.ExitThread();
            }


            //Dropdown.DataSource = Program.ARTISLABclient.getUserList("Student","Active",Program.token);


            heavy_Use_List.DataSource = Program.ARTISLABclient.getResourceUsage(Program.token);


        }

        private void users_button_Click(object sender, EventArgs e)
        {
            //User_page usr_inst = new User_page();
            //usr_inst.Show();
            Users_form usr_inst = new Users_form("");
            usr_inst.Show();
        }

        private void manage_button_Click(object sender, EventArgs e)
        {
            manage_form mng_inst = new manage_form();
            mng_inst.Show();
        }

        private void sunset_button_Click(object sender, EventArgs e)
        {
            //Sunset sun_inst = new Sunset();
            //sun_inst.Show();
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            Program.ARTISLABclient.sysLogOut(Program.token);
            System.Windows.Forms.Application.ExitThread();



            //method to intercept users ability to close form, in ther do secure user logout
            //"called form.close or something"
           
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            User_page admin_inst = new User_page(); //this is actually the admin page but I cant figure out how to change the name without killing my program
            admin_inst.Show();
        }

        private void Landing_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.ARTISLABclient.sysLogOut(Program.token);
            System.Windows.Forms.Application.ExitThread();
        }
    }
}

//*********************************************************************
//Programmer:Lachlan Ashton
//CIT Number: 214233
//Date: 08/10/2019
//Software: Microsoft Visual Studio Community 2019
//Platform: Microsoft Windows 10 Professional 64‐bit
//Purpose: Allows a user to be created and then entered into an list, the user can then view that information.
//*********************************************************************


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssessmentTwoApplication
{
    public partial class AddUserForm : Form
    {
        private const int ARRAY_SIZE = 5; //constate value for the array size
        private NewUser[] userData = new NewUser[ARRAY_SIZE];
        private int index = 0; //index of the array to add next user
        public AddUserForm()
        {
            InitializeComponent();
        }

      class NewUser //inner class start
        {
            private string FirstName;
            private string LastName;
            private int Age;

            public NewUser(string fname, string lname, int age)
            {
                FirstName = fname;
                LastName = lname;
                Age = age;
            }

            public string GetFirstName()
            {
                return FirstName;
            }

            public string GetLastName()
            {
                return LastName;
            }

            public int GetAge()
            {
                return Age;
            }

            public string ToString() //overriding the main tostring
            {
                return FirstName + " " + LastName;
            }


        }//inner class end

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (index < ARRAY_SIZE)// prevent more data being added to the list and array after index matches the same size as the max array size
            {
                try
                {
                    NewUser user1 = new NewUser(txtFirstName.Text, txtLastName.Text, int.Parse(txtAge.Text)); //create a new user
                    userData[index] = user1;    //add user to the current index of the array
                    lstUsers.Items.Clear(); //Clear Data in list so that is doesnt duplicate
                }
                catch (Exception) //if user enters information incorrectly in any way shape or form
                {
                    MessageBox.Show("Please make sure you enter information into fields correctly!");
                }
                    
                foreach (var user in userData) //add each user in the array to the list
                {
                    if (user != null)
                        lstUsers.Items.Add(user.ToString());
                }
                lstUsers.Refresh(); //Refresh to update list with new items
                index++; //add next item to the next index
            }
            else
                MessageBox.Show("List is full, you cannot add any new users");
 
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e) //show all user information in the information box when that index is selected
        {
            int i = 0;
            i = lstUsers.SelectedIndex;
            lblInfomationOut.Text =  "First Name: " + userData[i].GetFirstName() + ", Last Name: " + userData[i].GetLastName() + ", Age: " + userData[i].GetAge();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

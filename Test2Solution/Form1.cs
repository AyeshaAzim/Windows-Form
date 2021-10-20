using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2Solution
{
    public partial class frmPeople : Form
    {
        People currentPeople = new People();
        
        public frmPeople()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string mobileType;

            if (radApple.Checked)
            {
                mobileType = "Apple";
            }
            else if (radAndroid.Checked)
            {
                mobileType = "Android";
            }
            else
            {
                mobileType = "None";
            }
            if (txtFirstName.Text.Trim() == "" || txtLastName.Text.Trim() =="")
            {
                MessageBox.Show("First Name and Last Name cannot be empty!");
                return;
            }

            try
            {
                dgvPeople.Rows.Add(txtFirstName.Text, txtLastName.Text, numAge.Value, mobileType);
                Person newPerson = new Person
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Age = Convert.ToInt32(numAge.Value),
                    MobileType = (MobileType)Enum.Parse(typeof(MobileType), mobileType, true),
                };

                currentPeople.Add(newPerson);
                RefreshCountLabel();
                ClearForm();
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message);
            }  
        }

        private void radShowAllUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (radShowAllUsers.Checked)
            {
                dgvPeople.Rows.Clear();


                foreach (Person personAll in currentPeople.GetAllPeople())
                {
                    dgvPeople.Rows.Add(personAll.FirstName, personAll.LastName, personAll.Age, personAll.MobileType);
                }

                RefreshCountLabel();
            }
        }

        private void radShowAppleUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (radShowAppleUsers.Checked)
            {
                dgvPeople.Rows.Clear();

                foreach (Person personApple in currentPeople.GetApplePeople())
                {
                    dgvPeople.Rows.Add(personApple.FirstName, personApple.LastName, personApple.Age, personApple.MobileType);
                }
                RefreshCountLabel();
            }
        }

        private void radShowAndroidUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (radShowAndroidUsers.Checked)
            {
                dgvPeople.Rows.Clear();

                foreach (Person personAndroid in currentPeople.GetAndroidPeople())
                {
                    dgvPeople.Rows.Add(personAndroid.FirstName, personAndroid.LastName, personAndroid.Age, personAndroid.MobileType);
                }
                RefreshCountLabel();
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            dgvPeople.Rows.Clear();
            currentPeople._people.Clear();
            RefreshCountLabel();
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RefreshCountLabel()
        {
            lblTotalPeople.Text = $"Total People : {currentPeople._people.Count.ToString()}";
            lblVisiblePeople.Text = $"Visible People : {dgvPeople.Rows.Count.ToString()}";
        }
        public void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            radAndroid.Checked = false;
            radApple.Checked = false;
            numAge.Value = 0;
        }
      
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class GroupStudents : Form
    {
        public GroupStudents()
        {
            InitializeComponent();
        }

        private void GroupStudents_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button1 was clicked");
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            DialogResult formGroup = MessageBox.Show("Do you want to form the group ?", "Hello", MessageBoxButtons.YesNo); 
            
            switch (formGroup)
            {
                case DialogResult.Yes:
                    {
                        this.Text = "[YES]";
                        break;
                    }
                case DialogResult.No:
                    {
                        this.Text = "[NO]";
                        Application.Exit();
                        break;
                    }
            }
            if (formGroup == DialogResult.Yes) {

                this.Hide();
                
                ChooseNumber myChooseForm = new ChooseNumber();
                myChooseForm.Show();
                //myChooseForm;
                


            }
            
        }
    }
}

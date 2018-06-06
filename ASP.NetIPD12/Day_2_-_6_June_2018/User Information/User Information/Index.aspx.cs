using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace User_Information
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            Page.SetFocus(txtName);
        }

        /*
         * Drop down menu for province
         * used to populate the city drop down menu.
         * upon change on index, clear city list and generate a new list
         */
        protected void ddlProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlCity.Items.Clear();
            string choice = ddlProvince.SelectedValue.ToString();
            switch (choice)
            {
                case "Quebec":
                    ddlCity.Items.Add("Please select a city");
                    ddlCity.Items.Add("Montreal");
                    ddlCity.Items.Add("Quebec");
                    ddlCity.Items.Add("Laval");
                    break;
                case "Ontario":
                    ddlCity.Items.Add("Please select a city");
                    ddlCity.Items.Add("Ottawa");
                    ddlCity.Items.Add("Toronoto");
                    break;
                case "BC":
                    ddlCity.Items.Add("Please select a city");
                    ddlCity.Items.Add("Vancouver");
                    ddlCity.Items.Add("Victoria");
                    break;
                default:
                    break;
            }
        }

        /* Submit button handler
         * Reads from form and writes into label.
         */
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if(Page.IsValid)
            {
                String record =
                txtName.Text + " | " +
                txtDOB.Text + " | " +
                txtEmail.Text + " | " +
                ddlProvince.SelectedValue.ToString() + " | " +
                ddlCity.SelectedValue.ToString();

                lbRecords.Items.Add(record);

                lblRecord.Text = "New record add succesfully..Number of records is: " + updateCounter();
                clearForm();
            }
            
        }

        /*Clear function
         * clear all data in the form
         */
         private void clearForm()
        {
            txtName.Text = string.Empty;
            txtDOB.Text = string.Empty;
            txtEmail.Text = string.Empty;
            ddlProvince.ClearSelection();
            ddlCity.Items.Clear();
        }

        /*update hidden value html control
         */
         private int updateCounter()
        {
            int counter = int.Parse(hidVal.Value.ToString());
            counter++;
            hidVal.Value = counter.ToString();
            return counter;
        }
    }
}
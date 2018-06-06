using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Investment_Calculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;


            for (int i = 50; i <= 500; i+=50)
            {
                ddlInvest.Items.Add(i.ToString());
            }

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            int years = int.Parse(txtYears.Text);
            decimal yearlyInterestRate = decimal.Parse(txtRate.Text);
            int monthlyInvestment = int.Parse(ddlInvest.SelectedValue);

            decimal interest = CalculateValue(monthlyInvestment, yearlyInterestRate, years);

            lblResult.Text =
                "Hello.. " + txtName.Text +
                "\n" + "The investment will be = " + interest.ToString(".00");
        }

        protected decimal CalculateValue(int monthlyInvestment, decimal yearlyInterestRate, int years)
        {
            int months = years * 12;
            decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
            decimal futureValue = 0;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            ddlInvest.ClearSelection();
            txtRate.Text = string.Empty;
            txtYears.Text = string.Empty;
            txtName.Focus(); 
        }
    }
}
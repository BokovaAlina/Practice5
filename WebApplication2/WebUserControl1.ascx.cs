using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Add_Click(object sender, EventArgs e)
        {
            Double f1 = Convert.ToDouble(TextBox1.Text);
            Double s2 = Convert.ToDouble(TextBox2.Text);
            Double res = f1 + s2;

            Result.Text = Convert.ToString(res);
        }

        protected void Sub_Click(object sender, EventArgs e)
        {
            Double f1 = Convert.ToDouble(TextBox1.Text);
            Double s2 = Convert.ToDouble(TextBox2.Text);
            Double res = f1 - s2;

            Result.Text = Convert.ToString(res);
        }

        protected void Mult_Click(object sender, EventArgs e)
        {
            Double f1 = Convert.ToDouble(TextBox1.Text);
            Double s2 = Convert.ToDouble(TextBox2.Text);
            double res = f1 * s2;

            Result.Text = Convert.ToString(res);
        }

        protected void Div_Click(object sender, EventArgs e)
        {
            Double f1 = Convert.ToDouble(TextBox1.Text);
            Double s2 = Convert.ToDouble(TextBox2.Text);
            Double res = f1 / s2;

            Result.Text = Convert.ToString(res);
        }
    }
}
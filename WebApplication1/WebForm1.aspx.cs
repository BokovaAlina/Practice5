using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        { 
            DataSet Source = (DataSet)Cache["thisCache"];
            if (Source == null)
            {
                ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
                Source = client.GetCustomers();
                Cache["thisCache"] = Source;
                Label1.Text = "НАБОР ДАННЫХ, СОЗДАННЫЙ ИЗ ТАБЛИЦЫ";

            }
            else
            {
                Label1.Text = "НАБОР ДАННЫХ, СОЗДАННЫЙ ИЗ ТАБЛИЦЫ";
            }
            GridView1.DataSource = Source;
            GridView1.DataBind();
          
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
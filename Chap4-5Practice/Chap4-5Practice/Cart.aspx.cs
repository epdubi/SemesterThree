using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chap4_5Practice
{
	public partial class Cart : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
		
			double total = Convert.ToDouble(Session["total"]);
			//total += Convert.ToDouble(Session["price"]);

			if (Session["price"] != null)
			{
				
				total += Convert.ToDouble(Session["price"]);
				Label1.Text = total.ToString("C");
				Session["total"] = total;
			}
			
		}
	}
}
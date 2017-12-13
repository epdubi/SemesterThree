using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Chap4_5Practice
{
	public partial class Master : System.Web.UI.Page
	{
		public string Total;

		protected void Page_Load(object sender, EventArgs e)
		{

			if (!IsPostBack)
			{
				DropDownList1.DataBind();
			}
			

			DataView product = (DataView)SqlDataSource1.Select(DataSourceSelectArguments.Empty);
			product.RowFilter = string.Format("ProductID = '{0}'", DropDownList1.SelectedValue);
			DataRowView row = product[0];

			Label1.Text = row["Name"].ToString();
			//Label2.Text = row["ImageFile"].ToString();
			Image1.ImageUrl = string.Format("Images/{0}", row["ImageFile"]);
			//Image1.ImageUrl = "Images/arm1.jpg";
			Session["price"] = row["UnitPrice"].ToString();

		}

		protected void Add_Click(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				Session["total"] = 0;
			}
		}

		protected void Checkout_Click(object sender, EventArgs e)
		{

		}
	}
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FredsIceCreamShop
{
	public partial class Form1 : Form
	{
		private double _totalPrice = 0;

		public Form1()
		{
			InitializeComponent();
		}

		private void burgerCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (sundaeCheckBox.Checked)
			{
				sprinklesCheckBox.Enabled = true;
				nutsCheckBox.Enabled = true;
				choclateCheckBox.Enabled = true;
				sprinklesCheckBox.BackColor = Color.LightBlue;
				nutsCheckBox.BackColor = Color.LightBlue;
				choclateCheckBox.BackColor = Color.LightBlue;
			}
			else
			{
				sprinklesCheckBox.Enabled = false;
				nutsCheckBox.Enabled = false;
				choclateCheckBox.Enabled = false;
				sprinklesCheckBox.BackColor = Color.Transparent;
				nutsCheckBox.BackColor = Color.Transparent;
				choclateCheckBox.BackColor = Color.Transparent;
			}
		}

		private void drinkCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (sodaCheckBox.Checked)
			{
				mangoCheckBox.Enabled = true;
				limeCheckBox.Enabled = true;
				peachCheckBox.Enabled = true;
				mangoCheckBox.BackColor = Color.LightBlue;
				limeCheckBox.BackColor = Color.LightBlue;
				peachCheckBox.BackColor = Color.LightBlue;

			}
			else
			{
				mangoCheckBox.Enabled = false;
				limeCheckBox.Enabled = false;
				peachCheckBox.Enabled = false;
				mangoCheckBox.BackColor = Color.Transparent;
				limeCheckBox.BackColor = Color.Transparent;
				peachCheckBox.BackColor = Color.Transparent;
			}
		}

		private void addButton_Click(object sender, EventArgs e)
		{
			Order order;

			string name = nameTextBox.Text;
			bool hasSundae = false;
			bool hasSoda = false;

			if (sundaeCheckBox.Checked)
			{
				hasSundae = true;
			}
			if (sodaCheckBox.Checked)
			{
				hasSoda = true;
			}

			try
			{
				order = new Order(name, hasSundae, hasSoda);
				nameErrorLabel.Text = "";
			}
			catch (NameMissing ex)
			{

				nameErrorLabel.Text = ex.Message;
				return;
			}
			catch (NoFood ex)
			{

				nameErrorLabel.Text = ex.Message;
				return;
			}


			try
			{
				if (sprinklesCheckBox.Checked)
				{
					order.Sundae.AddTopping(SundaeTopping.SPRINKLES);
				}
				if (nutsCheckBox.Checked)
				{
					order.Sundae.AddTopping(SundaeTopping.NUTS);
				}
				if (choclateCheckBox.Checked)
				{
					order.Sundae.AddTopping(SundaeTopping.CHOCLATE_SYRUP);
				}
				sundaeErrorLabel.Text = "";
			}
			catch (TooManyToppings ex)
			{

				sundaeErrorLabel.Text = ex.Message;
				return;
			}


			try
			{
				if (mangoCheckBox.Checked)
				{
					order.Soda.AddFlavor(SodaFlavor.LIME);
				}
				if (limeCheckBox.Checked)
				{
					order.Soda.AddFlavor(SodaFlavor.PEACH);
				}
				if (peachCheckBox.Checked)
				{
					order.Soda.AddFlavor(SodaFlavor.MANGO);
				}
				sodaErrorLabel.Text = "";
			}
			catch (TooManyFlavors ex)
			{

				sodaErrorLabel.Text = ex.Message;
			}

			//for (int i = 0; i < 3; i++)
			//{
			//	receiptTextBox.Lines = new string[] { order.ToString() };
			//}

			receiptTextBox.Text = order.ToString();
			_totalPrice += order.Price;
			priceLabel.Text = string.Format("Total: {0:C}", _totalPrice);

			nameTextBox.Text = "";
			sundaeCheckBox.Checked = false;
			sprinklesCheckBox.Checked = false;
			nutsCheckBox.Checked = false;
			choclateCheckBox.Checked = false;
			sodaCheckBox.Checked = false;
			mangoCheckBox.Checked = false;
			limeCheckBox.Checked = false;
			peachCheckBox.Checked = false;


		}
	}
}

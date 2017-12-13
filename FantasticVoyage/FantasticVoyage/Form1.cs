using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FantasticVoyage
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			pictureBox2.ImageLocation = @"C:\Users\epdub\source\repos\FantasticVoyage\FantasticVoyage\Images\bahamasPic.jpg";
			
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			pictureBox2.ImageLocation = @"C:\Users\epdub\source\repos\FantasticVoyage\FantasticVoyage\Images\parisPic.jpg";
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			pictureBox2.ImageLocation = @"C:\Users\epdub\source\repos\FantasticVoyage\FantasticVoyage\Images\italyPic.png";
		}

		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			pictureBox2.ImageLocation = @"C:\Users\epdub\source\repos\FantasticVoyage\FantasticVoyage\Images\floridaPic.jpeg";
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string img;
			string total;
			string location;
			string firstName;
			 string lastName;
			 string email;
			 string confirmEmail;

			if (radioButton1.Checked == true)
			{
				location = radioButton1.Text;
				total = "$1,899.00";
				img = @"C:\Users\epdub\source\repos\FantasticVoyage\FantasticVoyage\Images\bahamasPic.jpg";
			}
			else if (radioButton2.Checked == true)
			{
				location = radioButton2.Text;
				total = "$1,999.00";
				img = @"C:\Users\epdub\source\repos\FantasticVoyage\FantasticVoyage\Images\parisPic.jpg";
			}
			else if (radioButton3.Checked == true)
			{
				location = radioButton3.Text;
				total = "$1,799.00";
				img = @"C:\Users\epdub\source\repos\FantasticVoyage\FantasticVoyage\Images\italyPic.png";
			}
			else if (radioButton4.Checked == true)
			{
				location = radioButton4.Text;
				total = "$1,200.00";
				img = @"C:\Users\epdub\source\repos\FantasticVoyage\FantasticVoyage\Images\floridaPic.jpeg";
			}
			else
			{
				location = "";
				total = "";
				img = "";
			}

			try
				{
				
				firstName = textBox1.Text;
				lastName = textBox2.Text;
				email = textBox3.Text;
				confirmEmail = textBox4.Text;
				FinalOrder order = new FinalOrder(firstName, lastName, email, confirmEmail);

				// Specify a "currently active folder" 
				string activeDir = @"C:\Users\epdub\Desktop";

				//Create a new subfolder under the current active folder 
				string newPath = System.IO.Path.Combine(activeDir, "Receipts");

				// Create the subfolder
				System.IO.Directory.CreateDirectory(newPath);

				// Create a new file name. This example generates 
				// a random string. 
				string newFileName = firstName + lastName + ".html";

				// Combine the new file name with the path
				newPath = System.IO.Path.Combine(newPath, newFileName);

				using (FileStream fs = new FileStream(newPath, FileMode.Create))
				{
					using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
					{
						w.WriteLine("<H1>Fantastic Voyage Travel Agency</H1>");
						w.WriteLine("<H4>Destination: {0}</H4>", location);
						w.WriteLine("<H4>Quote: {0}</H4>", total);
						w.WriteLine("<img src={0} height=200 width=200", img);
						w.WriteLine("<H4></H4>");
						w.WriteLine("<H4>{0} {1}</H4>", firstName, lastName);
						w.WriteLine("<H4>{0}</H4>", email);




					}
				}


			}
			catch (NoFirstNameExcetion ex)
				{
				errorLabel1.Visible = true;
				errorLabel1.Text = ex.ShowMessage();
				}
				catch (NoLastNameException noLastName)
				{
				errorLabel2.Visible = true;
				errorLabel2.Text = noLastName.ShowMessage();
				}
				catch (NoEmailExceptioncs noEmail)
				{
				errorLabel3.Visible = true;
				errorLabel3.Text = noEmail.ShowMessage();
				}
				catch (NoConfirmEmailException noConfirm)
				{
				errorLabel4.Visible = true;
				errorLabel4.Text = noConfirm.ShowMessage();
				}
				catch (EmailMatchException noMatch)
				{
				ErrorLabel5.Visible = true;
				ErrorLabel5.Text = noMatch.ShowMessage();
				}
			



		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{
				button1.Enabled = true;
			}
		}
	}
}

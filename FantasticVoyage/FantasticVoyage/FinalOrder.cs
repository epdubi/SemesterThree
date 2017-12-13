using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticVoyage
{
	class FinalOrder
	{
		//private string _location;
		private string _firstName;
		private string _lastName;
		private string _email;
		private string _confirmEmail;

		public string Location { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string ConfirmEmail { get; set; }

		public FinalOrder(string b, string c, string d, string e)
		{
			_firstName = b;
			_lastName = c;
			_email = d;
			_confirmEmail = e;

			//if (_location == null)
			//{
			//	throw;
			//}
			if (_firstName == "")
			{
				NoFirstNameExcetion ex = new NoFirstNameExcetion("Please Enter First Name");
				throw ex;
			}
			if (_lastName == "")
			{
				NoLastNameException noLastName = new NoLastNameException("Please Enter Last Name");
				throw noLastName;
			}
			if (_email == "")
			{
				NoEmailExceptioncs noEmail = new NoEmailExceptioncs("Please Enter Email");
				throw noEmail;
			}
			if (_confirmEmail == "")
			{
				NoConfirmEmailException noConfirm = new NoConfirmEmailException("Please Confirm Email");
				throw noConfirm;
			}
			if (_email != _confirmEmail)
			{
				EmailMatchException noMatch = new EmailMatchException("Please Match Your Emails");
				throw noMatch;
			}
		}
	}
}

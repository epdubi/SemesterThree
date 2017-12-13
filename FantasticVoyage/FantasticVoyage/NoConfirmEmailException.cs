using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticVoyage
{
	class NoConfirmEmailException : Exception
	{
		string ErrorMessage;

		public NoConfirmEmailException(string message) : base(message)
		{
			ErrorMessage = message;

		}

		public string ShowMessage()
		{
			return Message;
		}
	}
}

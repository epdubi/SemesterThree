using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticVoyage
{
	class NoLastNameException : Exception
	{
		string ErrorMessage;

		public NoLastNameException(string message) : base(message)
		{
			ErrorMessage = message;

		}

		public string ShowMessage()
		{
			return Message;
		}
	}
}

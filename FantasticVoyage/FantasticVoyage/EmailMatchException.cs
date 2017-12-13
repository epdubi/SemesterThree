using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasticVoyage
{
	class EmailMatchException : Exception
	{
		string ErrorMessage;

		public EmailMatchException(string message) : base(message)
		{
			ErrorMessage = message;

		}

		public string ShowMessage()
		{
			return Message;
		}
	}
}

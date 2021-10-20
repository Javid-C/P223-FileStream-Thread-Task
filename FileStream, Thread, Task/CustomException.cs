using System;
using System.Collections.Generic;
using System.Text;

namespace FileStream__Thread__Task
{
	class CustomException:Exception
	{
		private string _message;
		public override string Message => _message;

		public CustomException(string message)
		{
			_message = message;
		}
	}
}

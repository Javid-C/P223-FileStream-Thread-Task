using System;
using System.Collections.Generic;
using System.Text;

namespace FileStream__Thread__Task
{
	class User
	{
		public string Email { get; set; }
		public string Password { get; set; }

		public User(string email, string pw)
		{
			if (pw.Length < 8)
			{
				throw new CustomException("You have to use minimum 8 character");
			}
			for (int i = 0; i < email.Length; i++)
			{
				if(email[i] == '@')
				{
					break;
				}
				if(i == email.Length - 1)
				{
					throw new CustomException("Please enter @ symbol");
				}
			}
		}
	}
}

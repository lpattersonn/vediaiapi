using System;

namespace vediaiapi.Models
{
 public class IntervieweeAccountModel
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public string Email { get; set; }

		public string Password { get; set; }

		public string Bio { get; set; }

		public DateTime Date { get; set; }
	}
}
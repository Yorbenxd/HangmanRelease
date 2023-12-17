﻿using System.ComponentModel.DataAnnotations;

namespace Hangman
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
	}
}
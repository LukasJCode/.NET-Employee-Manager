﻿using EmployeeManagement.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.ViewModels
{
	public class EmployeeCreateViewModel
	{
		[Required]
		[MaxLength(50)]
		public string Name { get; set; }
		[Required]
		[RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
			ErrorMessage = "Invalid Email Format")]
		[Display(Name = "Office Email")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Please Select A Department")]
		public Dept? Department { get; set; }
		public IFormFile Photo { get; set; }
	}
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLib
{
	public class VaatimuspohjaDTO
	{
		public int Idvaatimuspohja { get; set; }

		public string? Kuvaus { get; set; }

		public string? Pakollisuus { get; set; }

		public int Idauditointipohja { get; set; }

		public string? AuditointipohjaSelite { get; set; }

	}
}

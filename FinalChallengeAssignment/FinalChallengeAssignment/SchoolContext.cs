﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalChallengeAssignment
{
	internal class SchoolContext : DbContext
	{
		public SchoolContext() : base()
		{

		}
		public DbSet<Student> Students { get; set; }
		public DbSet<Grade> Grades { get; set; }
	}
}

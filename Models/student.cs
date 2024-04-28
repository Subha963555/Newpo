using System;
using System.ComponentModel.DataAnnotations;


namespace newPo.Models
{
	public class student
	{
        [StringLength(2)]
		public string? name { get; set; }
        public int age { get; set; }
        public int reg { get; set; }
        [EmailAddress]
        public string? home { get; set; }
        public Gender gender { get; set; }

    }
    public enum Gender
    {
        male,female

    }
}


using System;
namespace assignment7.Entites
{
	public class AverageGPA
	{
		public decimal Averages { get; set; }

		public string departments { get; set; }

		public AverageGPA()
		{
		}

        public AverageGPA(decimal averages, string departments)
        {
            Averages = averages;
            this.departments = departments;
        }
    }
}


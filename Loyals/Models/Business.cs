using System;
namespace Loyals.Models
{
    public class Business
    {
		public Business(string name, DateTime lastVisit)
		{
			this.Name = name;
			this.LastVisit = lastVisit;
		}

		public string Name 
        //Name is a type of 'String'
        { 
            private set; 
            get; 
        }

		public DateTime LastVisit { private set; get; }
        //LastVisit is a type of DateTime
    }
}

using System;
namespace Loyals.Models
{
    public class Business
    {
        private string v;
        private DateTime dateTime;

        public Business(string v, DateTime dateTime)
        {
            this.v = v;
            this.dateTime = dateTime;
        }

        public Business(string name, DateTime lastVisit, int totalPoints)
		{
			this.Name = name;
			this.LastVisit = lastVisit;
            this.TotalPoints = totalPoints;
		}

		public string Name 
        //Name is a TYPE of 'String'
        { 
            private set; 
            get; 
        }

		public DateTime LastVisit 
        { 
            private set; 
            get; 
        }
        //LastVisit is a type of DateTime

        public int TotalPoints
        {
            private set;
            get;
        }
    }
}

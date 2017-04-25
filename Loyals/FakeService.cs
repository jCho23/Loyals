using System;
using System.Collections.Generic;
namespace Loyals
{
	public static class FakeService
	{
		public static List<RewardsStore> GetStores()
		{
			return new List<RewardsStore>
			{
				new RewardsStore("Zing Cafe","Sandwich Shop","http://www.berkeleyside.com/wp-content/uploads/2015/01/Screen-shot-2015-01-30-at-11.46.51-AM.png","https://s3-media4.fl.yelpcdn.com/bphoto/mf1sJ9FdZpYqWUvnQuoAnQ/258s.jpg")
			};
		}
	}
}

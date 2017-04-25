using System;
namespace Loyals
{
	public class RewardsStore
	{
		public RewardsStore()
		{
		}

		public RewardsStore(string name, string description, string backgroundsImage, string storeIcon)
		{
			StoreName = name;
			StoreDescriptor = description;
			StoreBackgroundImage = backgroundsImage;
			StoreIconImage = storeIcon;
		}

		public string StoreName { get; set;}
		public string StoreDescriptor { get; set;}
		public string StoreBackgroundImage { get; set;}
		public string StoreIconImage { get; set;}
	}
}

using System;
using System.Collections.Generic;

namespace Setsuna
{
	class Info
	{
		private static Info mThis;

		private Info() { }

		public static Info Instance()
		{
			if (mThis == null)
			{
				mThis = new Info();
				mThis.Init();
			}
			return mThis;
		}

		public NameValueInfo Search<Type>(List<Type> list, uint id)
			where Type : NameValueInfo, new()
		{
			int min = 0;
			int max = list.Count;
			for (; min < max;)
			{
				int mid = (min + max) / 2;
				if (list[mid].Value == id) return list[mid];
				else if (list[mid].Value > id) max = mid;
				else min = mid + 1;
			}
			return null;
		}

		private void Init()
		{
		}
	}
}

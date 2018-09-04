using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setsuna
{
	class Member
	{
		private readonly uint mAddress;

		public Member(uint address)
		{
			mAddress = address;
		}

		public uint ID
		{
			get { return SaveData.Instance().ReadNumber(mAddress, 4); }
			set { SaveData.Instance().WriteNumber(mAddress, 4, value); }
		}
	}
}

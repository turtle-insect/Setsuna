using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setsuna
{
	class Charactor
	{
		public Charactor(uint address, String name)
		{
			mAddress = address;
			Name = name;
		}
		private readonly uint mAddress;

		public String Name { get; private set; }
		public uint Lv
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 12, 1); }
			set { Util.WriteNumber(mAddress + 12, 1, value, 1, 99); }
		}

		public uint Exp
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 82, 4); }
			set { Util.WriteNumber(mAddress + 82, 4, value, 0, 9999999); }
		}

		public uint HP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 20, 2); }
			set { Util.WriteNumber(mAddress + 20, 2, value, 0, 999); }
		}

		public uint MP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 24, 2); }
			set { Util.WriteNumber(mAddress + 24, 2, value, 0, 999); }
		}

		public uint MaxHP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 8, 2); }
			set { Util.WriteNumber(mAddress + 8, 2, value, 1, 999); }
		}

		public uint MaxMP
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 14, 2); }
			set { Util.WriteNumber(mAddress + 14, 2, value, 1, 999); }
		}

		public uint Attack
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 16, 2); }
			set { Util.WriteNumber(mAddress + 16, 2, value, 1, 999); }
		}

		public uint Magic
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 18, 2); }
			set { Util.WriteNumber(mAddress + 18, 2, value, 1, 999); }
		}
	}
}

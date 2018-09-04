using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Setsuna
{
	class Item : INotifyPropertyChanged
	{
		private readonly uint mAddress;
		public event PropertyChangedEventHandler PropertyChanged;

		public Item(uint address)
		{
			mAddress = address;
		}

		public uint Key
		{
			get { return SaveData.Instance().ReadNumber(mAddress, 2); }
			private set { }
		}

		public uint Count
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 2, 2); }
			set
			{
				Util.WriteNumber(mAddress + 2, 2, value, 0, 1000);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Count)));
			}
		}

		public uint ID
		{
			get { return SaveData.Instance().ReadNumber(mAddress + 4, 2); }
			set
			{
				SaveData.Instance().WriteNumber(mAddress + 4, 2, value);
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ID)));
			}
		}
	}
}

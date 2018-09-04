using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Setsuna
{
	class DataContext
	{
		public Info Info { get; set; } = Info.Instance();
		public ObservableCollection<Charactor> Charactors { get; set; } = new ObservableCollection<Charactor>();
		public ObservableCollection<Item> Items { get; set; } = new ObservableCollection<Item>();
		public ObservableCollection<Member> PartyMembers { get; set; } = new ObservableCollection<Member>();
		public ObservableCollection<Member> BattleMembers { get; set; } = new ObservableCollection<Member>();

		public DataContext()
		{
			foreach (var item in Info.Instance().Chars)
			{
				if (item.Value == 0) continue;
				Charactors.Add(new Charactor(0x72FDA + 86 * (uint)(item.Value - 1), item.Name));
			}

			for (uint i = 0; i < 0x1000; i++)
			{
				Items.Add(new Item(0xF21A + i * 97));
			}

			for (uint i = 0; i < 7; i++)
			{
				PartyMembers.Add(new Member(0x73234 + i * 4));
			}
			for (uint i = 0; i < 3; i++)
			{
				BattleMembers.Add(new Member(0x73250 + i * 4));
			}
		}

		public uint Money
		{
			get { return SaveData.Instance().ReadNumber(204, 4); }
			set { Util.WriteNumber(204, 4, value, 0, 9999999); }
		}
	}
}

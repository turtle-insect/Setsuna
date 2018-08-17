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
		public ObservableCollection<Charactor> Charactors { get; set; } = new ObservableCollection<Charactor>();

		public DataContext()
		{
			String[] names = { "エンド" };

			foreach (var item in names.Select((name, index) => (name, index)))
			{
				Charactors.Add(new Charactor(0x72FDA + 86 * (uint)item.index, item.name));
			}
		}
	}
}

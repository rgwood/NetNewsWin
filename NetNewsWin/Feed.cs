using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetNewsWin
{
    public class Feed
    {
        public string Name { get; private set; }
        public ObservableCollection<Entry> Entries { get; private set; } = new ObservableCollection<Entry>();

        public Feed(string name)
        {
            Name = name;
        }

        public Feed(string name, IEnumerable<Entry> entries) : this(name)
        {
            Entries = new ObservableCollection<Entry>(entries);
        }
    }
}

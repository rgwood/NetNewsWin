using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace NetNewsWin
{
    public class Feed : INotifyPropertyChanged
    {
        public string Name { get; private set; }
        public ObservableCollection<Entry> Entries { get; private set; } = new ObservableCollection<Entry>();

        public int UnreadCount => Entries.Count(e => e.Unread);

        public Feed(string name, IEnumerable<Entry> entries)
        {
            Name = name;
            Entries = new ObservableCollection<Entry>(entries);

            foreach (var entry in Entries)
            {
                entry.PropertyChanged += Entry_PropertyChanged;
            }

            Entries.CollectionChanged += Entries_CollectionChanged;
        }

        private void Entries_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.OldItems != null)
            {
                foreach (INotifyPropertyChanged entry in e.OldItems)
                    entry.PropertyChanged -= Entry_PropertyChanged;
            }
            if (e.NewItems != null)
            {
                foreach (INotifyPropertyChanged entry in e.NewItems)
                    entry.PropertyChanged += Entry_PropertyChanged;
            }
        }

        private void Entry_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(Entry.Unread))
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UnreadCount)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}

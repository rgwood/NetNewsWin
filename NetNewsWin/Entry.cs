using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NetNewsWin
{
    public class Entry : INotifyPropertyChanged
    {
        private bool unread = true;

        public Entry(string title, string author, string content)
        {
            Title = title;
            Author = author;
            Content = content;
        }

        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Content { get; private set; }

        public bool Unread
        {
            get => unread;
            set
            {
                unread = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetNewsWin
{
    public class Entry
    {
        public Entry(string title, string author, string content)
        {
            Title = title;
            Author = author;
            Content = content;
        }

        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Content { get; private set; }

        public bool Unread { get; set; } = true;
    }
}

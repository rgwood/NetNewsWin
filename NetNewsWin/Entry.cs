using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetNewsWin
{
    public class Entry
    {
        public Entry(int feedId, string title, string author, string content)
        {
            FeedId = feedId;
            Title = title;
            Author = author;
            Content = content;
        }

        public int FeedId { get; private set; }
        public string Title { get; private set; }
        public string Author { get; private set; }
        public string Content { get; private set; }
    }
}

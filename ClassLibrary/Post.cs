using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Post
    {
        public readonly string _Title;
        public readonly string _Description;
        public readonly DateTime _CreationDate;
        private int _UpVotes { get; set; }
        private int _DownVotes { get; set; }
        public int UpVotes
        {
            get { return _UpVotes; }
        }
        public int DownVotes
        {
            get { return _DownVotes; }
        }
        public int Votes
        {
            get { return _UpVotes - _DownVotes; }
        }

        public Post(string title, string description)
        {
            _Title = title;
            _Description = description;
            _CreationDate = DateTime.Now;
            _UpVotes = 0;
            _DownVotes = 0;
        }

        public void UpVote()
        {
            _UpVotes++;
        }

        public void DownVote()
        {
            _DownVotes++;
        }

    }
}

using System;
using System.Collections.Generic;

namespace ArtributeCreate
{
    [AttributeUsage(AttributeTargets.Class)]
    public class InfoAttribute:Attribute
    {

        public string Author { get; private set; }
        public int Revision { get; private set; }
        public string Description { get; private set; }
        public List<string> Reviewers { get; set; }

        public InfoAttribute(string author,int revision,
            string desctiption,params string[] reviewers)
        {
            Author = author;
            Revision = revision;
            Description = desctiption;
            Reviewers = new List<string>(reviewers);
        }

    }
}

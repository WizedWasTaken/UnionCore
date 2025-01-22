using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionCore.Entities
{
    public class Event
    {
        #region Fields

        private Guid eventId;
        private string title;
        private string content;
        private Member creator;

        #endregion

        #region Properties

        public Guid EventId
        {
            get { return eventId; }
            set { eventId = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public Member Creator
        {
            get { return creator; }
            set { creator = value; }
        }

        #endregion

        #region Constructors

        public Event()
        {
            EventId = Guid.NewGuid();
        }

        public Event(string title, string content, Member creator)
        {
            EventId = Guid.NewGuid();
            Title = title;
            Content = content;
            Creator = creator;
        }

        public Event(Guid eventId, string title, string content, Member creator)
        {
            EventId = eventId;
            Title = title;
            Content = content;
            Creator = creator;
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionCore.Entities
{
    /// <summary>
    /// Represents an article entity with an ID, title, content, creation date, and creator.
    /// </summary>
    public class Article
    {
        #region Fields

        private Guid articleId;
        private string title;
        private string content;
        private DateTime dateCreated;
        private Member creator;

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the unique identifier for the article.
        /// </summary>
        public Guid ArticleId
        {
            get { return articleId; }
            set { articleId = value; }
        }

        /// <summary>
        /// Gets or sets the title of the article.
        /// </summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        /// <summary>
        /// Gets or sets the content of the article.
        /// </summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        /// <summary>
        /// Gets or sets the date the article was created.
        /// </summary>
        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }

        /// <summary>
        /// Gets or sets the creator of the article.
        /// </summary>
        public Member Creator
        {
            get { return creator; }
            set { creator = value; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="Article"/> class with a new unique identifier.
        /// </summary>
        public Article()
        {
            ArticleId = Guid.NewGuid();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Article"/> class with the specified title, content, and creator.
        /// </summary>
        /// <param name="title">The title of the article.</param>
        /// <param name="content">The content of the article.</param>
        /// <param name="creator">The creator of the article.</param>
        public Article(string title, string content, Member creator)
            : this()
        {
            Title = title;
            Content = content;
            Creator = creator;
            DateCreated = DateTime.Now;
        }

        #endregion
    }
}

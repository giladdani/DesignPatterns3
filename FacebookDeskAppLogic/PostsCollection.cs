using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookDeskAppLogic
{
    public class PostsCollection : IEnumerable<Post>
    {
        // Private Members
        private FacebookObjectCollection<Post> m_Posts;
        IteratorType m_IteratorType;

        public enum IteratorType
        {
            COMMENTS,
            LIKES,
            ALL
        }

        // Constructor
        public PostsCollection(User i_User)
        {
            m_Posts = i_User.Posts;
        }

        // Public Methods
        public IEnumerator<Post> GetEnumerator()
        {
            return new PostsIterator(this, IteratorType.ALL, null);
        }

        public IEnumerator<Post> GetEnumerator(IteratorType i_IteratorType, IStrategy i_Strategy)
        {
            return new PostsIterator(this, i_IteratorType, i_Strategy);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PostsIterator(this, IteratorType.ALL, null);
        }

        // Iterator class
        private class PostsIterator : IEnumerator<Post>
        {
            // Private Members
            private int m_CurrentPostIdx;
            private readonly IteratorType m_IteratorType;
            private readonly IStrategy m_FilterStrategy;
            private PostsCollection m_PostsCollection;

            // Constructor
            public PostsIterator(PostsCollection i_PostsCollection, IteratorType i_IteratorType, IStrategy i_Strategy)
            {
                m_PostsCollection = i_PostsCollection;
                m_IteratorType = i_IteratorType;
                m_FilterStrategy = i_Strategy;
            }

            // Public Methods
            public Post Current
            {
                get { return m_PostsCollection.m_Posts[m_CurrentPostIdx]; }
            }

            object IEnumerator.Current
            {
                get { return Current; }
            }

            public void Dispose()
            {
                Reset();
            }

            public bool MoveNext()
            {
                Post currentPost;
                int count;
                
                m_CurrentPostIdx++;

                if(m_IteratorType == IteratorType.ALL)
                {
                    if(m_CurrentPostIdx < m_PostsCollection.m_Posts.Count)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                while (m_CurrentPostIdx < m_PostsCollection.m_Posts.Count)
                {
                    currentPost = m_PostsCollection.m_Posts[m_CurrentPostIdx];
                    count = countByIteratorType(m_PostsCollection.m_IteratorType, currentPost);
                    if (m_FilterStrategy.TestNumber(count))
                    {
                        return true;
                    }
                    else
                    {
                        m_CurrentPostIdx++;
                    }
                }

                return false;
            }

            public void Reset()
            {
                m_CurrentPostIdx = -1;
            }

            // Private Methods
            private int countByIteratorType(IteratorType i_IteratorType, Post i_Post)
            {
                int count = 0;
                switch(i_IteratorType)
                {
                    case IteratorType.COMMENTS:
                        count = i_Post.Comments.Count;
                        break;
                    case IteratorType.LIKES:
                        count = i_Post.LikedBy.Count;
                        break;
                }

                return count;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FacebookDeskAppLogic
{
    public class PostsCollection : IEnumerable<Post>
    {
        // Private Members
        private FacebookObjectCollection<Post> m_Posts;

        public enum eIteratorType
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
            return new PostsIterator(this, eIteratorType.ALL, null);
        }

        public IEnumerator<Post> GetEnumerator(eIteratorType i_IteratorType, IStrategy i_Strategy)
        {
            return new PostsIterator(this, i_IteratorType, i_Strategy);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PostsIterator(this, eIteratorType.ALL, null);
        }

        // Iterator class
        private class PostsIterator : IEnumerator<Post>
        {
            // Private Members
            private readonly eIteratorType m_IteratorType;
            private readonly IStrategy m_FilterStrategy;
            private int m_CurrentPostIdx;
            private PostsCollection m_PostsCollection;

            // Constructor
            public PostsIterator(PostsCollection i_PostsCollection, eIteratorType i_IteratorType, IStrategy i_Strategy)
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

           /* public bool MoveNext()
            {
                Post currentPost;
                int count;
                bool isValid = false;
                m_CurrentPostIdx++;

                if(m_IteratorType == eIteratorType.ALL)
                {
                    if(m_CurrentPostIdx < m_PostsCollection.m_Posts.Count)
                    {
                        isValid = true;
                    }
                }
                else
                {
                    while (m_CurrentPostIdx < m_PostsCollection.m_Posts.Count)
                    {
                        currentPost = m_PostsCollection.m_Posts[m_CurrentPostIdx];
                        count = countByIteratorType(m_IteratorType, currentPost);
                        if (m_FilterStrategy.TestNumber(count))
                        {
                            isValid = true;
                            break;
                        }
                        else
                        {
                            m_CurrentPostIdx++;
                        }
                    }
                }

                return isValid;
            }*/

            public bool MoveNext()
            {
                Post currentPost;
                int count;
                bool isValid = false;

                m_CurrentPostIdx++;

                if (m_CurrentPostIdx < m_PostsCollection.m_Posts.Count)
                {
                    if (m_IteratorType == eIteratorType.ALL)
                    {
                        isValid = true;
                    }
                    else
                    {
                        currentPost = m_PostsCollection.m_Posts[m_CurrentPostIdx];
                        count = countByIteratorType(m_IteratorType, currentPost);
                        if (m_FilterStrategy.TestNumber(count))
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = MoveNext();
                        }
                    }
                }

                return isValid;
            }


            public void Reset()
            {
                m_CurrentPostIdx = -1;
            }

            // Private Methods
            private int countByIteratorType(eIteratorType i_IteratorType, Post i_Post)
            {
                try
                {
                    int count = 0;
                    switch(i_IteratorType)
                    {
                        case eIteratorType.COMMENTS:
                            count = i_Post.Comments.Count;
                            break;
                        case eIteratorType.LIKES:
                            count = i_Post.LikedBy.Count;
                            break;
                    }

                    return count;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}

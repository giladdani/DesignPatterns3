using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookDeskAppLogic
{
    class PostsCollection : IEnumerable<Post>
    {
        // Private Members
        private List<Post> m_Posts;
        private PostsIterator m_PostsIterator;

        // Constructor
        public PostsCollection(List<Post> i_Posts)
        {
            m_Posts = i_Posts;
        }

        public IEnumerator<Post> GetEnumerator()
        {
            return m_PostsIterator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return m_PostsIterator;
        }

        // Iterator class
        private class PostsIterator : IEnumerator<Post>
        {
            public Post Current
            {
                get
                {
                    return m_posts[]
                }
            }

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}

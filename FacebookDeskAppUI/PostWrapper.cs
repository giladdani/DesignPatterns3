using FacebookWrapper.ObjectModel;

namespace FacebookDeskAppUI
{
    public class PostWrapper
    {
        // Constructors
        public PostWrapper(Post i_Post)
        {
            Post = i_Post;
        }

        // Public Methods
        public override string ToString()
        {
            if(string.IsNullOrEmpty(Post.Name))
            {
                return string.Format("Unnamed Post");
            }
            else
            {
                return Post.Name;
            }
        }

        // Properties
        public Post Post { get; set; }
    }
}

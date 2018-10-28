using System.Collections.Generic;

namespace Lab3
{
    internal class Publisher
    {
        private readonly List<Post> _posts = new List<Post>();

        public void SubscribePost(Post post) => _posts.Add(post);

        public void Publish()
        {
            foreach (var post in _posts)
                post.Receive();
        }
    }
}
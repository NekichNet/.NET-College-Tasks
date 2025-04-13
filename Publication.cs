using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public class Publication
    {
        private int id_;
        private int likes_;
        private int dislikes_;
        private string message_;

        public Publication(int id, string message)
        {
            id_ = id;
            message_ = message;
            likes_ = 0;
            dislikes_ = 0;
        }

        public static Publication operator +(Publication post, int likes)
        {
            post.likes_ += likes;
            return post;
        }

        public static Publication operator -(Publication post, int dislikes)
        {
            post.dislikes_ += dislikes;
            return post;
        }

        public static Publication operator ++(Publication post)
        {
            post.likes_ += 1;
            return post;
        }

        public static Publication operator --(Publication  post)
        {
            post.dislikes_ += 1;
            return post;
        }

        public override string ToString()
        {
            return $"Post ID: {id_}, Likes: {likes_}, Dislikes: {dislikes_}, Message: {message_}";
        }

        public int getLikes() { return likes_; }
        public int getDislikes() { return dislikes_; }
    }

}

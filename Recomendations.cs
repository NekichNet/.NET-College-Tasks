using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_02_25
{
    public static class Recomendations
    {
        public static bool CheckPost(Publication post)
        {
            return post.getLikes() >= 2 * post.getDislikes();
        }
    }
}

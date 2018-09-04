using System;

namespace EventsBlog
{
    class Program
    {
        static void Main(string[] args)
        {
            Blogger blogger = new Blogger();
            User user1 = new User("Adam", blogger);
            User user2 = new User("Barbara", blogger);
            User user3 = new User("Cezary", blogger);

            BloggerEventArgs bloggerArgs = new BloggerEventArgs("Episode 1", 180);
            blogger.OnNewVideoBlog(bloggerArgs);
            bloggerArgs = new BloggerEventArgs("Episode 2", 200);
            blogger.OnNewVideoBlog(bloggerArgs);

            Console.Read();
        }
    }
}

using System;

namespace EventsBlog
{
    class User
    {
        public string Name { get; private set; }
        public User (string name, Blogger blogger)
        {
            Name = name;
            blogger.NewVideoBlog += Blogger_NewVideoBlog;
        }

        private void Blogger_NewVideoBlog(object sender, EventArgs e)
        {
            if (e is BloggerEventArgs)
            {
                BloggerEventArgs bloggerEventArgs = e as BloggerEventArgs;
                Console.WriteLine("User {0}, new Episode form Blogger!", Name);
                Console.WriteLine("Title {0}", bloggerEventArgs.Title);
                Console.WriteLine("Duration of the Episode {0}", bloggerEventArgs.DurationInSecond);
                Console.WriteLine();
            }
        }
    }
}

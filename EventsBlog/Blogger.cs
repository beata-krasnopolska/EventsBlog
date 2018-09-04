using System;

namespace EventsBlog
{
    class Blogger
    {
        public event EventHandler NewVideoBlog;
        public void OnNewVideoBlog(BloggerEventArgs e)
        {
            EventHandler newVideoBlog = NewVideoBlog;
                if (newVideoBlog != null)
                newVideoBlog(this, e);            
        }
    }
    class BloggerEventArgs : EventArgs
    {
        //Title
        public string Title {get; private set;}
        //Duration time of VideoBlog
        public int DurationInSecond { get; private set; }

        public BloggerEventArgs (string title, int durationInSecond)
        {
            Title = title;
            DurationInSecond = durationInSecond;
        }
    }
}

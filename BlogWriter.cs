using System;

public class BlogWriter : Writer, Vlogger, BodyBuilder
{

    public BlogWriter(string FirstName, string LastName) : base(FirstName, LastName)
    {
    }

    public override void Write()
    {
        Console.WriteLine(string.Format("{0}. I have my own blog. Currently, I am working on my new article about the best burgers I have ever made. Usually, I don't have much time for my blog, but I try to update it at least once a week.", this.AuthorBio));
    }

    public void Vlog()
    {
        Console.WriteLine("I also make vlogs about my daily life. Check it out on my YouTube channel called EnjoyYourLife.");
    }

    public void Workout()
    {
        Console.WriteLine("Workout is one of my biggest passion in my life.");
    }

}

using System;

public class BookWriter : Writer, Vlogger
{

    public BookWriter(string FirstName, string LastName) : base(FirstName, LastName)
    {
    }

    public override void Write()
    {
        Console.WriteLine(string.Format("{0}. I am a book writer. Currently, I am working on my new book called I fucked your mom. Usually, I write my book at night, when everybody sleeps, so I am not distracted by the noise.", this.AuthorBio));
    }

    public void Vlog()
    {
        Console.WriteLine("I also make vlogs about my daily life. Check it out on my YouTube channel called SuperRobert.");
    }

}
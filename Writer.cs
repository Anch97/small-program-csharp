using System;

public abstract class Writer  
{
    private string _firstName;
    private string _lastName;

    public string AuthorBio{

        get
        {
            return string.Format("My name is {0} {1}", this._firstName, this._lastName);
        }
    }

    public Writer(string FirstName, string LastName)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
    }

    public abstract void Write();
    
}


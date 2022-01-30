using System;

public class XSClubPromoter : Promoter, Vlogger, BodyBuilder
{

    public XSClubPromoter(string FirstName, string LastName, long Cellphone): base(FirstName, LastName, Cellphone)
    {
    }

    protected override void Share()
    {
        Console.WriteLine("I share with my instagram followers");
    }
    protected override void Ads()
    {
        Console.WriteLine("I use Facebook ads");
    }

    public void Vlog()
    {
        Console.WriteLine("I use a super camera for vlogging");
    }

    public void Workout()
    {
        Console.WriteLine("I do calisthenics");
    }
}
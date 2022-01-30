using System;

public class OmniaClubPromoter : Promoter
{

    public OmniaClubPromoter(string FirstName, string LastName, long Cellphone): base(FirstName, LastName, Cellphone)
    {
    }

    protected override void Share()
    {
        Console.WriteLine("I share with my friends");
    }
    protected override void Ads()
    {
        Console.WriteLine("I use Google AdWrods");
    }

}

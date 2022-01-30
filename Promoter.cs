using System;

public abstract class Promoter
{
    private string _firstName;
    private string _lastName;
    private long _cellPhone;

    public string MyBusinessCard{

        get
        {
            return string.Format("{0} {1} {2}", this._firstName, this._lastName, this._cellPhone);
        }
    }

    public Promoter(string FirstName, string LastName, long Cellphone)
    {
        this._firstName = FirstName;
        this._lastName = LastName;
        this._cellPhone = Cellphone;
    }

    public void Promote()
    {
        this.Share();
        this.Ads();
    }

    protected abstract void Share();
    protected abstract void Ads();

}
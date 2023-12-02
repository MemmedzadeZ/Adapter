namespace Adapter;



/*
 Sadece maraqli bir numune getirmek isdedim 
bir director interface yaradaraq her fennin  muellimini 
oz icinde cigirdim.
 ve daha sonra Adapter qaydasina reayet etdim
 
 
 */
interface IDirector
{
    void Subject();

}


class MathTeacher : IDirector
{
    public void Subject()
    {
        Console.WriteLine("Matematic ");


    }
}

class HistoryTeacher : IDirector
{
    public void Subject()
    {
        Console.WriteLine("History ");
    }
}

class GeographTeacher : IDirector
{
    public void Subject()
    {
        Console.WriteLine("GeoGraph");

    }
}

class EnglishTeacher
{ 

    public void SubjectAudi()
    {
        Console.WriteLine("English ");
    }
}

//Class Adapter
class EnglishAdapter : EnglishTeacher, IDirector
{
    public void Subject()
    {
        SubjectAudi();
    }
}


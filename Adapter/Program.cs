using Adapter;
using System.Xml;

List<IDirector> directors = new()
{
    new MathTeacher(),
    new HistoryTeacher(),
    new HistoryTeacher(),
    new GeographTeacher(),
   new EnglishAdapter()


};

foreach(var director in directors)
{
    director.Subject();
}

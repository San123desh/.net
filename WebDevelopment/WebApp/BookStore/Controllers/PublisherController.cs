using Microsoft.AspNetCore.Mvc;
public class PublisherController:Controller
{
    public IActionResult Index()
    {
        Publisher p1 = new () {Id=1, Name="Ramesh",Phone = 9856445};
        Publisher p2 = new () {Id=1, Name="Ramesh",Phone = 9856445};
        Publisher p3 = new () {Id=1, Name="Ramesh",Phone = 9856445};
        List<Publisher> publisher = [p1,p2,p3];
        return View(publisher);
    }

}
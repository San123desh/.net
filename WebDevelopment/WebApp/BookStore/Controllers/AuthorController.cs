// # THIS namespace for base class/
using BookStore.Data.Models;
// related class at related namespace, ambiguous removing
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing.Internal;

public class AuthorController : Controller
{
    BookStoreDb db = new BookStoreDb();
    public IActionResult Index()
    {
        List<Author> authors = db.Authors.ToList();
        return View(authors);
    }

    public IActionResult Add()
    {
        return View();
    }

    // attribute
    [HttpPost]
    public IActionResult Add(Author author)
    {
        db.Authors.Add(author);
        db.SaveChanges();

        return RedirectToAction("Index");
    }


    public IActionResult Edit(int Id)
    {
        Author? authors = db.Authors.Find(Id);

        // View(authors)->helps to populate the form while editing
        return View(authors);
    }

    [HttpPost]
    public IActionResult Edit(Author author)
    {
        db.Authors.Update(author);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
    // public IActionResult Delete(int Id)
    // {
    //     BookStoreDb db = new BookStoreDb();
    //     Author? author = db.Authors.Find(Id);
    //     if(author != null){
    //         db.Authors.Remove(author);
    //         db.SaveChanges();
    //     }
    //     return RedirectToAction("Index");
    // }

    public IActionResult Delete(int Id)
    {
        Author? authors = db.Authors.Find(Id);

        // View(authors)->helps to populate the form while editing
        return View(authors);
    }

    [HttpPost]
    public IActionResult Delete(Author author)
    {
        db.Authors.Remove(author);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
}
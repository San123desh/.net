// # THIS namespace for base class/
using BookStore.Data.Models;
// related class at related namespace, ambiguous removing
using Microsoft.AspNetCore.Mvc;

public class AuthorController:Controller
{
    public IActionResult Index()
    {
        // Author a1 = new () {Id = 1, Name = "Sandesh", Gender = "M"};
        // Author a2 = new () {Id = 2, Name = "Jasmin", Gender = "F"};
        // Author a3 = new () {Id = 3, Name = "Ram", Gender = "M"};
        // Author a4 = new () {Id = 4, Name = "Hari", Gender = "M"};
        Author x1 = new() {Id = 1, Name = "yrig"};
        Author x2 = new() {Id = 2, Name = "riz"};
        // List<Author> authors = [a1,a2,a3,a4];
        List<Author> authors = [x1,x2];
        return View(authors);
    }

}
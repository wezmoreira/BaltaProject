﻿using BaltaProject.ContentContext;
using System.Linq;

var articles = new List<Article>();
articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .NET", "dotnet"));

// foreach (var article in articles)
// {
//     Console.WriteLine(article.Id);
//     Console.WriteLine(article.Title);
//     Console.WriteLine(article.Url);
// }

var courses = new List<Course>();
var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");
courses.Add(courseOOP);
courses.Add(courseCsharp);
courses.Add(courseAspNet);

var careers = new List<Career>();
var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
var careerItem2 = new CareerItem(2, "Aprenda OOP", "", courseOOP);
var careerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
var careerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
careerDotnet.Items.Add(careerItem2);
careerDotnet.Items.Add(careerItem3);
careerDotnet.Items.Add(careerItem);
careers.Add(careerDotnet);



foreach (var career in careers) {
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Courses?.Title);
        //Console.WriteLine(item.Courses?.Level);

        foreach(var notification in item.Notifications)
        {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
        }

    }
}
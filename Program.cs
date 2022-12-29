using Balta.ContentContext;
using Balta.SubscriptionsContext;

var articles = new List<Article>();
articles.Add(new Article("Artigo sobre POO", "orientacao-objetos"));
articles.Add(new Article("Artigo sobre C#", "csharp"));
articles.Add(new Article("Artigo sobre .NET", "dotnet"));

/* foreach (var article in articles)
{
    Console.WriteLine(article.Id);
    Console.WriteLine(article.Title);
    Console.WriteLine(article.Url);
} */

var courses = new List<Course>();
var coursePOO = new Course("Fundamentos POO", "fundamentos-poo");
var courseCsharp = new Course("Fundamentos C#", "fundamentos-csharp");
var courseAspNet = new Course("Fundamentos .NET", "fundamentos-dotnet");

courses.Add(courseCsharp);
courses.Add(coursePOO);
courses.Add(courseAspNet);

var careers = new List<Career>();
var careerDotnet = new Career("Especialista .NET", "especialista-dotnet");
var carerItem2 = new CareerItem(2, "Aprenda OOP", "", null);
var carerItem = new CareerItem(1, "Comece por aqui", "", courseCsharp);
var carerItem3 = new CareerItem(3, "Aprenda .NET", "", courseAspNet);
careerDotnet.Items.Add(carerItem2);
careerDotnet.Items.Add(carerItem3);
careerDotnet.Items.Add(carerItem);
careers.Add(careerDotnet);

foreach (var career in careers)
{
    Console.WriteLine(career.Title);
    foreach (var item in career.Items.OrderBy(x => x.Order))
    {
        Console.WriteLine($"{item.Order} - {item.Title}");
        Console.WriteLine(item.Course?.Title);
        Console.WriteLine(item.Course?.Level);

        foreach (var notification in item.Notifications)
        {
            Console.WriteLine($"{notification.Property} - {notification.Message}");
        }
    }
}

var payPalSubscription = new PayPalSubscription();
var student = new Student();
student.CreateSubscription(payPalSubscription);
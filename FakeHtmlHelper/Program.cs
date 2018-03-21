using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FakeHtmlHelper
{
    class Program
    {
        static void Main(string[] args)
        {
            var view = new FakeViewPage<Person>();
            var propertyName = view.HtmlHelper.GetName(p => p.ID);
            Console.WriteLine(propertyName);
            propertyName = view.HtmlHelper.GetName(p => p.Name);
            Console.WriteLine(propertyName);
            propertyName = view.HtmlHelper.GetName(p => p.Age);
            Console.WriteLine(propertyName);

            Console.ReadLine();
        }
    }

    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public  int Age { get; set; }
    }

    public class FakeHtmlHelper<TModel>
    {

    }

    public class FakeViewPage<TModel>
    {
        public FakeHtmlHelper<TModel> HtmlHelper { get; set; }
        public FakeViewPage()
        {
            HtmlHelper = new FakeHtmlHelper<TModel>();
        }
    }

    public static class FakeHtmlHelperExtension
    {
        public static string GetName<TModel, TResult>(this FakeHtmlHelper<TModel> target,
            Expression<Func<TModel, TResult>> expression)
        {
            var body = expression.Body as MemberExpression;
            return body.Member.Name;
        }
    }
}

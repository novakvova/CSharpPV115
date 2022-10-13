using _9_Extention_Net;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Drawing;
using System.Data;
using System.Runtime.CompilerServices;

namespace _Extention_Net
{
    static class Program
    {
        public static void PointInfo(this MyPoint p)
        {
            Console.WriteLine("Point = {0}", p);
        }
        public static void Main(string[] args)
        {
            //DataTable dt = new DataTable();
            //dt.TableName = "Список користувачів";
            //dt.Columns.Add("Електронна пошта", typeof(string));
            //dt.Columns.Add("ПІБ", typeof(string));
            //dt.Rows.Add("ivan@gmail.com", "Іван Васильно");
            //dt.Rows.Add("peter@gmail.com", "Петро Юхим");
            //dt.Rows.Add("lena@gmail.com", "Олена Трудовик");
            //dt.AcceptChanges();
            //string fileName = "mydata.xlsx";
            //using(XLWorkbook wb = new XLWorkbook())
            //{
            //    wb.Worksheets.Add(dt);
            //    using(FileStream fs = new FileStream(fileName, FileMode.Create))
            //    {
            //        wb.SaveAs(fs);
            //    }
            //}

            MyPoint a = new MyPoint(2,4);
            MyPoint b = new MyPoint(1,2);
            MyPoint c = a + b;

            Console.WriteLine("c = {0}", c);
            c++;
            Console.WriteLine("c++ = {0}", c);
            Console.WriteLine("a>b = {0}", a>b);
            Console.WriteLine("a<b = {0}", a<b);

            Console.WriteLine("a==b = {0}", a==b);
            Console.WriteLine("a!=b = {0}", a!=b);

            a.PointInfo();
            string str = "Марина18";
            Console.WriteLine(str.Count());
        }
    }
}


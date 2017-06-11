using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, 
            //что произошла ошибка.Программа должна завершиться без ошибок
         WebRequest myWebRequest = WebRequest.Create("http://googasdascsdvcsdcle666.com");

            try { WebResponse myWebResponse = myWebRequest.GetResponse(); }
            catch (WebException err) { Console.WriteLine(err.Message); }

            //2. Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. 
            //После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
            double[] arr = new double[10];
            try { arr[10] = 5; }
            catch (IndexOutOfRangeException err) { Console.WriteLine(err.Message); }

            //3. Реализовать несколько методов или классов с методами и вызвать один метод из другого. 
            //В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.

            method1();
            void method1()
            {
                method2();
            }
            void method2()
            {
                double[] arr1 = new double[10];
                try { arr1[10] = 5; }
                catch (Exception err) { Console.WriteLine(err.TargetSite); }
            }
        }
    }
}

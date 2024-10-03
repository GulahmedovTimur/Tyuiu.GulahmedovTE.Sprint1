using Tyuiu.GulahmedovTE.Sprint1.Task3.V4.Lib;
namespace Tyuiu.GulahmedovTE.Sprint1.Task3.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Гюльахмедов Т. Э. | ИБКСб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("* Задание #3                                                               *");
            Console.WriteLine("* Вариант #4                                                               *");
            Console.WriteLine("* Выполнил: Гюльахмедов Тимур Эльманович | ИБКСб-24-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                 *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,  *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.              *");
            Console.WriteLine("*                                                                          *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");
            double priceNotebook = 2.75;
            Console.WriteLine(" Стоимость тетрадок = " + priceNotebook);
            double priceCover = 0.5;
            Console.WriteLine(" Стоимость обложек = " + priceCover);
            int quantity = 7;
            Console.WriteLine(" Количество комплектов = " + quantity);
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("****************************************************************************");
            var res = ds.PurchaseAmount(priceNotebook, priceCover, quantity);
            Math.Round(res, 3);
            double res2 = Math.Round(res, 3);
            Console.WriteLine(" Стоимость покупки = " + res2);
            Console.ReadLine();
        }
    }
}
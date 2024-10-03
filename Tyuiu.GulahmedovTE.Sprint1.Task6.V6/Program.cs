using Tyuiu.GulahmedovTE.Sprint1.Task6.V6.Lib;
namespace Tyuiu.GulahmedovTE.Sprint1.Task6.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Гюльахмедов Т. Э. | ИБКСб-24-1";
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #1                                                                *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                         *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #4                                                               *");
            Console.WriteLine("* Выполнил: Гюльахмедов Тимур Эльманович | ИБКСб-24-1                      *");
            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                          *");
            Console.WriteLine("* Напечатать все слова, удалив из них первую букву.                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str_of_user;
            Console.WriteLine("Введите вашу строку: ");
            str_of_user = Convert.ToString(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.DeleteFirstLetter(str_of_user));
        }
    }
}
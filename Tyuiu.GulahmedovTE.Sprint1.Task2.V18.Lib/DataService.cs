﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GulahmedovTE.Sprint1.Task2.V18.Lib
{
    public class DataService : ISprint1Task2V18
    {
        public int CalculateSideSquareParallelepiped(int length, int width, int height)
        {
            return 2 * height * (length + width);
        }
    }
}

﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GulahmedovTE.Sprint1.Task4.V4.Lib
{
    public class DataService : ISprint1Task4V4
    {
        public double Calculate(double x, double y)
        {
            return (1 + x * y) / (x + 2);
        }
    }
}
/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : complete streamreading and writing guide
 * 
 * ############################# */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost;
            const double PRICE_PER_3_DAYS = 2;
            const double PRICE_MORE_THAN_THREE_DAYS = 1.5;
            const double MAX_COST = 50;
            Console.WriteLine("Please enter the number of days you have the dvd for >>");
            int days = int.Parse(Console.ReadLine());


            
                if (days > 3)
            { 
                    cost = (3 * PRICE_MORE_THAN_THREE_DAYS) + (days - 3) * PRICE_MORE_THAN_THREE_DAYS;
            } 

            else 
            {
                cost = (days * PRICE_PER_3_DAYS);
            }
            if (cost > MAX_COST)
                {
                cost = MAX_COST;
            }
            Console.WriteLine("Cost = {0:c}", cost);
        }
    }
}
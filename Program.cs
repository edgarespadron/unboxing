using System;
using System.Collections.Generic;

namespace C_Sharp_Boxing_Unboxing
{
    class Program
    {
        object NewList = new List<string>();
        public static List<object> create_empty_list()
        {
            List<object> NewList = new List<object>();
            Console.WriteLine(NewList);
            return NewList;
        }
        public static List<object> add_to_list()
        {
            List<object> AddToList = create_empty_list();
            AddToList.Add(7);
            AddToList.Add(28);
            AddToList.Add(-1);
            AddToList.Add(true);
            AddToList.Add("chair");
            Console.WriteLine(AddToList);
            foreach (var entry in AddToList)
            {
                Console.WriteLine(entry);
            }
            return AddToList;
        }
        public static void List_sum_of_int()
        {
            var ListIntSum = add_to_list();
            int sum = 0;
            foreach (var x in ListIntSum)
            {
                if (x is int)
                {
                    // sum += Convert.ToInt32(x);
                    sum += (int)x;
                }
            }
            Console.WriteLine(sum);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            create_empty_list();
            add_to_list();
            List_sum_of_int();
        }
    }
}
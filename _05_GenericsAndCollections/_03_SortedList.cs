﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_GenericsAndCollections.NonGeneric
{
    class _03_SortedList
    {
        void NonGenericSortedList()
        {
            SortedList list = new SortedList();
            list.Add(1, "Hello");
            list.Add(3, "World");
            list.Add(2, "Data");
            list.Add(-10, "Computer");
            list.Add(6, "Programming");


            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list.GetByIndex(i));
            }
        }

        void GenericSortedList()
        {
            SortedList<int, string> list = new SortedList<int, string>();
            list.Add(2, "Hello");
            list.Add(3, "World");
            list.Add(1, "Ali!");
            foreach (var item in list)
            {
                Console.WriteLine(item.Value);
            }

            list.Clear();
        }
    }
}

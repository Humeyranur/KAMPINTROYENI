﻿using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            Console.WriteLine(sehirler.Count);
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");

            Console.WriteLine(sehirler.Count);



            Mylist<string> sehirler2 = new Mylist<string>();
            Console.WriteLine(sehirler2.Count);
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            

            Console.WriteLine(sehirler.Count);
        }

    class Mylist<T>
        {
            T[] _array;
            T[] _tempArray;

            public Mylist()
            {
                _array = new T[0];
            }

            public void Add (T item)
            {
                _tempArray = _array;
                _array = new T[_array.Length + 1];

                for (int i = 0; i < _tempArray.Length; i++)
                {
                    _array[i] = _tempArray[i];
                }

                _array[_array.Length - 1] = item;
            }

            public int Count
            {
                get { return _array.Length; }
            }
        }
    }
}

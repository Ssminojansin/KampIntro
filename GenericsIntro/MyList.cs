﻿using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;

        //constructor methodu

        public MyList()
        {
            items = new T[0];   
        }
        public void Add(T item)
        
        {
            //Gecici Array tanımlarız.Gecici arrayı bir önceki değer kaybolmasın diye tutarız.
            T[] tempArray =  items;
            items=new T[items.Length+1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1] = item;
        }
        public int Length 
        {
            get { return items.Length; }        
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}

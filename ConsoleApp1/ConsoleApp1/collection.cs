﻿using System;
namespace ConsoleApp1
{
    public class collection : System.Collections.CollectionBase

    {
        public void Add(Object item)
        {
            InnerList.Add(item);
        }
        public void Remove(Object item)
        {
            InnerList.Remove(item);
        }
        public new void Clear()
        {
            InnerList.Clear();
        }
        public new int Count()
        {
            return InnerList.Count;
        }
    }
}
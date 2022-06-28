using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("pesho");
            RandomList newList = new RandomList();
            newList.Add("misho");
            newList.Contains("misho");
        }
    }
}

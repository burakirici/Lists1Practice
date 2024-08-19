using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<string> guests = new List<string>();

        guests.Add("Bülent Ersoy");

        guests.Add("Ajda Pekkan");

        guests.Add("Ebru Gündeş");

        guests.Add("Hadise");

        guests.Add("Hande Yener");

        guests.Add("Tarkan");

        guests.Add("Funda Arar");

        guests.Add("Demet Akalın");

        Console.WriteLine("** Guests **");
        int sort = 1;

        foreach (string s in guests)
        {
            
            Console.WriteLine($"{sort} -  {s}");
            sort++;
        }



    }
}
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiedonTallennus
{
   class Program
   {
      static void Main(string[] args)
      {
         int lämpötila = 0;
         Console.Write("Anna usi lämpötila: ");
         string syöte = Console.ReadLine();
         lämpötila = int.Parse(syöte);

         string tiedosto = "C:\\temp\\Lämpötila.txt";
         File.WriteAllText(tiedosto, lämpötila.ToString());
         Console.WriteLine("Uusi lämpötila tallennettu.");

         Console.ReadLine();
      }
   }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            ListDictionary<string, string> listDictionary = new ListDictionary<string, string>();
            ListDictionary<int,int> listDictionaryInt = new ListDictionary<int,int>();
            //ListDictionary<byte> listDictionaryByte = new ListDictionary<byte>();

            listDictionary.addItemToDictionary("hello");
            
            Console.WriteLine(listDictionary.getItemFromDictionaryByHash(532));

            listDictionaryInt.addItemToDictionary(500);
            Console.WriteLine(listDictionaryInt.getItemFromDictionaryByHash(149));


            
            Console.ReadLine();





            //Console.WriteLine("would you like to search or add?");
            //string answer = Console.ReadLine().ToString();
            //switch (answer)
            //{
            //    case "search":
            //        //call function to search
            //        listDictionary.calculateHash(answer);
            //        break;

            //    case "add":
            //        //call function to add
            //        break;
            //}
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text; 

namespace Lab_9_4DynHTML 
{
    class Header
    {
        public const string Headeropen = "<h1>";
        public const string Headerclose = "</h1>";

        public string CreateHeader(string text)
        {
            string header = String.Concat(Headeropen, text, Headerclose, "\n");
            return header;
        }
    }

    class UnorderedList
    {
        public const string ULopen = "<ul>";
        public const string ULclose = "</ul>";

        public string CreateListItem(string text)
        {
            string open = "<li>\n";
            string close = "</li>\n";

            string listItem = String.Concat(open, text, close, "\n");
            return listItem;
        }

        public StringBuilder CreateList(string[] listItems)
        {

            StringBuilder sb = new StringBuilder();
            sb.Append(ULopen);
            foreach (string item in listItems)
            {
                sb.Append(item);
            }
            sb.Append(ULclose);

            return sb;
        }

    }




    class Program
    {
        static void Main(string[] args)
        {
            string filename = "D://Users//bearls//source//repos//9_4DynHTML//9_4DynHTML//weblogs//9_4Lab.html";
            Header header = new Header();
            UnorderedList list = new UnorderedList();
            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Enter text for HTML header.");
            string headerElement = header.CreateHeader(Console.ReadLine());
            string[] listItems = new string[3];

            for (int i = 0; i < listItems.Length; i++)
            {
                Console.WriteLine("Add another item to the list.");
                listItems[i] = list.CreateListItem(Console.ReadLine());
            }

            StringBuilder listElement = list.CreateList(listItems);
            sb.Append(headerElement);
            sb.Append(listElement.ToString());

            File.AppendAllText(filename, sb.ToString());

        }
    }
}



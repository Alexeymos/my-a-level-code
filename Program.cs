using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metods_try
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrlength = 0;
            string[] arrlib = new string[arrlength];
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========= MAINE MENU ==========");
                Console.WriteLine("= press -1- key to Admin Menu =");
                Console.WriteLine("= press -2- key to User  Menu =");
                Console.WriteLine("= press -3- key to List Books =");
                Console.WriteLine("= press -4- key to   Exit     =");
                Console.WriteLine("===============================");
                Console.WriteLine();
                Console.Write("Input number (1-4):");
                string num = Console.ReadLine();

                if (num == "1")
                {
                    adminmetod(ref arrlib);
                }
                else if (num == "2")
                {
                    usermetod();
                }
                else if (num == "4")
                {
                    break;
                }
            }
        }//Metods
        static void adminmetod(ref string[] arrlib)//ADMIN METOD
        {
            string text = "admin menu.";
            string adminpass = ("qqq");
            int adminenter = 0;
            while (true)
            {
                if (adminenter == 0)
                {
                    Console.Clear();
                    Console.WriteLine("===============================");
                    Console.WriteLine("=    Enter ADMIN PASSWORD     =");
                    Console.WriteLine("===============================");
                    string admps = Console.ReadLine();
                    if (admps != adminpass)
                    {
                        Console.WriteLine("Wrong Password");
                        continue;
                    }
                }
                adminenter = 1;
                Console.Clear();
                Console.WriteLine("========= ADMIN MENU ==========");
                Console.WriteLine("= press -1- key to Add  Books =");
                Console.WriteLine("= press -2- key to Del.  Book =");
                Console.WriteLine("= press -3- key to List Books =");
                Console.WriteLine("= press -4- key to    Exit    =");
                Console.WriteLine("===============================");
                Console.WriteLine();
                Console.Write("Input number (1-4):");
                string num = Console.ReadLine();
                if (num == "1")
                {
                    AddBook(ref arrlib);
                }
                else if (num == "3")
                {
                    ListBooks(arrlib, text);
                }
                else if (num == "4")
                {
                    break;
                }
            }
        }
        static void usermetod()//USER METOD
        {
            //string userpass = ("www");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========== USER MENU ==========");
                Console.WriteLine("= press -1- key to Add  Books =");
                Console.WriteLine("= press -2- key to Use.  Book =");
                Console.WriteLine("= press -3- key to List Books =");
                Console.WriteLine("= press -4- key to    Exit    =");
                Console.WriteLine("===============================");
                Console.WriteLine();
                Console.Write("Input number (1-4):");
                string num = Console.ReadLine();
                if (num == "1")
                {
                }
                else if (num == "4")
                {
                    break;
                }
            }
        }
        // Add book
        static void AddBook(ref string[] arrlib)
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("=          ADD BOOK           =");
            Console.WriteLine("===============================");
            Console.WriteLine();
            Console.Write("Enter book:");
            string bookname = Console.ReadLine();
            string[] arrlib1 = new string[arrlib.Length + 1];
            for (int i = 0; i < arrlib.Length; i++)
            {
                arrlib1[i] = arrlib[i];
            }
            arrlib1[arrlib1.Length - 1] = bookname;
            arrlib = arrlib1;
            Console.WriteLine();
            Console.WriteLine("Book is entered");
            Console.WriteLine("Press any key to quit the admin menu");
            Console.ReadKey();
        }
        // List of books
        static void ListBooks(string[] arrlib, string text)
        {
            Console.Clear();
            Console.WriteLine("===============================");
            Console.WriteLine("=        LIST OF BOOKS        =");
            Console.WriteLine("===============================");
            Console.WriteLine();
            for (int i = 0; i < arrlib.Length; i++)
            {
                Console.WriteLine(i + ". " + arrlib[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to quit the " + text);
            Console.ReadKey();
        }
    }
}

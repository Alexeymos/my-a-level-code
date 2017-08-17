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
            string adminpass=("qqq");
            string userpass=("www");
            int arrlength = 0;
            string[] arrlib = new string[arrlength]; 
            while (true)
            {
                Console.Clear();
                Console.WriteLine("========= MAIN MENU ==========");
                Console.WriteLine("= press -1- key to Admin Menu =");
                Console.WriteLine("= press -2- key to User  Menu =");
                Console.WriteLine("= press -3- key to List Books =");
                Console.WriteLine("= press -4- key to   Exit     =");
                Console.WriteLine("===============================");
                Console.WriteLine();
                Console.Write("Input number (1-4): ");
                string num = Console.ReadLine();

                if (num == "1")
                {
                    adminmetod();
                }
                else if(num == "2")
                    {
                    usermetod();
                    }
            }
        }//Metods
        static void adminmetod()//ADMIN METOD
        {
            int adminenter=0;
            while (true)
            {
                if(adminenter==0)
                {
                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("=    Enter ADMIN PASSWORD     =");
                Console.WriteLine("===============================");
                string admps=Console.ReadLine();
                if(admps!=adminpass)
                    {
                    Console.WriteLine("Wrong Password");
                    continue;
                    }
                }
                adminenter=1;
                Console.Clear();
                Console.WriteLine("========= ADMIN MENU ==========");
                Console.WriteLine("= press -1- key to Add  Books =");
                Console.WriteLine("= press -2- key to Del.  Book =");
                Console.WriteLine("= press -3- key to List Books =");
                Console.WriteLine("= press -4- key to    Exit    =");
                Console.WriteLine("===============================");
                Console.WriteLine();
                Console.Write("Input number (1-4): ");
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
        static void usermetod()//USER METOD
        {
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
                Console.Write("Input number (1-4): ");
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
    }
}

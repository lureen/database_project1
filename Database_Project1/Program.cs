using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Database_Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string sqlText;

            Console.WriteLine("Please input your sql query");
            sqlText = Console.ReadLine();
           SqlParse syntaxCheck = new SqlParse();
            syntaxCheck.Parse(sqlText);
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Babe.Lua.DataModel;

namespace MyLuaPraser2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string l_str = Console.ReadLine();
            //Console.WriteLine(l_str);
            string l_str = "E:\\Work\\LuaUnity\\Assets\\Lua\\View\\Intents\\AdventureIntent.lua";
            TreeParser l_parser = new TreeParser();
            l_parser.ParseFile(l_str);
            
            for (int i = 0; i < l_parser.File.Tokens.Count; i++)
            {
                var l_token = l_parser.File.Tokens[i];
                Console.WriteLine(l_token.ToString());
            }

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
            return;
        }
    }
}

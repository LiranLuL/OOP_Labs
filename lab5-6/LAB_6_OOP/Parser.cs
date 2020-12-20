using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6_OOP
{
    class Parser
    {
        public void Parse_file(Supermarket market,string path)
        {
            string[] items;
            string[] split;
            if (File.Exists(path))
            {
                items = File.ReadAllLines(path);
                Product_info info;
                foreach (string line in items)
                {
                    split = line.Split(' ');
                    info = new Product_info(int.Parse(split[1]), int.Parse(split[2]), int.Parse(split[2]));
                    market.items.Add(split[0].ToLower(), info);
                }
            }
            else
            {
                throw new Exception("Incorrect path");
            }
        }
    }
}

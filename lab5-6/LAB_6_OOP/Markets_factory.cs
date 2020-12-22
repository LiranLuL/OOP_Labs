using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_6_OOP
{
    class Markets_factory
    {
        public static Supermarket Create_market(string title, string address, int key)
        {
            if (title == "" && address == "")
            {
                switch (key)
                {
                    case 1:
                        return new Market1();
                    case 2:
                        return new Market2();
                    default:
                        throw new Exception("Не удалось создать объект");
                }
            }
            else
            {
                switch (key)
                {
                    case 1:
                        return new Market1(title, address);
                    case 2:
                        return new Market2(title, address);
                    default:
                        throw new Exception("Не удалось создать объект");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monthseason
{
    class Program
    {
        static void Main(string[] args)
        {

            int month = int.Parse(Console.ReadLine());


                switch (month)
                {
                    case 1: case 2: case 12: Console.WriteLine("winter"); break;
                    case 3: case 4: case 5: Console.WriteLine("spring"); break;
                    case 6: case 7: case 8: Console.WriteLine("summer"); break;
                    case 9: case 10: case 11: Console.WriteLine("fall"); break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다");
                    break;
                }
            }
        }
    }


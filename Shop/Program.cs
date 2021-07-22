using System;
using System.Collections.Generic;
using System.Linq;
using DAL.EF;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            ShopDBContext context = new ShopDBContext();
            context.Workers.ToArray();
        }
    }
}

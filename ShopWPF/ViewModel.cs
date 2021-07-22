using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.EF;
using DAL.Entities;
namespace ShopWPF
{
    public class ViewModel
    {
        public HashSet<Shop> Shops { get; set; }
        public ShopDBContext Context { get; set; } = new ShopDBContext();

        public ViewModel()
        {
            Shops = Context.Shops.ToHashSet();
        }
    }
}

using D_DTesting.Domain.Abstractions;
using System.Security.Cryptography.X509Certificates;

namespace D_DTesting.Domain.Model.Inventory
{
    public class Bag
    {
        public Bag()
        {
            Items = new List<IItem>();
        }
        public string Name { get; set;}
        public IList<IItem> Items { get; set; }
        public int Capacity { get; set; }
        public int CurrentWeight { get; set; } = 0;
    }
}

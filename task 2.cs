using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid1
{
    //Який принцип S.O.L.I.D. порушено? Виправте!

    //Принцип єдиного обов’язку(SRP)(The Single Responsibility Principle) Принцип єдиного обов’язку(SRP)
    class Item
    {

    }
    class Order
    {
        private List<Item> itemList;

        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    }

    class OrderPrint
    {
        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}
    }

    class OrderManage
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Done");

        }
    }
}
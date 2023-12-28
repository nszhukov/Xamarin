using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App15
{
    public class Friend
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class Data : Friend
    {
        List<Friend> items;
        public Data()
        {
            items = new List<Friend>();
            var mockItems = new List<Friend>
            {
                new Friend {Name = "Peter", Email = "E-Class", Phone = "Nice car!"}
            };
            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }
    }

}
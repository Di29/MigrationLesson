using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationsLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var context = new ShopContext())
            {
                var user = new User
                {
                    Login = "di29",
                    Password = "12345"
                };

                var cart = new Cart
                {
                    User = user
                };

                var item = new Item
                {
                    Name = "oil",
                    Price = 200
                };

                cart.Items.Add(item);

                context.Users.Add(user);
                context.Carts.Add(cart);
                context.Items.Add(item);

                context.SaveChanges();
            }
        }
    }
}

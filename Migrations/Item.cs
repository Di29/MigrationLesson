using System.Collections.Generic;

namespace MigrationsLesson
{
    public class Item : Entity
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();
    }
}

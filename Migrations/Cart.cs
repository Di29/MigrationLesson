﻿using System.Collections.Generic;

namespace MigrationsLesson
{
    public class Cart : Entity
    {
        public virtual User User { get; set; }
        public virtual ICollection<Item> Items { get; set; } = new List<Item>();
    }
}

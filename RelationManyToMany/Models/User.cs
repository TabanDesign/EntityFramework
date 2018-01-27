using System;
using System.Collections.Generic;

namespace RelationManyToMany.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public virtual IList<Group> Groups { get; set; }
        public User()
        {
            ID = Guid.NewGuid();
        }
    }
}

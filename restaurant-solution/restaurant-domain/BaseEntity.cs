using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant.Domain
{
    public class BaseEntity
    {
        protected BaseEntity()
        {
            CreatedOn = DateTime.UtcNow;
            IsRemoved = false;
        }

        public int Id { get; private set; }
        public DateTime CreatedOn { get; private set; }
        public bool IsRemoved { get; private set; }
    }
}

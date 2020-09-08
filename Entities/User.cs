using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User:IEntity
    {
        public Guid Id { get; set; }
    }
}

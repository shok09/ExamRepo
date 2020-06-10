using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities.Abstract
{
    public class BaseIdentifier<TId>
    {
        public TId Id { get; set; }
    }
}

using DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class DateInfo : BaseIdentifier<int>
    {
        public DateTime DateOfMan { get; set; }
        public DateTime DateOfExpire { get; set; }
    }
}

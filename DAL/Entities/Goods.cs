using DAL.Entities.Abstract;
using DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Goods : BaseIdentifier<int>
    {
        public string Title { get; set; }
        public int Volume { get; set; }
        public string Description { get; set; }
        public ToxicityLevel Toxicity { get; set; }
        public DateInfo ValidityDate { get; set; }
    }
}

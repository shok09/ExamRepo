using DAL.Entities.Abstract;
using DAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Entities
{
    public class Room : BaseIdentifier<int>
    {
        public Room()
        {
            ContainedGoods = new HashSet<Goods>();
        }
        public int TotalVolume { get; set; }
        public ToxicityLevel Toxicity { get; set; }
        public virtual ICollection<Goods> ContainedGoods { get; set; }
    }
}

using Atomia.Store.Core;
using System.Collections.Generic;

namespace Atomia.Store.AspNetMvc.Models
{
    public class SelectSingleModel : SelectItemModel
    {
        public SelectSingleModel()
            : base()
        {
            this.CartCustomAttributes = new List<CustomAttribute>();
        }

        public IEnumerable<CustomAttribute> CartCustomAttributes { get; set; }

        public string Campaign { get; set; }

        public string Next { get; set; }
    }
}

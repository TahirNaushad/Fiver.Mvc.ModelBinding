using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fiver.Mvc.ModelBinding.Models.Home
{
    public class CollectionInputModel
    {
        public IEnumerable<string> Values { get; set; }
    }
}

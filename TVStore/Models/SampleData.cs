using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TVStore.Models
{
    public class SampleData
    {
        public static void Initialize(TVContext context)
        {
            if (!context.TVs.Any())
            {
                context.TVs.AddRange(
                    new TV
                    {
                        Name = "UE43N5000AUXUA",
                        Company = "Samsung",
                        Price = 600
                    },
                    new TV
                    {
                        Name = "43UK6300PLB",
                        Company = "LG",
                        Price = 550
                    },
                    new TV
                    {
                        Name = "KD55XF7096BR2",
                        Company = "Sony",
                        Price = 500
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

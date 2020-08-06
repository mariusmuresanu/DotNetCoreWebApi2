using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApi2.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new DataContext(serviceProvider.GetRequiredService<DbContextOptions<DataContext>>()))
            {
                // Look for any flowers.
                if (context.Values.Any())
                {
                    return;   // DB table has been seeded
                }

                context.Values.AddRange(
                    new Value
                    {
                        Name = "Value1",
                      
                    },

                    new Value
                    {
                        Name = "Value2",
                                            }
                );
                context.SaveChanges();
            }
        }
    }
}

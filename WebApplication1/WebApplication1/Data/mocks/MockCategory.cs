using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.mocks
{
    public class MockCategory : Icarscategory
    {
        public IEnumerable<Category> AllCAtegories {

            get
            {
                return new List<Category> {
                    new Category { name = "Электромобили",desc = "Современный вид транспорта" },
                    new Category{ name="Классические автомобили", desc="Машины с двигателем внутреннего сгорания"}

                };
             }

        }
    }
}

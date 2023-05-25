using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.mocks
{
    public class MockCars : IAllcars
    {

        private readonly Icarscategory _categorycars = new MockCategory();
        public IEnumerable<Car> cars {

            get
            {
                return new List<Car> {
                    new Car { name = "KiaRio",
                        shortDesc= "dfdjfdf",
                        longDesc="sdfsdfsdf",
                        img="https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.kia.ru%2Fmodels%2Frio%2Fdesc%2F&psig=AOvVaw0hhb3d6RaObbmp9jar08qF&ust=1684585241112000&source=images&cd=vfe&ved=0CBEQjRxqFwoTCPiu2pmvgf8CFQAAAAAdAAAAABAE",
                        price=4500,
                        isFavorite=true,
                        availible=true, Category=_categorycars.AllCAtegories.Last() },


                    new Car { name = "Тайота Камри",
                        shortDesc= "dfdjfdf",
                        longDesc="sdfsdfsdf",
                        img="https://avtomarket.ru/stuff/garage/8y/720x-/7786_1221910952_elr8y.jpg",
                        price=4500,
                        isFavorite=true,
                        availible=true, Category=_categorycars.AllCAtegories.Last() }


                };
            }
        }
        public IEnumerable<Car> getfavcars { get  ; set ; }

        public Car getobjectcar(int carid)
        {
            throw new NotImplementedException();
        }
    }
}

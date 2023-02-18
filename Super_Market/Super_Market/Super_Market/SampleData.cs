using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Super_Market
{
    public static class SampleData
    {
        public static Proudect meet = new Proudect()
        {
            Id = 1,
            Name = "meet",
            SellingPrice = 25.5,
            PurchasingPrice = 27.5,
            Quantity = 26,
            ProductionDate = new DateTime(2023, 2, 11),
            ExpirationDate = new DateTime(2023, 10, 11),
            
        };

        public static Proudect fish = new Proudect()
        {
            Id = 2,
            Name = "fish",
            SellingPrice = 25.5,
            PurchasingPrice = 57.5,
            Quantity = 26,
            ProductionDate = new DateTime(2023, 2, 11),
            ExpirationDate = new DateTime(2023, 10, 11),
            
        };
        public static Proudect zabaty = new Proudect()
        {
            Id = 2,
            Name = "Zabaty",
            SellingPrice = 25.5,
            PurchasingPrice = 57.5,
            Quantity = 26,
            ProductionDate = new DateTime(2023, 2, 11),
            ExpirationDate = new DateTime(2023, 10, 11),
           
        };
        public static Proudect milkkkk = new Proudect()
        {
            Id = 2,
            Name = "milkkkkk",
            SellingPrice = 25.5,
            PurchasingPrice = 57.5,
            Quantity = 26,
            ProductionDate = new DateTime(2023, 2, 11),
            ExpirationDate = new DateTime(2023, 10, 11),
           
        };


        public static List<Categorys> Allcategorys = new List<Categorys>()
            {
                new Categorys{Id=20,Name="meetcategiry" ,Products=new List<Proudect>{ meet} },
                new Categorys{Id=25,Name=" fishecat" ,Products=new List<Proudect>{ fish } },
                new Categorys{Id=20,Name=" milkcat",Products=new List<Proudect>{ milkkkk } },
                new Categorys{Id=25,Name=" zabadycat",Products=new List<Proudect>{ zabaty } }
};



        public static List<Stor> st = new List<Stor>()
        {
            new Stor{Name="protien store",Location="minia",Categories=new List<Categorys>(){Allcategorys[0],Allcategorys[1] } },
            new Stor{Name="milk store",Location="minia",Categories=new List<Categorys>(){ Allcategorys[2], Allcategorys[3] } },


        };
        public static List<Users> users = new List<Users>()
        {
            new Users{UserName="Admin",Password=111,Salary=2500,Pos=position.Admin},
             new Users{UserName="casher1",Password=222,Salary=2500,Pos=position.Casher},
              new Users{UserName="casher2",Password=333,Salary=3500,Pos=position.Casher}


        };
        public static Sellinvoce Sell = new Sellinvoce()
        {
            Products = new List<Proudect>() { meet },
           // NameStore = stores[0].Name,
            casherUserName = users[1],
            PaidMoney = 250,

        };

        public static List<Suppliers> suppliers = new List<Suppliers>()
        {
            new Suppliers{Id=1,Name="seliva",products=new List<Proudect>() {meet} },
            new Suppliers{Id=2,Name="alaa",products=new List<Proudect>() { zabaty } },
             new Suppliers{Id=3,Name="kero",products=new List<Proudect>() { milkkkk} },



        };
        public static Recipt Receiptrr = new Recipt()
        {
            //StoreName = stores[0].Name,
            products = new List<Proudect>() { fish },
            Quantity = 20,
            supplier = suppliers[0]
        };
    }
}

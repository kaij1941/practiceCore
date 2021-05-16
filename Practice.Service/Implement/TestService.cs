using Practice.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Service.Implement
{
    public class TestService : ITestService
    {
        public TestService()
        {
        }

        public async Task Test()
        {
            List<Product> pList = new List<Product>();
            pList.Add(new Product() { Code = "A", Name = "A1", QTY = "3" });
            pList.Add(new Product() { Code = "A", Name = "A2", QTY = "3" });
            pList.Add(new Product() { Code = "A", Name = "A1", QTY = "" });

            List<Promotion> pmList = new List<Promotion>();
            pmList.Add(new Promotion() { Code = "A", Name = "A1", price = "99" });
            pmList.Add(new Promotion() { Code = "A", Name = "A3", price = "95" });
            pmList.Add(new Promotion() { Code = "A", Name = "A1", price = "60" });
            pmList.Add(new Promotion() { Code = "A", Name = "A4", price = "43" });
            pmList.Add(new Promotion() { Code = "A", Name = "A5", price = "20" });
            pmList.Add(new Promotion() { Code = "A", Name = "A6", price = "10" });
            pmList.Add(new Promotion() { Code = "A", Name = "A7", price = "33" });
            pmList.Add(new Promotion() { Code = "A", Name = "A1", price = "55" });

            var codes = pmList.Where(x => int.Parse(x.price) > 60)
                .Select(x => new Title
                {
                    Code = x.Code,
                    Name = x.Name
                });
            
            var result = pList.Where(x => codes.Any(o => o.Name == x.Name));

            var Test = new Promotion();

        }
        public bool checkIsNumAwait(string Test) 
        {
            if (Test == null &&Test.Length<1)
            {
                return false;
            }
            var checkArray = Test.ToCharArray();
            foreach (var item in checkArray)
            {
                if (char.IsNumber(item).Equals(false)) 
                {
                    return false;
                }
            }
            
            return true;
        }

        public string RandomWord(int WordLength = 1)
        {
            throw new NotImplementedException();
        }

        public static string NulltoStr(Object obj,string replaceWord) 
        {
            return obj == null ? replaceWord : obj.ToString();
        }
    }
    public class Product 
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string QTY { get; set; }
    }

    public class Promotion 
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string price { get; set; }
    }
    public class Title
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}

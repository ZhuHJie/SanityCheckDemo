using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReNameStoredProcedure
{
    public class Test
    {
        public static void Show()
        {
            var a = new List<A>() { new A() { Id = 1, Name = "Test" } };
            var b = new List<B>() { new B() { Id = 1, A_Id = 1, Name = "B1" }, new B() { Id = 2, A_Id = 1, Name = "B2" } };

            var query = (from at in a
                         join bt in b
                         on at.Id equals bt.A_Id
                         select new { at.Id, AName = at.Name, BName = bt.Name }).GroupBy(e => e.Id).Select(e => new { Id = e.Key, e.FirstOrDefault()?.AName, BName = string.Join(',', e.Select(b => b.BName)) });
            foreach (var item in query)
            {
                Console.WriteLine($"{item.Id},{item.AName},{item.BName}");

            }

        }
    }


    public class A
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class B
    {
        public int Id { get; set; }

        public int A_Id { get; set; }
        public string Name { get; set; }
    }
}

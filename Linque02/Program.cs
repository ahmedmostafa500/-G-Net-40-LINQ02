using System.Runtime.ConstrainedExecution;

namespace Linque02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region question1
            //        var top3 = products
            //.OrderByDescending(p => p.Price)
            //.Take(3);
            #endregion
            #region quesion2
            //int pageNumber = 2;
            //int pageSize = 5;

            //var result = products
            //    .Skip((pageNumber - 1) * pageSize)
            //    .Take(pageSize);
            #endregion
            #region question3
            //        var result = products
            //.TakeWhile(p => p.UnitPrice < 25);
            #endregion
            #region question4
            //        bool allInStock = products
            //.Where(p => p.Category == "Seafood")
            //.All(p => p.UnitsInStock > 0);
            #endregion
            #region question5
            //int[] ids = { 3, 9, 13, 18 };

            //bool exists = ids.Contains(9);
            #endregion
            #region question6
            //        var grouped = products
            //.GroupBy(p => p.Category);

            //        foreach (var group in grouped)
            //        {
            //            Console.WriteLine("Category: " + group.Key);
            //            Console.WriteLine("Count: " + group.Count());
            //        }
            #endregion
            #region question7
            //var groupedNames = products
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        ProductNames = g.Select(p => p.Name)
            //    });

            //foreach (var group in groupedNames)
            //{
            //    Console.WriteLine("Category: " + group.Category);
            //    foreach (var name in group.ProductNames)
            //    {
            //        Console.WriteLine(" - " + name);
            //    }
            //}
            #endregion
            #region question8
    //        var categories = products
    //.GroupBy(p => p.Category)
    //.Where(g => g.Count() > 3)
    //.Select(g => g.Key);

    //        foreach (var category in categories)
    //        {
    //            Console.WriteLine(category);
            }
        #endregion
        #region question9
        //        var result =
        //    from c in customers
        //    group c by c.Country into g
        //    select new
        //    {
        //        Country = g.Key,
        //        Count = g.Count(),
        //        TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
        //    };

        //foreach (var group in result)
        //{
        //    Console.WriteLine($"Country: {group.Country}, Count: {group.Count}, TotalOrderValue: {group.TotalOrderValue}");
        //}
        #endregion
        #region question10
        //int totalUnits = products.Sum(p => p.UnitsInStock);
        //Console.WriteLine("Total Units in Stock: " + totalUnits);


        #endregion
        #region question11
        //        decimal cheapestPrice = products.Min(p => p.UnitPrice);
        //        decimal mostExpensivePrice = products.Max(p => p.UnitPrice);

        //        Console.WriteLine($"Cheapest Price: {cheapestPrice}");
        //Console.WriteLine($"Most Expensive Price: {mostExpensivePrice}");
        #endregion
        #region question12
        //        var categories = products
        //    .Select(p => p.Category)
        //    .Distinct();

        //foreach (var category in categories)
        //{
        //    Console.WriteLine(category);
        //}
        #endregion
        #region question13
        //        int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
        //        int[] setB = { 3, 6, 9, 12, 15, 13 };

        //        var result = setA.Except(setB);

        //foreach (var id in result)
        //{
        //    Console.WriteLine(id);
        //}
        #endregion
        #region question14
//        string[] list1 = { "Germany", "France", "UK", "Spain" };
//        string[] list2 = { "france", "SPAIN", "Italy" };

//        var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

//foreach (var country in result)
//{
//    Console.WriteLine(country);
//}
    #endregion

}
    }
}


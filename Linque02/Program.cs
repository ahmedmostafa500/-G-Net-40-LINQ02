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
        }
    }
}

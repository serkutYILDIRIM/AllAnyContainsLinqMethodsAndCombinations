using LINQSamples.Common;

namespace LINQSamples
{
    public class LinqSamples : ViewModelBase
    {
        #region AllQuery
        /// <summary>
        /// Use All() to see if all items in a collection meet a specified condition
        /// </summary>
        public bool AllQuery()
        {
            var productList = GetProducts();

            // Write Query Syntax Here
            var result = (from prod in productList
                          select prod)
                       .All(prod => prod.ListPrice > prod.Cost);

            return result;
        }
        #endregion

        #region AllMethod
        /// <summary>
        /// Use All() to see if all items in a collection meet a specified condition
        /// </summary>
        public bool AllMethod()
        {
            var productList = GetProducts();

            // Write Method Syntax Here
            var result = productList.All(prod => prod.ListPrice > prod.Cost);

            return result;
        }
        #endregion

        #region AllSalesQuery
        /// <summary>
        /// Use All() to see if all items in a collection meet a specified condition
        /// </summary>
        public bool AllSalesQuery()
        {
            List<SalesOrder> salesList = GetSales();

            // Write Query Syntax Here
            var result = (from sale in salesList
                          select sale)
                       .All(sale => sale.OrderQty >= 1);

            return result;
        }
        #endregion

        #region AllSalesMethod
        /// <summary>
        /// Use All() to see if all items in a collection meet a specified condition
        /// </summary>
        public bool AllSalesMethod()
        {
            List<SalesOrder> salesList = GetSales();

            // Write Method Syntax Here
            var result = salesList.All(sale => sale.OrderQty >= 1);

            return result;
        }
        #endregion

        #region AnyQuery
        /// <summary>
        /// Use Any() to see if at least one item in a collection meets a specified condition
        /// </summary>
        public bool AnyQuery()
        {
            var salesList = GetSales();

            // Any Query Syntax Here
            var result = (from sale in salesList
                          select sale)
                        .Any(sale => sale.LineTotal > 1000);

            return result;
        }
        #endregion

        #region AnyMethod
        /// <summary>
        /// Use Any() to see if at least one item in a collection meets a specified condition
        /// </summary> 
        public bool AnyMethod()
        {
            var salesList = GetSales();

            // Any Method Syntax Here
            var result = salesList.Any(sale => sale.LineTotal > 1000);

            return result;
        }

        #endregion

        #region ContainsQuery
        /// <summary>
        /// Use the Contains() operator to see if a collection contains a specific value
        /// </summary>
        public bool ContainsQuery()
        {
            List<int> numberList = new() { 1, 2, 3, 4, 5 };

            // Write Query Syntax Here
            var result = (from num in numberList
                          select num).Contains(3);

            return result;
        }
        #endregion

        #region ContainsMethod
        /// <summary>
        /// Use the Contains() operator to see if a collection contains a specific value
        /// </summary>
        public bool ContainsMethod()
        {
            List<int> numberList = new() { 1, 2, 3, 4, 5 };

            // Write Method Syntax Here
            var result = numberList.Contains(3);

            return result;
        }
        #endregion

        #region ContainsComparerQuery
        /// <summary>
        /// Use the Contains() operator to see if a collection contains a specific value
        /// </summary>
        public bool ContainsComparerQuery()
        {
            var productList = GetProducts();
            ProductIdComparer productIdComparer = new();

            // Write Query Syntax Here
            var result = (from prod in productList
                          select prod)
                       .Contains(new Product { ProductID = 744 }, productIdComparer);

            return result;
        }
        #endregion

        #region ContainsComparerMethod
        /// <summary>
        /// Use the Contains() operator to see if a collection contains a specific value.
        /// When comparing classes, you need to write a EqualityComparer class.
        /// </summary>
        public bool ContainsComparerMethod()
        {
            var productList = GetProducts();
            ProductIdComparer productIdComparer = new();

            // Write Method Syntax Here
            var result = (from prod in productList
                          select prod)
                       .Contains(new Product { ProductID = 744 }, productIdComparer);

            return result;
        }
        #endregion
    }
}

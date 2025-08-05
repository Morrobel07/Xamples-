namespace LanguageFeatures.Models
{
    public static class MyExtensionMethodd
    {
        public static decimal TotalPricess(this ShoppingCart cartParam)
        {
            decimal total = 0;
            if (cartParam.Products != null)
            {
                foreach (Product? prod in cartParam.Products)
                {
                    total += prod?.Price ?? 0;


                }
            }
            return total;
        }
    }
}


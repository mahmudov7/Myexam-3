class ShoppingCart
{
    private List<Product> products = new List<Product>();

    public void AddProduct(Product p)
    {
        products.Add(p);
    }

    public bool RemoveProduct(string name)
    {
        Product productToRemove = products.Find(
            p => p.Name == name
        );

        if (productToRemove != null)
        {
            products.Remove(productToRemove);
            return true;
        }

        return false;
    }

    public double GetTotal()
    {
        double total = 0;

        foreach (Product p in products)
        {
            total += p.GetFinalPrice();
        }

        return total;
    }

    public void PrintAll()
    {
        foreach (Product p in products)
        {
            Console.WriteLine(
                $"{p.Name} - {p.GetFinalPrice()}"
            );
        }
    }
}
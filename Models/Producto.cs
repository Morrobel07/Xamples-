namespace LanguageFeatures.Models;

public class Productos
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal Precio { get; set; }

}

public class ProductoRepositorio
{
    private List<Productos> _productosDb = new List<Productos>
    {
        new Productos { Id = 1, Name = "Laptop", Precio = 1200.50m },
        new Productos { Id = 2, Name = "Mouse", Precio = 25.00m },
        new Productos { Id = 3, Name = "Teclado", Precio = 75.99m },

    };

    public IEnumerable<Productos> ObtenerProductos()
    {
        Console.WriteLine("Iniciando la lectura de productos de la 'base de datos'...");
        foreach (var producto in _productosDb)
        {
            Thread.Sleep(50);
            Console.WriteLine($"Devolviendo producto con ID: {producto.Id}");
            yield return producto;

        }
    }
}
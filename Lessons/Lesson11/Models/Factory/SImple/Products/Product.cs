//-----------------------------------------------------------------

namespace Lesson11.Models;

/// <summary>
/// Class
/// </summary>
public class Product
{
    #region Public Properties
    /// <summary>
    /// Public Name
    /// </summary>
    public string Name { get; private set; }
    /// <summary>
    /// Public Price
    /// </summary>
    public decimal Price { get; private set; }
    #endregion

    #region Constructors
    /// <summary>
    /// Private Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="price"></param>
    private Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }
    #endregion

    #region Factory Method
    /// <summary>
    /// Factory Method
    /// </summary>
    /// <param name="name"></param>
    /// <param name="price"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static Product CreateProduct(string name, decimal price)
    {
        if (price < 0)
        {
            throw new ArgumentException("Price cannot be negative.");
        }

        return new Product(name, price);
    }
    #endregion
}
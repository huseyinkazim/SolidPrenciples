// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");
Order order = new Order
{
	ShippingName = "Gözlük",
	ShippingCost = 3000.50M
};
IShippingStrategy standartStrategy = new StandardShippingStrategy();
IShippingStrategy expressStrategy = new ExpressShippingStrategy();
calculateCost(order, standartStrategy);//standart ücretlendirme 
calculateCost(order, expressStrategy);//express ücretlendirma
//ayrı bir tür shipping olduğu taktirde IShippingStrategy interfaceinden türemiş yeni bir class üreterek OCP sağlamış olacağız

decimal calculateCost(Order order, IShippingStrategy strategy)
{
	return strategy.CalculateShippingCost(order);
	
}


public interface IShippingStrategy
{
	decimal CalculateShippingCost(Order order);
}

public class StandardShippingStrategy : IShippingStrategy
{
	public decimal CalculateShippingCost(Order order)
	{
		decimal shippingCost = 0;

		// Standart Teslimat Order object sine göre fiyat belirleme işlemleri yapar.
		return shippingCost;
	}
}

public class ExpressShippingStrategy : IShippingStrategy
{
	public decimal CalculateShippingCost(Order order)
	{
		decimal shippingCost = 0;
		// Express Teslimat Order object sine göre fiyat belirleme işlemleri yapar.
		return shippingCost;
	}
}

public class Order
{

	public string ShippingName { get; set; }
	public decimal ShippingCost { get; set; }

}
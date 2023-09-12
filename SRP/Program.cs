
ProductPriceCalculator calculator = new();
Product urun1 = new Product
{
	Name = "Çanta",
	Description = "Sırt Çantası",
	Price = 300
};
Product urun2 = new Product
{
	Name = "Çanta",
	Description = "Bel Çantası",
	Price = 200
};
//Urun Ücret hesaplama esnasında yapacağımız işlemlere göre farklı class,operasyon yapısı kurarak tek işlev verdik.
calculator.CalculatePrice(urun1);
calculator.CalculatePrice(urun1);

//Urun Vergi hesaplama esnasında yapacağımız işlemlere göre farklı class,operasyon yapısı kurarak tek işlev verdik.
calculator.CalculateTax(urun2);
calculator.CalculateTax(urun2);

public class ProductPriceCalculator
{
	private const decimal KDV = 0.5M;

	public decimal CalculateTax(Product product)
	{
		decimal tax = 0;
		tax += product.Price * KDV;

		return tax;
	}

	public decimal CalculatePrice(Product product)
	{
		decimal price = 0;
		price += product.Price;
		price += CalculateTax(product);

		return price;
	}
}

public class Product
{
	public string Name { get; set; }
	public string Description { get; set; }
	public decimal Price { get; set; }

}
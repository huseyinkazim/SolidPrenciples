// See https://aka.ms/new-console-template for more information
PaymentProcessor paymentProcessor1 = new PaymentProcessor(new CreditCardPayment());
PaymentProcessor paymentProcessor2 = new PaymentProcessor(new BankTransferPayment());
PaymentProcessor paymentProcessor3 = new PaymentProcessor(new PayPalPayment());
paymentProcessor1.Process(500.0);
paymentProcessor2.Process(300.0);
paymentProcessor3.Process(400.0);
//Burdaki amac PaymentProcessor classının IPaymentMethod interface kullanma zorunluluğu bulunuyor bizde burda class ın içerisinde 
//instance oluşturma olayını dışarı çıkararak classı bağımlılıktan kurtarma

public interface IPaymentMethod
{
	bool ProcessPayment(double amount);
}

public class CreditCardPayment : IPaymentMethod
{
	public bool ProcessPayment(double amount)
	{
		// kredi kartı ödeme işlemlerinin gerçekleştirilmesi
		return true;
	}
}

public class BankTransferPayment : IPaymentMethod
{
	public bool ProcessPayment(double amount)
	{
		// banka havalesi ödeme işlemlerinin gerçekleştirilmesi
		return true;
	}
}

public class PayPalPayment : IPaymentMethod
{
	public bool ProcessPayment(double amount)
	{
		// PayPal ödeme işlemlerinin gerçekleştirilmesi
		return true;
	}
}

public class PaymentProcessor
{
	private readonly IPaymentMethod _paymentMethod;
	//Burda dependency Injection gibi bir yapı kullanılabilir.
	public PaymentProcessor(IPaymentMethod paymentMethod)
	{
		_paymentMethod = paymentMethod;
	}

	public void Process(double amount)
	{
		if (_paymentMethod.ProcessPayment(amount))
		{
			Console.WriteLine("Payment processed successfully!");
		}
		else
		{
			Console.WriteLine("Payment failed!");
		}
	}
}
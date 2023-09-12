// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Interface Segregation Principle deki amaç bize interface leri birbiriden işlevlerine göre ayır ve gereksiz bağımlılıktan kurtul

IFormValidator validator1 = new FormValidatorOnlyHandler();
IFormValidator validator2 = new FormHandler();
validator1.ValidateForm();
validator2.ValidateForm();

IFormStyler formStyler1 = new FormStylerOnlyHandler();
IFormStyler formStyler2 = new FormHandler();
formStyler1.ApplyStyle();
formStyler2.ApplyStyle();

// İşlevselliği doğrulama olan arayüz
public interface IFormValidator
{
	bool ValidateForm();
}

// Metin alanlarını sınırlama, renklendirme veya stil uygulama işlevselliği olan arayüz
public interface IFormStyler
{
	void ApplyStyle();
}

// Bir formun doğrulanması ve stil uygulanması için kullanılacak sınıf
public class FormHandler : IFormValidator, IFormStyler
{
	public bool ValidateForm()
	{
		// Doğrulama işlevselliğini gerçekleştirir
		return true;
	}

	public void ApplyStyle()
	{
		// Metin alanlarını sınırlama, renklendirme veya stil uygulama işlevselliğini gerçekleştirir
	}
}

// Yalnızca doğrulama işlevselliğini kullanacak bir sınıf
public class FormValidatorOnlyHandler : IFormValidator
{
	public bool ValidateForm()
	{
		// Doğrulama işlevselliğini gerçekleştirir
		return true;
	}
}

// Yalnızca stil uygulama işlevselliğini kullanacak bir sınıf
public class FormStylerOnlyHandler : IFormStyler
{
	public void ApplyStyle()
	{
		// Metin alanlarını sınırlama, renklendirme veya stil uygulama işlevselliğini gerçekleştirir
	}
}
Hayvan hayvan1 = new Maymun();
Hayvan hayvan2 = new Kus();

BeslenmeIslemi(hayvan1); // "Maymun besleniyor"
BeslenmeIslemi(hayvan2); // "Kuş besleniyor"
//Üst-alt sınıf içierinde kullanılan tüm classlarda kullanılan tüm özlelikleiren diğerleri içinde kullanılabilir olması gerekmektedir

//Olumsuz Örnek Burda olması gereken Hayvan classından Uc operasyonu kaldırılıp yerine Ucma fonksiyonu olan 
//classlarda IUc interface i üzerinden bu işlemlerin yapılması
UcmaIslemi(hayvan1);
UcmaIslemi(hayvan2);

void BeslenmeIslemi(Hayvan hayvan)
{
	hayvan.Beslen();
}
void UcmaIslemi(Hayvan hayvan)
{
	hayvan.Uc();
}
public class Hayvan
{
	public virtual void Beslen()
	{
		Console.WriteLine("Hayvan besleniyor");
	}
	//Yanlış Kullanım
	public virtual void Uc()
	{
		Console.WriteLine("Hayvan Ucuyor");
	}

}

public interface IUC
{
	void Uc();
}
public class Kus : Hayvan
{
	public override void Beslen()
	{
		Console.WriteLine("Kuş besleniyor");
	}
	public override void Uc()
	{
		Console.WriteLine("Kuş Uçuyor");
	}


}


public class Maymun : Hayvan
{
	public override void Beslen()
	{
		Console.WriteLine("Maymun besleniyor");
	}
	public override void Uc()
	{
		throw new Exception("Maymun Uçamaz");
	}
}
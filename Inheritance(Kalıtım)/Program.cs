
#region Kalıtım


//Kalıtım ile, üretilen nesneler farklı nesnelere özelliklerini aktarabilmekte ve böylece hiyerarşik bir düzen oluşturabilmektedir.
//Kalıtım sınıflara özel bir niteliktir.
//Bir sınıf sadece 1 sınıftan kalıtım alabilir.
//İki sınıf arasında kalıtımsal ilişki kurmak için : operatörü kulanılır.

//Base Class: Kalıtım veren sınıftır.
//Derived Class: Kalıtım alan sınıftır.
//Bir sınıftan nesne üretilirken eğer kalıtım aldığı üst sınıflar varsa önce o sınıflardan sırayla nesne üretilir.


new C(); // C sınıfından bir nesne üretiyoruz. 
//Üretilirken önce A sınıfından ardından B sınıfından daha sonra C sınıfından nesne üretiliyor.

class A
{
    public A() //constructor metot
    {
        Console.WriteLine($"{nameof(A)} nesnesi oluşturulmuştur");
    }
}

class B
{
    public B()
    {
        Console.WriteLine($"{nameof(A)} nesnesi oluşturulmuştur");
    }

}

class C 
{
    public C()
    {
        Console.WriteLine($"{nameof(A)} nesnesi oluşturulmuştur");
    }

}

#endregion

#region Sanal Yapılar | virtual - override

class Sekil
{
    protected int _boy;
    protected int _en;
    public Sekil (int boy, int en)
    {
        _boy = boy;
        _en = en;
    }

    public virtual int AlanHesapla()
    {
        return 0;
    }


}

class Ucgen : Sekil
{

    public Ucgen(int boy, int en) : base (boy, en)
    {

    }

    public override int AlanHesapla()
    {
        return (_boy * _en)/2 ;
    }

}

class Dikdortgen : Sekil
{
    public Dikdortgen(int boy, int en) : base (boy, en)
    {

    }

    public override int AlanHesapla()
    {
        return (_boy * _en) ;
    }

}

class Kare : Sekil
{
    public Kare(int boy, int en) : base (boy, en)
    {

    }

    public override int AlanHesapla()
    {
        return (_boy * _en) ;
    }

}




#endregion

#region Polimorfizm
//Bir nesneyi birden fazla tür ile işaretleyebiliyorsak buna polimorfizm diyoruz.
//Bir nesne ancak kendi türünden bir referansla işaretlenebilir
//Bir nesneyi başka bir tür ile işaretlemek için o türden kalıtım alması gerekir.


//PolB bb = new PolB();
//PolA aa = new PolB();
//PolC cc = new PolB();

class PolA : PolC
{

}

class PolB : PolA
{


}

class PolC
{


}


#endregion
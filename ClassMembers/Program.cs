
#region Sınıf Modelinden Referans Noktası Oluşturma
//Bir class tanımlandığında o class adı bir türdür. Haliyle o türü kullanabilmek için direkt olarak 
//class adını kullanmak yeterlidir.

OrnekModel w; //Referans noktası alma. //Fakat herhangi bir nesneyi işaretlemediğimiz için null değere sahiptir.

#endregion

#region Class Members

#region Field
// Nesne içerisinde değer tutmamızı sağlayan alanlardır

MyClass m1 = new MyClass(); //Nesne oluşturduk!

#endregion

#region Property
//Property esasında özünde bir metottur.
//Fiziksel olarak metottan farkı, parametre almaz ve içerisine get ve set olmak üzere 2 adet blok almaktadır
//Property'e değer atandığında set bloğu tetiklenir.
//Property'nin değeri çağrıldığında get bloğu tetiklenir ve return eder.
//Davranışsal olarak metottan farkı, nesne üzerinde değer okuma ve değer atama işlemlerinde kullanılır.
#endregion

#region Metot
// Nesne üzerinde, field'lardaki yahut dışarıdan parametreler eşliğinde gelen değerler üzerinde işlemler
//yapmamızı sağlayan temel programatik parçalardır.  

MyClass metot = new MyClass();
metot.X(); 

#endregion

#region Indexer

MyClass indexer = new MyClass();
indexer[5] = 10;

#endregion

#region Nested Type Class

//MyClass ın elemanı değildir fakat MyClass içinde olduğu için erişirken MyClass ismi üzerinden erişiriz.

MyClass.MyClass2 m2 = new MyClass.MyClass2();

#endregion


#endregion


#region this keyword
// Sınıfın nesnesini temsil eder
// Aynı isimde Field ile Metot parametrelerini ayırmak için kullanılır
// Bir constructer'dan başka bir constructer'ı çağırmak için kullanılır

// this keywordü ilgili class yapılanmasının o anki nesnesine karşılık gelir


#endregion

#region Record
// Record'lar değiştirilemez nesneler oluşturmamızı sağlar.
// Record'lar bir classtır. Fakat class'tan farkı nesneden ziyade nesnenin değerleri ön plandadır.

My_Class mm1 = new My_Class()
{
    MyProperty = 5
};

My_Class mm2 = new My_Class()
{
    MyProperty = 5
};
My_Record mm3 = new My_Record()
{
    MyProperty = 5
};
My_Record mm4 = new My_Record()
{
    MyProperty = 5
};

    Console.WriteLine(mm1.Equals(mm2)); //False   Nesne ön planda olduğu için False gelir
    Console.WriteLine(mm3.Equals(mm4)); //True    Değer ön planda olduğu için True gelir


class My_Class
{
    public int MyProperty {get; set;}
}

record My_Record
{
    public int MyProperty {get; init;}
}



#endregion

#region Constructor & Destructor
//Constructor bir metottur. Bir nesne üretim sürecinde ilk tetiklenen metottur.
//Constructor'ların
//  + Metot adı sınıf adıyla aynı olmalıdır.
//  + Geri dönüş değeri olmaz / belirtilmez.
//  + Erişim belirleyicisi public olmalıdır.
// Tanımlamasak dahi her sınıfın default constructor'u vardır.
// Constructor overload edilebilir bir metottur. Birden fazla tanımlanabilir.
// this keywordü ile aralarında geçiş yapılabilir.

//-----------------------------

//Destructor, bir classtan üretilen nesne imha edilirken otomatik çağrılan metottur.
//Bir class sadece 1 adet destructor içerebilir.

class Cons_Class
{
    public Cons_Class()
    {
        Console.WriteLine("1. Constructor");
    }

    public Cons_Class(int a) : this() //this keywordü ile bu şekilde diğer constructor a geçiş yaparız.
    {
        Console.WriteLine($"2. Constructor : a = {a} ");
    }

    public Cons_Class(int a, int b) : this(a) //this içindeki değer, constructorun aldığı parametreyi belirler.
    {
        Console.WriteLine($"3. Constructor : a = {a} | b = {b} ");
    }

    ~Cons_Class() //Destructor bu şekilde tanımlanır
    {
        Console.WriteLine("Nesne imha ediliyor...")
    }

}




#endregion



// Class'a ve elemanlarına aşağıdaki şekilde açıklama ekleyebiliriz.

/// <summary>
/// Bu bir örnek classtır.
/// </summary>
class MyClass
{
    public int a;  //Field 
    public string b;

    int yasi;
    int no;

    #region Full Property

    //Property hangi türden bir field'ı temsil ediyorsa o türden olmalıdır.
    public int Yasi
    {
        get
        {
            //Property üzerinden değer talep edildiğinde bu blok tetiklenir.
            return yasi;
        }

        set
        {
            yasi = value;
        }

    }


    #endregion

    #region Prop Property
    // Field tanımlanmamış olsa bile kendisi otomatik tanımlar. (Aynı isimde baş harfi küçük olacak şekilde)
    public int No{  get; set;  }

    #endregion

    #region Expression-Bodied Property
    //Tanımlanan property'de lambda expression kullanmamızı sağlayan söz dizimidir
    //Bu şekilde imzalanan property'ler readonly olarak oluşturulur.

    //public string Cinsiyet 
    //{
    //    get
    //    {
    //        return "Erkek";
    //    }
    //}

    //yukarıdaki yerine aşağıdaki
    public string Cinsiyet => "Erkek";


    #endregion
    
    #region Metot
    public int  X()
    {
        return 0;
    }

    #endregion

    #region Indexer

    public int this [int c]
    {
        get
        {
            return c;
        }
        set
        {

        }
    }


    #endregion

    public class MyClass2
    {

    }


}


class OrnekModel
{
    int a;
    int b;

    public void X()
    {
        Console.WriteLine(a + " " + b);

    }

    public int Y()
    {
        return a * b;
        
    }



}

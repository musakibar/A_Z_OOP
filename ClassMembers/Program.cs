
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

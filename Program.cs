// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



/**Küçük boyutlu bir türü daha büyük boyutlu bir türe geçirdiğinizde otomatik olarak yapılan işleme örtük dönüştürme (implicit casting) denir. Bu işlem derleyici tarafından otomatik olarak yapılır ve programcıdan açık bir talimat gerektirmez. Bu sayede daha küçük türdeki veri, daha büyük türde sorunsuz bir şekilde saklanabilir.**/
int myInt = 9;

double myDouble = myInt;
Console.WriteLine(myDouble);

short s = 10;  //Boyut: 16 bit (2 byte) Aralık: -32,768 ile 32,767 arasında
Console.WriteLine(s);

int j = 100; //Boyut: 32 bit (4 byte) Boyut: 32 bit (4 byte)
long l = j; //Boyut: 64 bit (8 byte)  Aralık: -9,223,372,036,854,775,808 ile 9,223,372,036,854,775,807 arasında
Console.WriteLine(l);

int i = 8;

float f = i; //Boyut: 32 bit(4 byte)

Console.WriteLine(f);

double d = i; //Boyut: 64 bit(4 byte)
Console.WriteLine(d);

float f2 = 123.25f;
double d2 = f2;
Console.WriteLine(d2);

bool b = true;
int i2 = b?1:0;
Console.WriteLine(i2);




// not C# dilinde örtük dönüştürme kuralları, genellikle veri kaybı riski olmayan ve güvenli kabul edilen türler arasında gerçekleştirilir. Daha karmaşık veya riskli dönüştürmeler için açık dönüştürme (explicit casting) kullanmak gerekir.

/**double myDouble2 = 9.78;

int myInt2 = (int)myDouble2;
Console.WriteLine(myInt2);
**/





//Tabii, C# dilinde explicit casting olarak adlandırılan açık dönüştürme işlemi, bir veri türünü başka bir veri türüne dönüştürmek için kullanılan bir yöntemdir. Bu işlem, derleyiciye belirli bir tür dönüşümü yapılması gerektiğini açıkça belirtmek için kullanılır. Açık dönüştürme yapılırken, potansiyel veri kaybı veya doğruluk kaybı olabileceğinden dolayı, programcının bilinçli olarak bu dönüşümü yapması gereklidir.

double d3 = 12.5;
int i3 = (int) d3;
Console.WriteLine(i3);

float f4 = 123.45f;
long l2 = (long) f4;
Console.WriteLine(l2);
int i5 = 110000;
short s5 = (short) i5;
Console.WriteLine(s5); // veri kaybı gözlenir hedef_tür degisken_adi = (hedef_tür)kaynak_deger;


int myNum = 10;
float myFloat = 10.1f;
bool myBool = true;

Console.WriteLine(myBool.GetType());
Console.WriteLine(myFloat.GetType());
Console.WriteLine(myNum.GetType());

/**You have already learned that Console.WriteLine() is used to output (print) values. Now we will use Console.ReadLine() to get user input.

Console.WriteLine("WRİTE YOUR NAME");
string yourName = Console.ReadLine();
Console.WriteLine("welcome " + yourName);
**/

/**
Console.WriteLine("yaşını gir");
int yourAge = Console.ReadLine();

Console.WriteLine($"you are {yourAge} years old"; hata alırız**/

/**Console.WriteLine("enter your age");
int yourAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"you are {yourAge} years old");**/

/**Console.WriteLine("write your  your name ");
string name = Console.ReadLine();
Console.WriteLine("write your jop");
string job = Console.ReadLine();
Console.WriteLine("write your age ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your name is {name}, your job is {job}, and you are {age} years old.");**/



//Operators are used to perform operations on variables and values.

int x = 10;
int y = x+10;
int z = y+10;
Console.WriteLine(string.Format("x: {0}, y: {1}, z: {2}", x, y, z));

Console.WriteLine($"x: {x}, y: {y}, z: {z}");



//(Assignment Operator): Değişkenin değerini atar.

int a = 10;
a += 20;
a -= 3;
a *= 2;
a /= 3;
a %= 3;
a &= 3;
Console.WriteLine(a);
Console.WriteLine(a.GetType());

Console.WriteLine(a==0);
Console.WriteLine(a==1);
Console.WriteLine(a<=2);



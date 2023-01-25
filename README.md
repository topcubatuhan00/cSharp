# cSharp



İskelet


```
namespace demirogCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
        }
     }
}
```



Değiskenler




```
int number = 2;
Console.WriteLine("number is a : {0}",number);


long age = 104654654654;
Console.WriteLine(age);

bool cond = false;
if (cond)
{
    Console.WriteLine("cond is a true");
}else
{
    Console.WriteLine("cond is a false");
}

Console.WriteLine(" ad : ");
string name = "batuhan";
int age = 20;
char gender = 'A';
long phoneNumber = 05555555555;
var message = name+" "+age + " "+gender + " " + phoneNumber;      
Console.WriteLine(message);
```

            

Switch Case


```
switch (gender)
{
case 'E':
Console.WriteLine("erkek");
break;
case 'K':
Console.WriteLine("kadin");
break;
default: 
Console.WriteLine("hata");
break;
}
```


Fonksiyon Çağırma


```
int toplam = sum(8, 2);
Console.WriteLine(toplam);
Console.WriteLine(sum(5,8,12));

Console.WriteLine(SumWithParam(10+8+7+5+9+1));
```


Diziler


```
string[] students = {
"batuhan",
"emre",
"can"
};

foreach (var student in students)
{
Console.WriteLine(student);
}
```


Çok Boyutlu Diziler


```
int[,] matrix = new int[3,3];
matrix[0,0] = 1;
matrix[0,1] = 2;
matrix[0,2] = 3;
matrix[1,0] = 4;
matrix[1,1] = 5;
matrix[1,2] = 6;
matrix[2,0] = 7;
matrix[2,1] = 8;
matrix[2,2] = 9;

for(int i = 0; i<3; i++)
{
for(int j = 0; j < 3; j++)
{
Console.Write(matrix[i,j]);
}
Console.WriteLine(" ");
}
```



Asal Sayı Kontrolü Yapan Fonksiyon


```
public static bool isPrime(int number)
{   
	if (number < 2)
	{
		return false;
	}
	else if (number == 2)
	{
		return true;
	}
	else {
		 for (int i = 2; i<number-1; i++)
		{
			if(number % i == 0)
			{
				return false;
			}
		}
	}
 return true;
 }
```




Parametreli Fonksiyon

```
public static int sum(int a = 1, int b=1)
{
	return a + b;
}
```
        

Method Overloading

```
public static int sum(int a = 1, int b = 1, int c = 1)
{
	return a + b+ c;
}
```


Params

```
public static int SumWithParam(params int[] numbers) {
            return numbers.Sum();
}
```



Claslar


```
public string name { get; set; }
public int age;
public int salary;
public CustomerManager(string name = null, int age = 0, int salary = 0)
{
	Console.WriteLine("constructor");
	this.name = name;
	this.age = age;
	this.salary = salary;
}

public void getContent()
{
	Console.WriteLine("name : " + name + "\nage : " + age + "\nsal : " + salary);
}
```




Interface


En önemli kullanım amacı:

Seneryo şöyle olsun bizim IPerson adında bir interface'imiz olsun ve customer, student sınıfları da bu interface'i implement etsin.
PersonManager sınıfında bulunan sınıfta bu kişileri eklemek için interface olmasa iki adet fonksiyon yazmak zorundaydım.
Artık interface kullandığım için tek sınıfta parametre olarak implement ettikleri interface'i alan bir fonksiyon yazmam yeterli olacak.



Interface olmadan Kullanım


```
class PersonManager{
    public void add(Customer customer){
        Console.WriteLine(customer.name+" added");
    }

    public void add2(Student student){
        Console.WriteLine(student.name + " added");
    }
}

Main.cs
personManager.add(new Customer { name="batuhan", lastName="topcu" });
personManager.add2(new Student { name="berat", lastName="topcu" });
```


Interface Kullanımı


```
class PersonManager{
    public void add(IPerson person){
        Console.WriteLine(person.name+" added");
    }  
}

personManager.add(new Customer { name="batuhan", lastName="topcu" }); 
personManager.add(new Student { name = "berat", lastName = "topcu" });
```

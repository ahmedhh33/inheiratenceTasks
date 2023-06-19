
using inheiratance;
using System.Xml.Linq;

Student s1 = new Student("ahmed", 25, 23332, "power system ");//task1
s1.getInformation();
Console.WriteLine("**************************************************");

//Rectangle R1 = new Rectangle("Blu", 20, 10);//task2
//Console.WriteLine("The area of rectangle = " + R1.area());

Console.WriteLine("**************************************************");

Car c1 = new Car("Toyota", 2008, "Camry", 4);//task3
c1.getviehcleinfo();

Console.WriteLine("**************************************************");

Manager m1 = new Manager("Salem", "AD-4443", "Operation",1200);//task4
m1.employeeInfo();
Console.WriteLine("**************************************************");

Dog A1 = new Dog("ewit", 1, "mammals", "noid");//task5
A1.getAnimalInfo();
A1.doSomthing();
A1.animalSound();
//A1.animalSound();
cat caat = new cat("nnal",2);
caat.doSomthing();
caat.animalSound();
caat.makesound();

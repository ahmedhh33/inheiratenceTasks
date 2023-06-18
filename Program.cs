
using inheiratance;

Student s1 = new Student("ahmed", 25, 23332, "power system ");//task1
s1.getInformation();
Console.WriteLine("**************************************************");

Rectangle R1 = new Rectangle("Blu", 20, 10);//task2
Console.WriteLine("The area of rectangle = " + R1.area());//task3

Console.WriteLine("**************************************************");

Car c1 = new Car("Toyota", 2008, "Camry", 4);//task4
c1.getviehcleinfo();

Console.WriteLine("**************************************************");

Manager m1 = new Manager("Salem", "AD-4443", "Operation",1200);//task5
m1.employeeInfo();

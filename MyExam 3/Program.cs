//task 1


// var a= new List<string>(){"Ali","Madina","Bob","Anora","Tom","Farrukh"};
// int i=0;
// foreach (var item in a)
// {
//     System.Console.WriteLine(i+" "+item);
//     i++;
// }

// a.RemoveAll(x=>x.Count()<4);

// a.Sort();

// foreach (var item in a)
// {
//     System.Console.WriteLine(item);
// }
// string b=Console.ReadLine();


// if (a.Contains(b))
// {
//     Console.WriteLine("Ин ном дар рӯйхат ҳаст.");
// }
// else
// {
//     Console.WriteLine("Ин ном дар рӯйхат нест.");
// }


// int cnt = a.Count(x=>x.StartsWith("A"));

// System.Console.WriteLine(cnt);

//task 2

// List<int> numbers = new List<int> { 5, -3, 12, 0, -7, 8, 15, -1, 20 };

// numbers.RemoveAll(x=>x<0);

// foreach (var item in numbers)
// {
//     System.Console.Write(item+" ");
// }

// System.Console.WriteLine(numbers.Count);

// var s=numbers.Sum();
// var avarage=numbers.Average();

// System.Console.WriteLine($"sum = {s}: avarage = {avarage}");


// int mx=int.MinValue;

// foreach (var item in numbers)
// {
//     if (item > mx)
//     {
//         mx=item;
//     }
// }
// System.Console.WriteLine(mx);


// List<int> n = new List<int>(){};

// foreach (var i in numbers)
// {
//     if (i > 10)
//     {
//         n.Add(i);
//     }
// }
// foreach (var item in n)
// {
//     System.Console.Write(item+" ");
// }

//task 3

// Person person = new Person("Ali", 19);

// Student student = new Student("Abu", 20, "201");

// person.Introduce();
// Console.WriteLine();
// student.Introduce();



//task 4
// List<Vehicle> vehicles = new List<Vehicle>() { };

// Car car = new Car("Bmw",2022,4){};
// Car car2 = new Car("Merc",2025,5){};

// Truck truck = new Truck("Mercedes",1234,5);
// Truck truck2 = new Truck("Toyota",1543,8);

// vehicles.Add(car);
// vehicles.Add(car2);
// vehicles.Add(truck);
// vehicles.Add(truck2);

// foreach (Vehicle i in vehicles)
// {
//     if (i.Year > 2015)
//     {
//         Console.WriteLine(i.GetInfo());
//     }
// }


//task 5

// var dog = new Dog("Rex");
// var bird = new Bird("Tweety");
// var fish = new Fish("Nemo");

// List<Animal> animals = new List<Animal>();

// animals.Add(dog);
// animals.Add(bird);
// animals.Add(fish);

// foreach (var i in animals)
// {
//     i.MakeSound();
//     i.Move();
//     Console.WriteLine("--------------");
// }


// // baroi dog methodi Move() classi Animal davat mewavad, zero dar classi dog methodi Move overide karda nawudaast..

//task 6


//  var circle = new Circle(5);
//         var rectangle = new Rectangle(4, 6);
//         var square = new Square(4);
//         var circle2 = new Circle(3);

//         List<Shape> shapes = new List<Shape>();

//         shapes.Add(circle);
//         shapes.Add(rectangle);
//         shapes.Add(square);
//         shapes.Add(circle2);

//         double allarea = 0;
//         Shape largest = shapes[0];

//         foreach (Shape shape in shapes)
//         {
//             Console.WriteLine($"Name: {shape.Name}");
//             Console.WriteLine($"Area: {shape.GetArea()}");
//             Console.WriteLine($"Perimeter: {shape.GetPerimeter()}");
//             Console.WriteLine();

//             allarea += shape.GetArea();

//             if (shape.GetArea() > largest.GetArea())
//             {
//                 largest = shape;
//             }
//         }

//         Console.WriteLine($"Total area: {allarea}");

//         Console.WriteLine($"Largest shape: {largest.Name}");
//         Console.WriteLine($"Largest area: {largest.GetArea()}");


//task 7

// var account1 = new BankAccount("Ali", 800);
// var account2 = new SavingsAccount("Madina", 800);
// var account3 = new CreditAccount("Bob", 800);

// List<BankAccount> accounts = new List<BankAccount>();

// accounts.Add(account1);
// accounts.Add(account2);
// accounts.Add(account3);

// foreach (BankAccount account in accounts)
// {
//     bool success = account.Withdraw(1000);

//     Console.WriteLine($"Owner: {account.Owner}");

//     if (success)
//     {
//         Console.WriteLine("Result: Бомуваффақият");
//     }
//     else
//     {
//         Console.WriteLine("Result: Рад шуд");
//     }

//     Console.WriteLine($"New balance: {account.Balance}");
//     Console.WriteLine();
// }


//task 8

// var taxi = new Taxi();
// var bus = new Bus();
// var metro = new Metro();

// List<Transport> transports = new List<Transport>();

// transports.Add(taxi);
// transports.Add(bus);
// transports.Add(metro);


// double km = 33;

// Transport cheapest = transports[0];
// double minFare = cheapest.CalculateFare(km);

// foreach (Transport transport in transports)
// {
//     double fare = transport.CalculateFare(km);

//     Console.WriteLine($"{transport.Name}: {fare}");

//     if (fare < minFare)
//     {
//         minFare = fare;
//         cheapest = transport;
//     }
// }

// Console.WriteLine($"Arzontarin: {cheapest.Name} - {minFare}");


//task 9
// var p1 = new Product("Book", 100);
// var p2 = new DiscountedProduct("Laptop", 2000, 10);
// var p3 = new Product("Pen", 20);
// var p4 = new DiscountedProduct("Phone", 1500, 20);

// ShoppingCart cart = new ShoppingCart();

// cart.AddProduct(p1);
// cart.AddProduct(p2);
// cart.AddProduct(p3);
// cart.AddProduct(p4);

// Console.WriteLine("Producthoi sabad:");
// cart.PrintAll();

// Console.WriteLine($"Mablagi umumi: {cart.GetTotal()}");


// bool removed = cart.RemoveProduct("Laptop");

// if (removed)
// {
//     Console.WriteLine("Product delated.");
// }
// else
// {
//     Console.WriteLine("Procut not found.");
// }

// Console.WriteLine("new sabad:");
// cart.PrintAll();

// Console.WriteLine($"Mablagi navi umumi: {cart.GetTotal()}");

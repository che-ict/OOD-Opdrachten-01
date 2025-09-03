# Object-Oriented Development Exercises

Here are 20 exercises on object-oriented programming concepts in C#.

---

## Part 1: Classes, Objects, and Constructors

### Exercise 1: The `Car` Class
**Concept:** Classes and Objects

**Task:** Define a `Car` class with public properties for `Make` (string), `Model` (string), and `Year` (int). Create an instance of the `Car` class and set its properties.

**Usage Sample:**
```csharp
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
}

// To test:
var myCar = new Car
{
    Make = "Toyota",
    Model = "Corolla",
    Year = 2021
};
// Assert that myCar.Make == "Toyota"
```

### Exercise 2: The `Car`'s Display Method
**Concept:** Class Methods

**Task:** Add a method `GetCarInfo()` to the `Car` class that returns a formatted string with the car's make, model, and year.

**Usage Sample:**
```csharp
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public string GetCarInfo()
    {
        return $"Make: {Make}, Model: {Model}, Year: {Year}";
    }
}

// To test:
var myCar = new Car { Make = "Toyota", Model = "Corolla", Year = 2021 };
var carInfo = myCar.GetCarInfo();
// Assert that carInfo == "Make: Toyota, Model: Corolla, Year: 2021"
```

### Exercise 3: The `Student` Class
**Concept:** Classes and Objects

**Task:** Create a `Student` class with properties for `Name` (string), `Age` (int), and `Gpa` (double). Create a few `Student` objects.

**Usage Sample:**
```csharp
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Gpa { get; set; }
}

// To test:
var student1 = new Student { Name = "Alice", Age = 20, Gpa = 3.8 };
var student2 = new Student { Name = "Bob", Age = 21, Gpa = 3.5 };
// Assert that student1.Name == "Alice"
```

### Exercise 4: Scholarship Eligibility
**Concept:** Class Methods

**Task:** Add a method `IsEligibleForScholarship()` to the `Student` class that returns `true` if the student's GPA is 3.5 or higher, and `false` otherwise.

**Usage Sample:**
```csharp
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Gpa { get; set; }

    public bool IsEligibleForScholarship()
    {
        return Gpa >= 3.5;
    }
}

// To test:
var student1 = new Student { Name = "Alice", Gpa = 3.8 };
var student2 = new Student { Name = "Bob", Gpa = 3.4 };
// Assert that student1.IsEligibleForScholarship() is true
// Assert that student2.IsEligibleForScholarship() is false
```

### Exercise 5: The `Car` Constructor
**Concept:** Constructors

**Task:** Refactor the `Car` class to use a constructor to initialize its `Make`, `Model`, and `Year` properties upon creation.

**Usage Sample:**
```csharp
public class Car
{
    public string Make { get; }
    public string Model { get; }
    public int Year { get; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }
}

// To test:
var myCar = new Car("Ford", "Mustang", 2022);
// Assert that myCar.Make == "Ford"
```

### Exercise 6: The `Book` Class
**Concept:** Constructors

**Task:** Create a `Book` class with a constructor that initializes `Title` (string), `Author` (string), and `Isbn` (string).

**Usage Sample:**
```csharp
public class Book
{
    public string Title { get; }
    public string Author { get; }
    public string Isbn { get; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        Isbn = isbn;
    }
}

// To test:
var aBook = new Book("The Hobbit", "J.R.R. Tolkien", "978-0-345-33968-3");
// Assert that aBook.Title == "The Hobbit"
```

### Exercise 7: Overloading the `Book` Constructor
**Concept:** Constructor Overloading

**Task:** Overload the `Book` constructor. Create a second constructor that only takes `Title` and `Author`, and sets a default value for `Isbn` (e.g., "N/A").

**Usage Sample:**
```csharp
public class Book
{
    public string Title { get; }
    public string Author { get; }
    public string Isbn { get; }

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        Isbn = isbn;
    }

    public Book(string title, string author) : this(title, author, "N/A") { }
}

// To test:
var book1 = new Book("The Hobbit", "J.R.R. Tolkien", "978-0-345-33968-3");
var book2 = new Book("Another Book", "Some Author");
// Assert that book2.Isbn == "N/A"
```

### Exercise 8: The `Rectangle` Class
**Concept:** Constructors and Methods

**Task:** Create a `Rectangle` class with a constructor that takes `width` and `height`. Add a method `CalculateArea()` that returns the area of the rectangle.

**Usage Sample:**
```csharp
public class Rectangle
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

// To test:
var rect = new Rectangle(10, 5);
// Assert that rect.CalculateArea() == 50
```

---

## Part 2: Association

### Exercise 9: Teacher and Students
**Concept:** One-to-Many Association

**Task:** Create `Teacher` and `Student` classes. A `Teacher` should have a list of `Student`s. Add a method to the `Teacher` class to add a student to their list.

**Usage Sample:**
```csharp
public class Teacher
{
    public string Name { get; set; }
    private readonly List<Student> _students = new List<Student>();
    public IReadOnlyList<Student> Students => _students.AsReadOnly();

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }
}

// To test:
var teacher = new Teacher { Name = "Mr. Smith" };
var student = new Student { Name = "John Doe" };
teacher.AddStudent(student);
// Assert that teacher.Students.Count == 1
```

### Exercise 10: Doctors and Patients
**Concept:** Many-to-Many Association

**Task:** Create `Doctor` and `Patient` classes. A `Doctor` can have multiple `Patient`s, and a `Patient` can have multiple `Doctor`s.

**Usage Sample:**
```csharp
public class Doctor
{
    public string Name { get; set; }
    public List<Patient> Patients { get; } = new List<Patient>();
}

public class Patient
{
    public string Name { get; set; }
    public List<Doctor> Doctors { get; } = new List<Doctor>();
}

// To test:
var doc1 = new Doctor { Name = "Dr. House" };
var patient1 = new Patient { Name = "Jane Doe" };
doc1.Patients.Add(patient1);
patient1.Doctors.Add(doc1);
// Assert that doc1.Patients.Contains(patient1)
// Assert that patient1.Doctors.Contains(doc1)
```

### Exercise 11: Course Enrollment
**Concept:** One-to-Many Association

**Task:** Create `Course` and `Student` classes. A `Student` can enroll in multiple `Course`s. Add a method to the `Student` class to enroll in a `Course`.

**Usage Sample:**
```csharp
public class Course
{
    public string CourseName { get; set; }
}

public class Student
{
    public string Name { get; set; }
    private readonly List<Course> _courses = new List<Course>();
    public IReadOnlyList<Course> Courses => _courses.AsReadOnly();

    public void Enroll(Course course)
    {
        _courses.Add(course);
    }
}

// To test:
var student = new Student { Name = "Alice" };
var course = new Course { CourseName = "OOD" };
student.Enroll(course);
// Assert that student.Courses.Count == 1
```

### Exercise 12: Flight and Passengers
**Concept:** One-to-Many Association

**Task:** Model a `Flight` and `Passenger` relationship. A `Flight` has multiple `Passenger`s. Add a method to the `Flight` class to add a `Passenger`.

**Usage Sample:**
```csharp
public class Passenger
{
    public string Name { get; set; }
}

public class Flight
{
    public string FlightNumber { get; set; }
    private readonly List<Passenger> _passengers = new List<Passenger>();
    public IReadOnlyList<Passenger> Passengers => _passengers.AsReadOnly();

    public void AddPassenger(Passenger passenger)
    {
        _passengers.Add(passenger);
    }
}

// To test:
var flight = new Flight { FlightNumber = "KL123" };
var passenger = new Passenger { Name = "John Smith" };
flight.AddPassenger(passenger);
// Assert that flight.Passengers.Count == 1
```

---

## Part 3: Aggregation

### Exercise 13: Department and Employees
**Concept:** Aggregation

**Task:** Create `Department` and `Employee` classes. A `Department` has a list of `Employee`s. The `Employee`s can exist independently of the `Department`.

**Usage Sample:**
```csharp
public class Employee
{
    public string Name { get; set; }
}

public class Department
{
    public string Name { get; set; }
    public List<Employee> Employees { get; } = new List<Employee>();
}

// To test:
var employee = new Employee { Name = "Jane Doe" };
var department = new Department { Name = "HR" };
department.Employees.Add(employee);
// Assert that department.Employees.Count == 1
// The employee object still exists if the department is gone.
```

### Exercise 14: Playlist and Songs
**Concept:** Aggregation

**Task:** Model a `Playlist` and `Song` relationship. A `Playlist` contains a list of `Song`s, but the `Song`s can exist independently.

**Usage Sample:**
```csharp
public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }
}

public class Playlist
{
    public string Name { get; set; }
    public List<Song> Songs { get; } = new List<Song>();
}

// To test:
var song = new Song { Title = "Bohemian Rhapsody", Artist = "Queen" };
var playlist = new Playlist { Name = "My Favorites" };
playlist.Songs.Add(song);
// Assert that playlist.Songs.Count == 1
```

### Exercise 15: Team and Players
**Concept:** Aggregation

**Task:** Create `Team` and `Player` classes. A `Team` has a list of `Player`s. The `Player`s can exist independently.

**Usage Sample:**
```csharp
public class Player
{
    public string Name { get; set; }
}

public class Team
{
    public string Name { get; set; }
    public List<Player> Players { get; } = new List<Player>();
}

// To test:
var player = new Player { Name = "Lionel Messi" };
var team = new Team { Name = "FC Barcelona" };
team.Players.Add(player);
// Assert that team.Players.Count == 1
```

### Exercise 16: Shopping Cart and Products
**Concept:** Aggregation

**Task:** Model a `ShoppingCart` and `Product`. The `ShoppingCart` contains `Product`s, which can exist independently.

**Usage Sample:**
```csharp
public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}

public class ShoppingCart
{
    public List<Product> Products { get; } = new List<Product>();
    
    public double GetTotalPrice()
    {
        return Products.Sum(p => p.Price);
    }
}

// To test:
var product1 = new Product { Name = "Milk", Price = 2.50 };
var cart = new ShoppingCart();
cart.Products.Add(product1);
// Assert that cart.GetTotalPrice() == 2.50
```

---

## Part 4: Composition

### Exercise 17: House and Rooms
**Concept:** Composition

**Task:** Create a `House` and `Room` class. The `House` is composed of `Room` objects. The `Room` objects are created when the `House` is created and cannot exist independently.

**Usage Sample:**
```csharp
public class Room
{
    public string Name { get; }
    public Room(string name) { Name = name; }
}

public class House
{
    public List<Room> Rooms { get; } = new List<Room>();

    public House()
    {
        Rooms.Add(new Room("Living Room"));
        Rooms.Add(new Room("Kitchen"));
    }
}

// To test:
var house = new House();
// Assert that house.Rooms.Count == 2
```

### Exercise 18: Car and Engine
**Concept:** Composition

**Task:** Model a `Car` and an `Engine`. The `Car` has an `Engine`. The `Engine` is part of the `Car` and is created with the `Car`.

**Usage Sample:**
```csharp
public class Engine
{
    public string Type { get; }
    public Engine(string type) { Type = type; }
}

public class Car
{
    public Engine CarEngine { get; }

    public Car(string engineType)
    {
        CarEngine = new Engine(engineType);
    }
}

// To test:
var car = new Car("V8");
// Assert that car.CarEngine.Type == "V8"
```

### Exercise 19: Person and Heart
**Concept:** Composition

**Task:** Create a `Person` and `Heart` class. A `Person` has a `Heart`. The `Heart` is created with the `Person`.

**Usage Sample:**
```csharp
public class Heart
{
    public int Bpm { get; set; } = 70;
}

public class Person
{
    public string Name { get; }
    public Heart PersonHeart { get; }

    public Person(string name)
    {
        Name = name;
        PersonHeart = new Heart();
    }
}

// To test:
var person = new Person("John");
// Assert that person.PersonHeart.Bpm == 70
```

### Exercise 20: Computer and CPU
**Concept:** Composition

**Task:** Model a `Computer` and a `CPU`. The `Computer` is composed of a `CPU`. The `CPU` is created with the `Computer`.

**Usage Sample:**
```csharp
public class CPU
{
    public string Model { get; }
    public CPU(string model) { Model = model; }
}

public class Computer
{
    public string Name { get; }
    public CPU Processor { get; }

    public Computer(string name, string cpuModel)
    {
        Name = name;
        Processor = new CPU(cpuModel);
    }
}

// To test:
var computer = new Computer("My PC", "Intel i9");
// Assert that computer.Processor.Model == "Intel i9"
```

---

## Part 5: Encapsulation

### Exercise 21: Bank Account
**Concept:** Encapsulation

**Task:** Create a `BankAccount` class with a private `_balance` field. Provide a public `GetBalance()` method, a `Deposit(decimal amount)` method, and a `Withdraw(decimal amount)` method. The `Deposit` method should only allow positive amounts, and the `Withdraw` method should not allow the balance to go below zero.

**Usage Sample:**
```csharp
public class BankAccount
{
    private decimal _balance;

    public BankAccount(decimal startingBalance)
    {
        _balance = startingBalance;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
        }
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > 0 && _balance >= amount)
        {
            _balance -= amount;
            return true;
        }
        return false;
    }
}

// To test:
var account = new BankAccount(100);
account.Deposit(50);
// Assert that account.GetBalance() == 150
var success = account.Withdraw(100);
// Assert that success is true and account.GetBalance() == 50
var failure = account.Withdraw(100);
// Assert that failure is false and account.GetBalance() == 50
```

### Exercise 22: Employee Salary
**Concept:** Encapsulation

**Task:** Create an `Employee` class with a private `_salary` field. Provide a public `GetSalary()` method and a `SetSalary(decimal newSalary)` method that ensures the new salary is not negative.

**Usage Sample:**
```csharp
public class Employee
{
    private decimal _salary;

    public Employee(decimal initialSalary)
    {
        SetSalary(initialSalary);
    }

    public decimal GetSalary()
    {
        return _salary;
    }

    public void SetSalary(decimal newSalary)
    {
        if (newSalary >= 0)
        {
            _salary = newSalary;
        }
    }
}

// To test:
var employee = new Employee(50000);
// Assert that employee.GetSalary() == 50000
employee.SetSalary(60000);
// Assert that employee.GetSalary() == 60000
employee.SetSalary(-1000);
// Assert that employee.GetSalary() == 60000
```

### Exercise 23: Temperature Sensor
**Concept:** Encapsulation

**Task:** Create a `TemperatureSensor` class with a private `_temperature` field (in Celsius). Provide a `GetTemperature()` method and a `SetTemperature(double temp)` method that only allows temperatures within a realistic range (e.g., -50 to 150 Celsius).

**Usage Sample:**
```csharp
public class TemperatureSensor
{
    private double _temperature;

    public double GetTemperature()
    {
        return _temperature;
    }

    public void SetTemperature(double temp)
    {
        if (temp >= -50 && temp <= 150)
        {
            _temperature = temp;
        }
    }
}

// To test:
var sensor = new TemperatureSensor();
sensor.SetTemperature(25);
// Assert that sensor.GetTemperature() == 25
sensor.SetTemperature(200);
// Assert that sensor.GetTemperature() == 25
```

### Exercise 24: Student Grades
**Concept:** Encapsulation

**Task:** Create a `Student` class that holds a private list of grades. Provide a public method `AddGrade(double grade)` that validates the grade is between 0 and 10. Also, provide a method `GetAverageGrade()` to calculate the average.

**Usage Sample:**
```csharp
public class Student
{
    private readonly List<double> _grades = new List<double>();

    public void AddGrade(double grade)
    {
        if (grade >= 0 && grade <= 10)
        {
            _grades.Add(grade);
        }
    }

    public double GetAverageGrade()
    {
        if (_grades.Count == 0)
        {
            return 0;
        }
        return _grades.Average();
    }
}

// To test:
var student = new Student();
student.AddGrade(8.5);
student.AddGrade(9.0);
student.AddGrade(11.0); // Invalid grade
// Assert that student.GetAverageGrade() is close to 8.75
```
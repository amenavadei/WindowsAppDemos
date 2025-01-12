string FirstName;
string LastName;
int age;
decimal salary;




Console.Write("Enter your First Name:");
FirstName = Console.ReadLine();


Console.Write("Enter your Last Name: ");
LastName = Console.ReadLine();


Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your Salary: ");
salary = Convert.ToDecimal(Console.ReadLine());



Console.Write("Your First Name is: " + FirstName);
Console.Write("\nYour Last Name is: " +  LastName);
Console.Write("\nYour Age is: " + age + " and your salary is: " + salary);

Console.WriteLine("\n********************************");

int cow = 0;
string word = "";
string? firstName = string.Empty;
string lastName;
decimal salary;
char? gender = char.MinValue;
bool working = true;
int age;

//Prompt the User 


Console.Write("Please enter your name: " );
firstName = Console.ReadLine();


Console.Write("Enter your LastName: ");
lastName = Console.ReadLine();


Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());



Console.Write("Enter your salary: ");
salary = Convert.ToDecimal( Console.ReadLine());


Console.Write("Please enter your gender (M or F): ");
gender = Convert.ToChar( Console.ReadLine());

Console.Write("Are you working? (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

Console.WriteLine("***************************************************************");

//Process the data 

Console.WriteLine("Your name is: " + firstName + "\nYour lastName is : " + lastName + " \nYour age is: " + age);
Console.WriteLine("Your Salary is: " + salary + "\nYour gender is: " + gender + "\nWorking status is " + working);



 



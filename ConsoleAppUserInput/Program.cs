
int cow = 0;
string word = "";
string firstName = "";



Console.WriteLine(" Please enter your name: " );
string firstname = Console.ReadLine();


Console.WriteLine("Please enter your age: ");
string input = Console.ReadLine();
int age = int.Parse(input);


Console.WriteLine("Please enter total number of cows: ");
cow = Convert.ToInt32( Console.ReadLine());



Console.WriteLine("Your name is: " + firstname + " and your age is: " + age + " and total number of cows is: " + cow);


Console.WriteLine("Enter your best Word:");
word = Console.ReadLine();

Console.WriteLine("Your best word is: " + word);
 


//string country = "";

//Console.WriteLine("Please enter the COuntry Name you live in:?");
//country= Console.ReadLine();

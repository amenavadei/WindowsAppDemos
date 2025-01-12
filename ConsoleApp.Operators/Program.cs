

int num1 =0;
int num2 =0;
int sum; 



Console.Write("Enter the first number: ");
num1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Enter the second number: ");
num2 = Convert.ToInt32(Console.ReadLine());



sum = (num1 + num2);
int product = num1 * num2;
int quotation = num1 / num2;
int difference = num1 - num2;
int mod = num1 % num2;

Console.Write(" The sum of the two numbers is : " + sum);

Console.Write("\n The product of the two numbers is : " + product);

Console.Write("\n The quotation of the two numbers is : " + quotation);

Console.Write("\n The difference of the two numbers is : " + difference);


/*
    Logic Operations and Operators 
 

 */



Console.WriteLine("\n\n*********************Logic Operations and Operators******************************************");




bool isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
bool isEqualTo = num1 == num2;
bool isGreaterThanOrEqualTo = num1 >= num2;
bool isNotEqual = num1 != num2;

Console.WriteLine("\nIs greater than: " + isGreaterThan);
Console.WriteLine("\nIs Less than: " + isLessThan); 
Console.WriteLine("\nIs Equal too : " + isEqualTo); 
Console.WriteLine("\nIs Greater  than Or Equal to : " + isGreaterThanOrEqualTo);
Console.WriteLine("\nIs Not Equal to : " + isNotEqual);

Console.WriteLine("\n*********************End******************************************\n");


Console.WriteLine("\n\n*********************Assignment Operators******************************************");




//Console.WriteLine("*********************************Assignment Results*************************");
num1 += 5;
Console.WriteLine("\nNumber 1 is increased by 5: " + num1);


num1 -= 3;
Console.WriteLine("\nNumber1 is reduced by 3: " + num1);

num1 /= 2;
Console.WriteLine("\n Number1 is divided  by 2: " + num1);
num1 %= 2;
Console.WriteLine("\nNumber1 module by 2: " + num1);
num1 *= 10;
Console.WriteLine("\n Number1 is multiply  by 10: " + num1);




Console.WriteLine();




































string a = Console.ReadLine();
string b = Console.ReadLine();
Convert.ToDouble(a);
Convert.ToDouble(b);

(a, b) = (b, a);

Console.WriteLine($"Value a is: {a} but should be {b}");
Console.WriteLine($"Value b is: {b} but should be {a}");
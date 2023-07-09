string inputText = "";
string inputText2 = "";

(bool, int) IsInteger(string input, int number = 0)
{
    return (int.TryParse(input, out number), number); // it returns two value. we can use first or second when we need
}

void InvalidInputError()
{
    Console.WriteLine("Girdiğiniz bir sayı değil.");
}

while (!IsInteger(inputText).Item1)
{
    Console.Write("Bir sayı giriniz: ");
    inputText = Console.ReadLine();

    if (!IsInteger(inputText).Item1)
    {
        InvalidInputError();
    }
}

while (!IsInteger(inputText2).Item1)
{
    Console.Write("2. bir sayı giriniz: ");
    inputText2 = Console.ReadLine();

    if (!IsInteger(inputText2).Item1)
    {
        InvalidInputError();
    }
}

for (int i = 0; i < IsInteger(inputText2).Item2; i++) // i didnt use a variable for here, but the new function i wrote is suitable for usage from anywhere
{
    Console.WriteLine("Girdiğiniz sayı: " + inputText);
}

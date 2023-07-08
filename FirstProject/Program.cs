string inputText = "";
string inputText2 = "";

bool IsInteger(string input, int number = 0) // we just need this function for bool thing. result is useless in TryParse()
{
    return int.TryParse(input, out number);
}

void InvalidInputError()
{
    Console.WriteLine("Girdiğiniz bir sayı değil.");
}

while (!IsInteger(inputText))
{
    Console.Write("Bir sayı giriniz: ");
    inputText = Console.ReadLine();

    if (!IsInteger(inputText))
    {
        InvalidInputError();
    }
}

while (!IsInteger(inputText2))
{
    Console.Write("2. bir sayı giriniz: ");
    inputText2 = Console.ReadLine();

    if (!IsInteger(inputText2))
    {
        InvalidInputError();
    }
}

for (int i = 0; i < Convert.ToInt32(inputText2); i++)
{
    Console.WriteLine("Girdiğiniz sayı: " + inputText);
}

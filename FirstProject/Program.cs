string inputText = "";
int inputNumber;

bool isInteger()
{
    return int.TryParse(inputText, out inputNumber);
}

while (!isInteger())
{
    Console.Write("Bir sayı giriniz: ");
    inputText = Console.ReadLine();

    if (isInteger()) {
        Console.WriteLine("Girdiğiniz sayı: " + inputNumber);
    } else
    {
        Console.WriteLine("Girdiğiniz bir sayı değil.");
    }
}

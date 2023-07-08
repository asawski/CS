start:
Console.Write("Bir sayı giriniz: ");

string input = Console.ReadLine();
int Int;
bool isInteger = int.TryParse(input, out Int);

if (isInteger) {
    Console.WriteLine("Girdiğiniz sayı: " + Int);
} else
{
    Console.WriteLine("Girdiğiniz bir sayı değil.");
    goto start;
}

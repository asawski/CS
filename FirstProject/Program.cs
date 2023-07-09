string inputText = "";
string inputText2 = "";

int numberForPrint;
bool isValidDataEntered = false;
do
{
    Console.Write("Bir sayı giriniz: ");
    inputText = Console.ReadLine();

    if (!IsInteger(inputText, out numberForPrint))
    {
        InvalidInputError();
    }
    else
    {
        isValidDataEntered = true;
    }
}
while (!isValidDataEntered &&!inputText.Equals("EXIT"));

int loopCount;
isValidDataEntered = false;
do
{
    Console.Write("2. bir sayı giriniz: ");
    inputText2 = Console.ReadLine();

    if (!IsInteger(inputText2, out loopCount))
    {
        InvalidInputError();
    }
    else
    {
        isValidDataEntered= true;
    }
}
while (!isValidDataEntered && !inputText2.Equals("EXIT"));

for (int i = 0; i < loopCount; i++) // i didnt use a variable for here, but the new function i wrote is suitable for usage from anywhere
{
    Console.WriteLine("Girdiğiniz sayı: " + numberForPrint);
}

bool IsInteger(string inputText, out int number)
{
    return int.TryParse(inputText, out number); // try to parse entered value, otherwise returns false
}

void InvalidInputError()
{
    Console.WriteLine("Girdiğiniz veri bir sayı değil.");
}
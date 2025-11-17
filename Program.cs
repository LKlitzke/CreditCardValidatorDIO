using CreditCardValidatorDIO;

var keepAlive = true;

do
{
    Console.WriteLine("------------ CREDIT CARD BRAND VALIDATOR ------------");
    Console.WriteLine("Enter the credit card number:");
    string? cardNumber = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(cardNumber))
    {
        Console.WriteLine("Credit card number cannot be empty.");
        return;
    }

    var brand = CreditCardValidator.IdentifyBrand(cardNumber);

    Console.WriteLine($"\n>>> Card Brand: {brand}. Press ENTER to restart OR '0' to exit.");
    var input = Console.ReadLine();

    if (input == "0")
    {
        keepAlive = false;
        Console.WriteLine($"\nExiting...");
        Console.ReadKey();
        continue;
    }

    Console.WriteLine($"\nRestarting...");
    Console.ReadKey();
    Console.Clear();
} while (keepAlive);
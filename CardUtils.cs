using System.Text.RegularExpressions;

namespace CreditCardValidatorDIO.CardUtils
{
    /// <summary>
    /// Represents the rules for a specific credit card brand using Regex.
    /// </summary>
    public class CardBrand
    {
        public string Name { get; }
        private readonly Regex _pattern;

        public CardBrand(string name, Regex pattern)
        {
            Name = name;
            _pattern = pattern;
        }

        public bool IsMatch(string cardNumber) => _pattern.IsMatch(cardNumber);
    }

    /// <summary>
    /// Validates and identifies the brand of a credit card number.
    /// </summary>
    public static class CreditCardValidator
    {
        private static readonly List<CardBrand> Brands;

        static CreditCardValidator()
        {
            // RegexOptions.Compiled improves performance for frequently used regexes.
            const RegexOptions options = RegexOptions.Compiled | RegexOptions.Singleline;

            Brands = new List<CardBrand>
            {
                new("American Express", new Regex(@"^(34|37)\d{13}$", options)),
                new("Diners Club", new Regex(@"^(30[0-5]\d{11}|(36|38)\d{12})$", options)),
                new("Discover", new Regex(@"^(6011\d{12}|65\d{14})$", options)),
                new("EnRoute", new Regex(@"^(2014|2149)\d{11}$", options)),
                new("JCB", new Regex(@"^35\d{13,14}$", options)),
                new("MasterCard", new Regex(@"^5[1-5]\d{14}$", options)),
                new("Visa", new Regex(@"^4(\d{12}|\d{15})$", options)),
                new("Voyager", new Regex(@"^8699\d{11}$", options)),
                new("HiperCard", new Regex(@"^606282\d{10}$", options)),
                new("Aura", new Regex(@"^50\d{14}$", options))
            };
        }

        /// <summary>
        /// Identifies the credit card brand from the card number.
        /// </summary>
        /// <param name="cardNumber">The credit card number.</param>
        /// <returns>The name of the brand or "Unknown".</returns>
        public static string IdentifyBrand(string cardNumber)
        {
            // Normalize the card number by removing non-digit characters
            string normalizedNumber = new string(cardNumber.Where(char.IsDigit).ToArray());

            if (string.IsNullOrEmpty(normalizedNumber))
            {
                return "Invalid input";
            }

            foreach (var brand in Brands)
            {
                if (brand.IsMatch(normalizedNumber))
                {
                    return brand.Name;
                }
            }

            return "Unknown";
        }
    }
}
using System.Text.RegularExpressions;

namespace CreditCardValidatorDIO
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
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Babcock_Olivia
{
    // Creates class for Card.
    internal class Card
    {
        // Creates string and get property.
        public string Number { get; }

        // Creates string and get property.
        public string Suit { get; }

        // Sets string parameters.
        public Card(string numParam, string suitParam)
        {
            Number = numParam;
            Suit = suitParam;
        }
    }
    
}

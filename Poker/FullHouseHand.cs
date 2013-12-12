// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FullHouseHand.cs" company="Christian Coda">
//   Copyright (c) Christian Coda 2013
// </copyright>
// <summary>
//   The Full House Hand.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    using System.Collections.Generic;

    /// <summary>The full house hand.</summary>
    public class FullHouseHand : ThreeOfAKindHand
    {
        /// <summary>Initializes a new instance of the <see cref="FullHouseHand"/> class.</summary>
        /// <param name="cards">The cards.</param>
        public FullHouseHand(IEnumerable<Card> cards)
            : base(cards, 60)
        {
        }
    }
}
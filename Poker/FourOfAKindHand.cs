// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FourOfAKindHand.cs" company="Christian Coda">
//   Copyright (c) Christian Coda 2013
// </copyright>
// <summary>
//   The four of a kind hand.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    using System.Collections.Generic;

    /// <summary>The four of a kind hand.</summary>
    public class FourOfAKindHand : NOfAKindHand
    {
        /// <summary>Initializes a new instance of the <see cref="FourOfAKindHand"/> class.</summary>
        /// <param name="cards">The cards.</param>
        public FourOfAKindHand(IEnumerable<Card> cards)
            : base(cards, 70, 4)
        {
        }
    }
}
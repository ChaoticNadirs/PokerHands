// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThreeOfAKindHand.cs" company="Christian Coda">
//   Copyright (c) Christian Coda 2013
// </copyright>
// <summary>
//   The three of a kind hand.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    using System.Collections.Generic;

    /// <summary>The three of a kind hand.</summary>
    public class ThreeOfAKindHand : NOfAKindHand
    {
        /// <summary>Initializes a new instance of the <see cref="ThreeOfAKindHand"/> class.</summary>
        /// <param name="cards">The cards.</param>
        public ThreeOfAKindHand(IEnumerable<Card> cards)
            : base(cards, 30, 3)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="ThreeOfAKindHand"/> class.</summary>
        /// <param name="cards">The cards.</param>
        /// <param name="rank">The rank.</param>
        public ThreeOfAKindHand(IEnumerable<Card> cards, int rank)
            : base(cards, rank, 3)
        {
        }
    }
}
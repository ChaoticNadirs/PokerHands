// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TwoPairsHand.cs" company="Christian Coda">
//   Copyright (c) Christian Coda 2013
// </copyright>
// <summary>
//   The two pair hand.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    using System.Collections.Generic;

    /// <summary>The two pairs hand.</summary>
    public class TwoPairsHand : PairHand
    {
        /// <summary>Initializes a new instance of the <see cref="TwoPairsHand"/> class.</summary>
        /// <param name="cards">The cards.</param>
        public TwoPairsHand(IEnumerable<Card> cards)
            : base(cards, 20)
        {
        }
    }
}
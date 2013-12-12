// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StraightFlushHand.cs" company="Christian Coda">
//   Copyright (c) Christian Coda 2013
// </copyright>
// <summary>
//   The straight flush hand.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    using System.Collections.Generic;

    /// <summary>The straight flush hand.</summary>
    public class StraightFlushHand : StraightHand
    {
        /// <summary>Initializes a new instance of the <see cref="StraightFlushHand"/> class.</summary>
        /// <param name="cards">The cards.</param>
        public StraightFlushHand(IEnumerable<Card> cards)
            : base(cards, 80)
        {
        }
    }
}
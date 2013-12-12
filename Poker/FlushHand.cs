// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FlushHand.cs" company="Christian Coda">
//   Copyright (c) Christian Coda 2013
// </copyright>
// <summary>
//   The Flush Hand.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    using System.Collections.Generic;

    /// <summary>The flush hand.</summary>
    public class FlushHand : Hand
    {
        /// <summary>Initializes a new instance of the <see cref="FlushHand"/> class.</summary>
        /// <param name="cards">The cards.</param>
        public FlushHand(IEnumerable<Card> cards)
            : base(cards, 50)
        {
        }

        /// <summary>The compare to.</summary>
        /// <param name="other">The other.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public override int CompareTo(Hand other)
        {
            int result = base.CompareTo(other);

            if (result == 0)
            {
                result = this.CompareHighestCards(this.Cards, other.Cards);
            }

            return result;
        }
    }
}
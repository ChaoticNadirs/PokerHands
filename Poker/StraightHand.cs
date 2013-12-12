// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StraightHand.cs" company="Christian Coda">
//   Copyright (c) Christian Coda 2013
// </copyright>
// <summary>
//   The Straight Hand.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    using System.Collections.Generic;

    /// <summary>The straight hand.</summary>
    public class StraightHand : Hand
    {
        /// <summary>Initializes a new instance of the <see cref="StraightHand"/> class.</summary>
        /// <param name="cards">The cards.</param>
        public StraightHand(IEnumerable<Card> cards)
            : base(cards, 40)
        {
        }

        /// <summary>Initializes a new instance of the <see cref="StraightHand"/> class.</summary>
        /// <param name="cards">The cards.</param>
        /// <param name="rank">The rank.</param>
        protected StraightHand(IEnumerable<Card> cards, int rank)
            : base(cards, rank)
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
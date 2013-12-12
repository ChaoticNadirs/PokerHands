// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NOfAKindHand.cs" company="Christian Coda">
//   Copyright (c) Christian Coda 2013
// </copyright>
// <summary>
//   The n of a kind hand.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>The N of a kind hand.</summary>
    public abstract class NOfAKindHand : Hand
    {
        /// <summary>The number of kind.</summary>
        private readonly int numOfKind;

        /// <summary>Initializes a new instance of the <see cref="NOfAKindHand"/> class.</summary>
        /// <param name="cards">The cards.</param>
        /// <param name="rank">The rank.</param>
        /// <param name="numOfKind">The number of a kind.</param>
        protected NOfAKindHand(IEnumerable<Card> cards, int rank, int numOfKind)
            : base(cards, rank)
        {
            this.numOfKind = numOfKind;
        }

        /// <summary>The compare to.</summary>
        /// <param name="other">The other.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public override int CompareTo(Hand other)
        {
            int result = base.CompareTo(other);

            if (result == 0)
            {
                int thisKindValue = this.Cards.First(c => this.Cards.Count(x => x.Value == c.Value) == this.numOfKind).Value;
                int otherKindValue = other.Cards.First(c => other.Cards.Count(x => x.Value == c.Value) == this.numOfKind).Value;

                if (thisKindValue < otherKindValue)
                {
                    result = -1;
                }
                else
                {
                    result = 1;
                }
            }

            return result;
        }
    }
}
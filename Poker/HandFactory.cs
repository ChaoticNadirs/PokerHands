// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HandFactory.cs" company="Christian Coda">
//   Copyright (c) Christian Coda 2013
// </copyright>
// <summary>
//   The hand factory.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>The hand factory.</summary>
    public static class HandFactory
    {
        /// <summary>The get hand.</summary>
        /// <param name="cards">The cards.</param>
        /// <returns>The <see cref="Hand"/>.</returns>
        public static Hand GetHand(List<Card> cards)
        {
            if (IsPair(cards))
            {
                return new PairHand(cards);
            }

            if (Is2Pairs(cards))
            {
                return new TwoPairsHand(cards);
            }

            if (Is3OfAKind(cards))
            {
                return new ThreeOfAKindHand(cards);
            }

            if (IsStraight(cards))
            {
                return IsFlush(cards) ? new StraightFlushHand(cards) : new StraightHand(cards);
            }

            if (IsFlush(cards))
            {
                return new FlushHand(cards);
            }

            if (IsFullHouse(cards))
            {
                return new FullHouseHand(cards);
            }

            if (Is4OfAKind(cards))
            {
                return new FourOfAKindHand(cards);
            }

            return new HighCardHand(cards);
        }

        /// <summary>The is pair.</summary>
        /// <param name="cards">The cards.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private static bool IsPair(IEnumerable<Card> cards)
        {
            return cards.Select(x => x.Value).Distinct().Count() == 4;
        }

        /// <summary>The is 2 pairs.</summary>
        /// <param name="cards">The cards.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private static bool Is2Pairs(List<Card> cards)
        {
            return cards.Count(c => cards.Count(x => x.Value == c.Value) == 2) == 4;
        }

        /// <summary>The is 3 of a kind.</summary>
        /// <param name="cards">The cards.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private static bool Is3OfAKind(List<Card> cards)
        {
            return cards.Count(c => cards.Count(x => x.Value == c.Value) == 3) == 3 && cards.Select(x => x.Value).Distinct().Count() == 3;
        }

        /// <summary>The is straight.</summary>
        /// <param name="cards">The cards.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private static bool IsStraight(List<Card> cards)
        {
            bool straight = false;

            if (cards.Select(x => x.Value).Distinct().Count() == 5)
            {
                straight = cards[cards.Count() - 1].Value == cards[0].Value + cards.Count() - 1;
            }

            return straight;
        }

        /// <summary>The is flush.</summary>
        /// <param name="cards">The cards.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private static bool IsFlush(IEnumerable<Card> cards)
        {
            return cards.Select(x => x.Suit).Distinct().Count() == 1;
        }

        /// <summary>The is full house.</summary>
        /// <param name="cards">The cards.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private static bool IsFullHouse(List<Card> cards)
        {
            return cards.Count(c => cards.Count(x => x.Value == c.Value) == 3) == 3 && cards.Count(c => cards.Count(x => x.Value == c.Value) == 2) == 2;
        }

        /// <summary>The is 4 of a kind.</summary>
        /// <param name="cards">The cards.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        private static bool Is4OfAKind(List<Card> cards)
        {
            return cards.Count(c => cards.Count(x => x.Value == c.Value) == 4) == 4;
        }
    }
}
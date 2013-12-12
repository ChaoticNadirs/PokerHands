// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokerScorer.cs" company="Christian Coda">
//   Copyright (c) Christian Coda 2013
// </copyright>
// <summary>
//   Defines the PokerScorer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace Poker
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>The poker scorer.</summary>
    public class PokerScorer
    {
        /// <summary>Scores a poker game.</summary>
        /// <param name="cards">A string of 10 cards in the format [value][suit] separated by spaces.
        ///     The first 5 are for player 1, the last 5 for player 2.</param>
        /// <returns>True if player 1 wins, else false if player 2 wins.</returns>
        public bool ScoreGame(string cards)
        {
            Hand player1Hand, player2Hand;
            GetPlayerHands(cards, out player1Hand, out player2Hand);

            bool player1Won = player1Hand.CompareTo(player2Hand) > 0;

            return player1Won;
        }

        /// <summary>The char to suit.</summary>
        /// <param name="c">The c.</param>
        /// <returns>The <see cref="Suit"/>.</returns>
        private static Suit CharToSuit(char c)
        {
            Suit suit;

            switch (c)
            {
                case 'D':
                    suit = Suit.Diamonds;
                    break;
                case 'C':
                    suit = Suit.Clubs;
                    break;
                case 'H':
                    suit = Suit.Hearts;
                    break;
                default:
                    suit = Suit.Spades;
                    break;
            }

            return suit;
        }

        /// <summary>The char to value.</summary>
        /// <param name="c">The c.</param>
        /// <returns>The <see cref="int"/>.</returns>
        private static int CharToValue(char c)
        {
            int value;

            bool success = int.TryParse(c.ToString(), out value);

            if (!success)
            {
                switch (c)
                {
                    case 'T':
                        value = 10;
                        break;
                    case 'J':
                        value = 11;
                        break;
                    case 'Q':
                        value = 12;
                        break;
                    case 'K':
                        value = 13;
                        break;
                    case 'A':
                        value = 14;
                        break;
                }
            }

            return value;
        }

        /// <summary>The get player cards.</summary>
        /// <param name="cardString">The cards.</param>
        /// <param name="player1Hand">The player 1 Hand.</param>
        /// <param name="player2Hand">The player 2 Hand.</param>
        private static void GetPlayerHands(string cardString, out Hand player1Hand, out Hand player2Hand)
        {
            cardString = cardString.Trim();

            List<Card> player1Cards = cardString.Split(' ').Take(5).Select(StringToCard).OrderBy(x => x.Value).ToList();
            List<Card> player2Cards = cardString.Split(' ').Skip(5).Select(StringToCard).OrderBy(x => x.Value).ToList();

            player1Hand = HandFactory.GetHand(player1Cards);
            player2Hand = HandFactory.GetHand(player2Cards);
        }

        /// <summary>The string to card.</summary>
        /// <param name="cardString">The card string.</param>
        /// <returns>The <see cref="Card"/>.</returns>
        private static Card StringToCard(string cardString)
        {
            int value = CharToValue(cardString[0]);
            Suit suit = CharToSuit(cardString[1]);

            return new Card { Value = value, Suit = suit };
        }
    }
}
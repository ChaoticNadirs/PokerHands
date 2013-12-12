// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Christian Coda">
//   Copyright (c) Christian Coda 2013
// </copyright>
// <summary>
//   The program.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Poker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Poker.Properties;

    /// <summary>The program.</summary>
    public class Program
    {
        /// <summary>The main.</summary>
        /// <param name="args">The args.</param>
        public static void Main(string[] args)
        {
            List<string> games = Resources.poker.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var scorer = new PokerScorer();
            var player1Wins = new List<string>();
            var player2Wins = new List<string>();

            DateTime start = DateTime.Now;

            foreach (var game in games)
            {
                bool player1Won = scorer.ScoreGame(game);

                if (player1Won)
                {
                    player1Wins.Add(game);
                }
                else
                {
                    player2Wins.Add(game);
                }
            }

            var elapsed = DateTime.Now - start;

            Console.WriteLine("Player 1 won: " + player1Wins.Count + " games.");
            Console.WriteLine("Player 2 won: " + player2Wins.Count + " games.");
            Console.WriteLine("Time taken: " + elapsed.TotalMilliseconds + "ms");
            Console.ReadLine();
        }
    }
}
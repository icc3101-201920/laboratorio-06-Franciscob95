using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_5_OOP_201902
{
    static class Visualization
    {
        public static void ShowHand (Hand hand)
        {
            foreach (Cards.Card c in hand.Cards)
            {
                if (c.GetType().Name == nameof(Cards.CombatCard))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(hand.Cards.IndexOf(c) + c.Name);
                    Console.ResetColor();
                }
                else if (c.GetType().Name == nameof(Cards.SpecialCard))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(hand.Cards.IndexOf(c) + c.Name);
                    Console.ResetColor();
                }
            }
        }
        public static void ShowDeck (List<Deck> decks)
        {
            foreach (Deck d in Game.decks)
            {

            }
        }
        public static void ShowCaptains(List<Cards.SpecialCard> captains)
        {

        }
        public static void GetUserInput(int maxInput, bool stopper = false)
        {

        }
        public static void ConsoleError(string message)
        {

        }
        public static void ShowProgramMessage(string message)
        {

        }
        public static void ShowListOptions(List<string> options, string message = null)
        {

        }
    }
}

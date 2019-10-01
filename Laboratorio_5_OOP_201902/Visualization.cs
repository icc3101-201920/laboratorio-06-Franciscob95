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
            foreach (Deck d in decks)
            {
                Console.WriteLine(d);
            }
        }
        public static void ShowCaptains(List<Cards.SpecialCard> captains)
        {
            foreach (Cards.SpecialCard sc in captains)
            {
                if (sc.Type == Enums.EnumType.captain)
                {
                    Console.WriteLine(sc);
                }
            }
        }
        public static void GetUserInput(int maxInput, bool stopper = false)
        {
            Console.WriteLine("Ingrese un valor entre 0 y " + maxInput);
            var resp = Console.ReadLine();
            int numResp;
            bool parseSuccess = int.TryParse(resp, out numResp);
            if (parseSuccess == true)
            {
                if (stopper == true)
                {
                    if (-1 <= numResp && numResp <= maxInput)
                    {

                    }
                }
                else if (stopper == false)
                {
                    if (0 <= numResp && numResp <= maxInput)
                    {

                    }
                }
                else
                {
                    Visualization.ConsoleError("El numero ingresado no esta dentro de los parámetros permitidos");
                }
            }
            else
            {
                Visualization.ConsoleError("El valor ingresado no es un numero");
            }
        }
        public static void ConsoleError(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            ConsoleError(message);
            Console.ResetColor();
        }
        public static void ShowProgramMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void ShowListOptions(List<string> options, string message = null)
        {
            if (message != null)
            {
                Console.WriteLine(message);
                foreach (string op in options)
                {
                    Console.WriteLine(op);
                }
            }
            else
            {
                foreach(string op in options)
                {
                    Console.WriteLine(op);
                }
            }
        }
        public static void ClearConsole()
        {
            Console.Clear();
        }
    }
}

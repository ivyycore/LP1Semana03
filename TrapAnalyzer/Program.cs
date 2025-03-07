using System;
using System.Linq;

namespace TrapAnalyzer
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            TrapType trap = Enum.Parse<TrapType>(args[0]);
            PlayerGear gear = ParseGear(args);
            bool survives = CanSurviveTrap(trap, gear);
            DisplayResult(trap, survives);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the player gear.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The player gear.</returns>
        private static PlayerGear ParseGear(string[] args)
        {
            PlayerGear gearused = PlayerGear.Helmet | PlayerGear.Shield | PlayerGear.Boots;
            foreach (PlayerGear gear in Enum.GetValues(typeof(PlayerGear)))
            {
                gearused &= gear;
            }
            return gearused;
        }

        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trap">The trap the player falls into.</param>
        /// <param name="gear">The gear the player has.</param>
        /// <returns>Wether the player survived the trap or not.</returns>
        private static bool CanSurviveTrap(TrapType trap, PlayerGear gear)
        {
            switch (trap)
            {
                case TrapType.FallingRocks:
                    return (gear & PlayerGear.Helmet) == PlayerGear.Helmet;
                case TrapType.SpinningBlades:
                    return (gear & PlayerGear.Shield) == PlayerGear.Shield;
                case TrapType.PoisonGas:
                    return (gear & PlayerGear.Helmet) == PlayerGear.Helmet && (gear & PlayerGear.Shield) == PlayerGear.Shield;
                case TrapType.LavaPit:
                    return (gear & PlayerGear.Boots) == PlayerGear.Boots;
            }
            return false;
        }

        /// <summary>
        /// Display information on wether the player survived the trap or not.
        /// </summary>
        /// <param name="trap">The trap the player has fallen into.</param>
        private static void DisplayResult(TrapType trap, bool survives)
        {

        }
    }
}
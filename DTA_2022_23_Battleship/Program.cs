using DTA_2022_23_Battleship.Model;
using System.Runtime.CompilerServices;

namespace DTA_2022_23_Battleship {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            ///
            // var game = new Game(); // Model
            ApplicationConfiguration.Initialize();

            // Model (game) wird der View (BattleshipGame) übergeben
            Application.Run(new LoginScreen());
            //Application.Run(new BattleshipGame(game));

            //var playersBoard = new Board(10);
            //var computersBoard = new Board(10);
        }
        public static void LoginComplete() {
            var game = new Game();
            var gameForm = new BattleshipGame(game);
            gameForm.Show();
        }
    }
}
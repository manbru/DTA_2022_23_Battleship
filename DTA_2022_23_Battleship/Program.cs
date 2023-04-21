using DTA_2022_23_Battleship.Model;
using System.Runtime.CompilerServices;
using System;
using System.Linq;
using System.Diagnostics;

namespace DTA_2022_23_Battleship {
    internal static class Program {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            var db = new BattleshipContext();
            Debug.Write($"Database path: {db.DbPath}.");
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            ///
            ApplicationConfiguration.Initialize();

            // Model (game) wird der View (BattleshipGame) übergeben
            Application.Run(new LoginScreen());

            //var playersBoard = new Board(10);
            //var computersBoard = new Board(10);
        }
        public static void StartGame() {
            var game = new Game(); //Model
            var gameForm = new BattleshipGame(game);
            gameForm.Show();
        }
        public static void ShowAdminMenu() {
            var menu = new AdminMenu();
            menu.Show();
        }
        public static void ShowUserManagement() {
            var management = new UserManagement();
            management.Show();
        }
    }
}
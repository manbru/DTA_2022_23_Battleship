using DTA_2022_23_Battleship.Model.Ships;
using DTA_2022_23_Battleship.Model.Strategies;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTA_2022_23_Battleship.Model
{
    public class Game {
        private Board boardPlayer1 = new Board(10);
        private Board boardPlayer2 = new Board(10);
        PlayerStrategy strategy1;
        PlayerStrategy strategy2;
        private int userid;
        private int turns;

        public Game(int userid) {
            this.userid = userid;
        }


        public void StartNewGame() {
            var randomBoardGenerator = new RandomBoardGenerator();

            var shipsPlayer1 = this.GenerateShips();
            randomBoardGenerator.Generate(boardPlayer1, shipsPlayer1);

            var shipsPlayer2 = this.GenerateShips();
            randomBoardGenerator.Generate(boardPlayer2, shipsPlayer2);

            boardPlayer1.AfterShot += (sender, eventArgs) => {
                if (eventArgs.ShotResponse != ShotResponse.IsHit) {
                    boardPlayer1.IsYourTurn = false;
                    boardPlayer2.IsYourTurn = true;
                } else {
                    turns++;
                    boardPlayer1.IsYourTurn = true;
                }
            };

            boardPlayer2.AfterShot += (sender, eventArgs) => {
                if (eventArgs.ShotResponse != ShotResponse.IsHit) {
                    boardPlayer1.IsYourTurn = true;
                    boardPlayer2.IsYourTurn = false;
                } else {
                    boardPlayer2.IsYourTurn = true;
                }
            };

            
            boardPlayer1.IsYourTurnChanged += (sender, eventArgs) => {
                if (this.boardPlayer1.IsYourTurn) {
                    this.Player2Strategy.Shot();
                }
            };
            boardPlayer2.IsYourTurnChanged += (sender, eventArgs) => {
                if (this.boardPlayer2.IsYourTurn) {
                    this.Player1Strategy.Shot();
                }
            };

            boardPlayer1.GameEnd += (sender, eventArgs) => {
                boardPlayer1.IsYourTurn = false;
                boardPlayer2.IsYourTurn = false;
                SaveInfo(false);
            };
            boardPlayer2.GameEnd += (sender, eventArgs) => {
                boardPlayer1.IsYourTurn = false;
                boardPlayer2.IsYourTurn = false;
                SaveInfo(true);
            };

            this.SetPlayer1Strategy(PlayerStrategy.Stupid);
            this.SetPlayer2Strategy(PlayerStrategy.Stupid);
            boardPlayer1.IsYourTurn = true;
        }

        public void SetPlayer1Strategy(PlayerStrategy playerStrategy) {
            this.Player1Strategy = PlayerStrategyFactory.Create(playerStrategy, this.BoardPlayer2);
            strategy1 = playerStrategy;
        }

        public void SetPlayer2Strategy(PlayerStrategy playerStrategy) {
            this.Player2Strategy = PlayerStrategyFactory.Create(playerStrategy, this.BoardPlayer1);
            strategy2 = playerStrategy;
        }

        private PlayerStrategyBase Player1Strategy { get; set; } = null!;
        private PlayerStrategyBase Player2Strategy { get; set; } = null!;

        public Board BoardPlayer1 { get { return boardPlayer1; } }
        public Board BoardPlayer2 { get { return this.boardPlayer2; } }

        private List<Ship> GenerateShips() {
            var ships = new List<Ship>();

            for (var i = 0; i < 4; i++) {
                ships.Add(new Submarine());
            }
            for (var i = 0; i < 3; i++) {
                ships.Add(new Destroyer());
            }
            for (var i = 0; i < 2; i++) {
                ships.Add(new Cruiser());
            }
            ships.Add(new Battleship());

            return ships;
        }
        private void SaveInfo(bool player1won) {
            using ( var db = new BattleshipContext()) {
                string winner = "";
                string loser = "";
                int winnerScore;
                int loserscore;
                if (player1won) {
                    switch(strategy1) 
                    {
                        case PlayerStrategy.Stupid: 
                            winner = "Stupid";
                            break;
                        case PlayerStrategy.Smart:
                            winner = "Stupid";
                            break;
                        case PlayerStrategy.Genius:
                            winner = "Genius";
                            break;
                        case PlayerStrategy.Expert:
                            winner = "Expert";
                            break;
                        case PlayerStrategy.Manual:
                            winner = db.Users.Where(u => u.UserId == userid).Select(u => u.UserName).FirstOrDefault();
                            break;
                    }
                    switch (strategy2) {
                        case PlayerStrategy.Stupid:
                            loser = "Stupid";
                            break;
                        case PlayerStrategy.Smart:
                            loser = "Stupid";
                            break;
                        case PlayerStrategy.Genius:
                            loser = "Genius";
                            break;
                        case PlayerStrategy.Expert:
                            loser = "Expert";
                            break;
                        case PlayerStrategy.Manual:
                            loser = db.Users.Where(u => u.UserId == userid).Select(u => u.UserName).FirstOrDefault();
                            break;
                    }
                    winnerScore = boardPlayer2.Score;
                    loserscore = boardPlayer1.Score;
                } else {
                    switch (strategy2) {
                        case PlayerStrategy.Stupid:
                            winner = "Stupid";
                            break;
                        case PlayerStrategy.Smart:
                            winner = "Stupid";
                            break;
                        case PlayerStrategy.Genius:
                            winner = "Genius";
                            break;
                        case PlayerStrategy.Expert:
                            winner = "Expert";
                            break;
                        case PlayerStrategy.Manual:
                            winner = db.Users.Where(u => u.UserId == userid).Select(u => u.UserName).FirstOrDefault();
                            break;
                    }
                    switch (strategy1) {
                        case PlayerStrategy.Stupid:
                            loser = "Stupid";
                            break;
                        case PlayerStrategy.Smart:
                            loser = "Stupid";
                            break;
                        case PlayerStrategy.Genius:
                            loser = "Genius";
                            break;
                        case PlayerStrategy.Expert:
                            loser = "Expert";
                            break;
                        case PlayerStrategy.Manual:
                            loser = db.Users.Where(u => u.UserId == userid).Select(u => u.UserName).FirstOrDefault();
                            break;
                    }
                    winnerScore = boardPlayer1.Score;
                    loserscore = boardPlayer2.Score;
                }
                db.Matches.Add(new Match() {
                    MatchId = db.Matches.Count(),
                    EndTime = (int)new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds(),
                    WinnerName = winner,
                    LoserName = loser,
                    WinnerScore = winnerScore,
                    LoserScore = loserscore,
                    Turns = turns,
                });
                db.SaveChanges();
            }
        }
    }
}

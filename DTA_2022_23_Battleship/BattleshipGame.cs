using DTA_2022_23_Battleship.Model;

namespace DTA_2022_23_Battleship {
    public partial class BattleshipGame : Form {
        private Game game;   // Model
        public BattleshipGame(Game game) {
            this.game = game;

            InitializeComponent();


            game.BoardPlayer1.AfterShot += BoardPlayer1_AfterShot;
            game.BoardPlayer2.AfterShot += BoardPlayer2_AfterShot;

            game.BoardPlayer1.IsYourTurnChanged += (sender, args) => {
                if (this.game.BoardPlayer1.IsYourTurn) {
                    this.label2.Text = "Your turn";
                    this.label3.Text = "Wait";
                }
            };
            game.BoardPlayer2.IsYourTurnChanged += (sender, args) => {
                if (this.game.BoardPlayer2.IsYourTurn) {
                    this.label3.Text = "Your turn";
                    this.label2.Text = "Wait";
                }
            };

            game.StartNewGame();

            this.battleshipBoardPlayer1.SetBoard(game.BoardPlayer1, true);
            this.battleshipBoardPlayer2.SetBoard(game.BoardPlayer2, true);

            // View:
            // BattleshipGame (=this)
            // this.battleshipBoardPlayer1
            // this.battleshipBoardPlayer2


            // TODO:
            // Hier sind die Boards (=Model) mit den Schiffen erzeugt.
            // game.BoardPlayer1 mit this.battleshipBoardPlayer1 visualisieren
            // D.h. game.BoardPlayer1 an this.battleshipBoardPlayer1 �bergeben und
            // in BattleshipBoard die Logik f�r die Visualisierung umsetzen.
        }

        private void BoardPlayer1_AfterShot(object? sender, AfterShotEventArgs e) {
            this.battleshipBoardPlayer1.EvaluateShipState(e.Coordinate);
            this.label5.Text = game.BoardPlayer1.Score.ToString();
        }

        private void BoardPlayer2_AfterShot(object? sender, AfterShotEventArgs e) {
            this.battleshipBoardPlayer2.EvaluateShipState(e.Coordinate);
            this.label4.Text = game.BoardPlayer2.Score.ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            this.battleshipBoardPlayer1.ShowShips = !this.battleshipBoardPlayer1.ShowShips;
        }

        private void button3_Click(object sender, EventArgs e) {
            this.battleshipBoardPlayer2.ShowShips = !this.battleshipBoardPlayer2.ShowShips;
        }
    }
}
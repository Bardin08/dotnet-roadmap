using Assignment1;
using Assignment1.Core;

var playersProvider = new PlayersProvider();
var userInputProvider = new UserInputProvider();
var leaderboard = new Leaderboard();

var processor = new TicTacToeProcessor(
    playersProvider,
    userInputProvider,
    leaderboard);

processor.Process();

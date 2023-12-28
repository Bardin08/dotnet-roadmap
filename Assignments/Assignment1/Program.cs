using Assignment1;

var playersProvider = new PlayersProvider();
var userInputProvider = new UserInputProvider();

var processor = new TicTacToeProcessor(
    playersProvider,
    userInputProvider);

processor.Process();

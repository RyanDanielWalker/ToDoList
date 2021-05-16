Player(string userInput)
{
  Guess = userInput;
  GuessesLeft = 6;
}

Hangman()
{
  WordLetters = generatedWord.ToCharArray();
  GuessedLetter = wordLetters.length.fill("_");
}





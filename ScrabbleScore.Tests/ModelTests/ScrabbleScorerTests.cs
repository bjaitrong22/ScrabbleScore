using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void ScoreConstructor_CreatesInstanceOfScorer_Scorer()
    {
      Score newScorer = new Score("test");
      Assert.AreEqual(typeof(Score), newScorer.GetType());
    }

    [TestMethod]
    public void GetWord_ReturnWord_String()
    {
      //Arrange
      string scrabbleWord = "Sparrow";
      Score newScorer = new Score(scrabbleWord);

      //Act
      string returnScrabbleWord = newScorer.Word;

      //Assert
      Assert.AreEqual(scrabbleWord, returnScrabbleWord);

    }
  }
}
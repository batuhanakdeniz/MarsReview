using MarsReview;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsReviewTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RoverMovesOneUnit()
        {
            Plateau plateau = new Plateau(5,5);
            Rover rover = new Rover(1,1,'N');

            rover.MoveOneUnit(5,5);

            Rover expectedRover = new Rover(1, 2, 'N');

            Assert.AreEqual(rover.GetCoordinate_x(), expectedRover.GetCoordinate_x());
            Assert.AreEqual(rover.GetCoordinate_y(), expectedRover.GetCoordinate_y());
            Assert.AreEqual(rover.GetDirection(), expectedRover.GetDirection());
        }
        [TestMethod]
        public void RoverChangesDirectionToLeft()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(2, 2, 'E');

            rover.ChangeDirection('L');

            Rover expectedRover = new Rover(2, 2, 'N');

            Assert.AreEqual(rover.GetCoordinate_x(), expectedRover.GetCoordinate_x());
            Assert.AreEqual(rover.GetCoordinate_y(), expectedRover.GetCoordinate_y());
            Assert.AreEqual(rover.GetDirection(), expectedRover.GetDirection());
        }
        [TestMethod]
        public void RoverChangesDirectionToRight()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(2, 2, 'W');

            rover.ChangeDirection('R');

            Rover expectedRover = new Rover(2, 2, 'N');

            Assert.AreEqual(rover.GetCoordinate_x(), expectedRover.GetCoordinate_x());
            Assert.AreEqual(rover.GetCoordinate_y(), expectedRover.GetCoordinate_y());
            Assert.AreEqual(rover.GetDirection(), expectedRover.GetDirection());
        }
        [TestMethod]
        public void RoverTakesAction()
        {
            Plateau plateau = new Plateau(5, 5);
            Rover rover = new Rover(2, 2, 'E');

            string command = "LMMLMMLMLMRMMM";

            rover.TakeAction(command, plateau);

            Rover expectedRover = new Rover(1, 0, 'S');

            Assert.AreEqual(rover.GetCoordinate_x(), expectedRover.GetCoordinate_x());
            Assert.AreEqual(rover.GetCoordinate_y(), expectedRover.GetCoordinate_y());
            Assert.AreEqual(rover.GetDirection(), expectedRover.GetDirection());
        }
    }
}

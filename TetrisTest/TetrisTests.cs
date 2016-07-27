using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TetrisTest
{
    [TestFixture]
    public class TetrisTests
    {

        [SetUp]
        public void SetUp()
        {

        }

        [Test]

        public void PlayfieldHas10ColumnsAnd22Rows()
        {
            var playfield = new Playfield();

            playfield.Initialise();

            Assert.That(playfield.Field.Count, Is.EqualTo(10), "#Columns are wrong");
            playfield.Field.ForEach(row => Assert.That(row.Count, Is.EqualTo(22), "#Rows are wrong"));
        }

        [Test]
        public void RandomBlockIsDrawn()
        {
            var allowedTypes = new List<string>() {"3x3", "4x4"};
            var block = TetrominoFactory.GenerateRandomTetromino();
           
            CollectionAssert.Contains(block, allowedTypes);
        }

        public class TetrominoFactory
        {

            public static IEnumerable GenerateRandomTetromino()
            {
                throw new NotImplementedException();
            }
        }
    }
}

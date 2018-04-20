using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace prjTask1.Tests
{
    [TestClass]
    public class BTNCompareTest
    {
        [TestMethod]
        public void CompareTrees_Equals_MustReturnTrue()
        {
            #region Creating objects

            #region Tree 1

            BTN tree1 = new BTN();
            tree1.val = 90;

            tree1.left = new BTN();
            tree1.left.val = 50;

            tree1.left.left = new BTN();
            tree1.left.left.val = 20;
            tree1.left.right = new BTN();
            tree1.left.right.val = 75;

            tree1.right = new BTN();
            tree1.right.val = 150;

            #endregion

            #region Tree 2

            BTN tree2 = new BTN();
            tree2.val = 90;

            tree2.left = new BTN();
            tree2.left.val = 50;

            tree2.left.left = new BTN();
            tree2.left.left.val = 20;
            tree2.left.right = new BTN();
            tree2.left.right.val = 75;

            tree2.right = new BTN();
            tree2.right.val = 150;

            #endregion

            #endregion

            Assert.AreEqual(true, Program.CompareTrees(tree1, tree2));
        }
        [TestMethod]
        public void CompareTrees_DifferentValues_MustReturnFalse()
        {
            #region Creating objects

            #region Tree 1
            BTN tree1 = new BTN();
            tree1.val = 90;

            tree1.left = new BTN();
            tree1.left.val = 50;

            tree1.left.left = new BTN();
            tree1.left.left.val = 20;
            tree1.left.right = new BTN();
            tree1.left.right.val = 75;

            tree1.right = new BTN();
            tree1.right.val = 150;
            #endregion

            #region Tree 2

            BTN tree2 = new BTN();
            tree2.val = 91;

            tree2.left = new BTN();
            tree2.left.val = 50;

            tree2.left.left = new BTN();
            tree2.left.left.val = 20;
            tree2.left.right = new BTN();
            tree2.left.right.val = 75;

            tree2.right = new BTN();
            tree2.right.val = 150;

            #endregion

            #endregion

            Assert.AreEqual(false, Program.CompareTrees(tree1, tree2));
        }

        [TestMethod]
        public void CompareTrees_DifferentSizes_MustReturnFalse()
        {
            #region Creating objects

            #region Tree 1

            BTN tree1 = new BTN();
            tree1.val = 90;

            tree1.left = new BTN();
            tree1.left.val = 50;

            tree1.left.left = new BTN();
            tree1.left.left.val = 20;
            tree1.left.right = new BTN();
            tree1.left.right.val = 75;

            tree1.right = new BTN();
            tree1.right.val = 150;

            #endregion

            #region Tree 2

            BTN tree2 = new BTN();
            tree2.val = 91;

            #endregion

            #endregion

            Assert.AreEqual(false, Program.CompareTrees(tree1, tree2));
        }
    }
}

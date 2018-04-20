namespace prjTask1
{
    public class TreesCompare
    {
        /// <summary>
        /// 1) We have a class representing binary tree nodes: 
        //class BTN
        //{
        //    int val;
        //    BTN left;
        //    BTN right;
        //}
        //please implement method to compare 2 such trees(returns: true if fully equal, false - otherwise)
        /// </summary>
        /// <param name="tree1"></param>
        /// <param name="tree2"></param>
        /// <param name="isEqual"></param>
        public bool CompareTrees(BTN tree1, BTN tree2)
        {
            bool areEqual = true;
            if (tree1 != null && tree2 != null)
            {
                areEqual = CompareTrees(tree1.left,tree2.left);
                if (!areEqual)
                {
                    return areEqual;
                }

                if (tree1.val != tree2.val)
                {
                    return false;
                }
                areEqual = CompareTrees(tree1.right, tree2.right);
                if (!areEqual)
                {
                    return areEqual;
                }
            }
            else if(tree1 != null && tree2 == null)
            {
                return false;
            }
            else if (tree1 == null && tree2 != null)
            {
                return false;
            }

            return areEqual;
        }

        
    }
}

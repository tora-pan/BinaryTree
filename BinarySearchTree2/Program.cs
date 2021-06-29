using System;

namespace BinarySearchTree2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Tree theTree = new Tree();
            theTree.Insert(3);
            theTree.Insert(35);
            theTree.Insert(13);
            theTree.Insert(32);
            theTree.Insert(322);
            theTree.Insert(113);
            theTree.Insert(89);
            theTree.Insert(10);

            theTree.DisplayTree();
            
        }
    }
}

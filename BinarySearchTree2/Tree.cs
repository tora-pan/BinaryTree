using System;
namespace BinarySearchTree2
{
    public class Tree
    {

        private Node _root;

        public Tree()
        {
            _root = null;
        }

        public void Insert(int val)
        {
            // If empty return single n ode
            if(_root == null)
            {
                //create a new node with the passed in val and set it to root using the Node Constructor
                _root = new Node(val);
                return;
            }
            else
            {
                //insert using the recursive funcition
                InsertRecursively(_root, new Node(val));
            }
        }

        public void InsertRecursively(Node root, Node newNode)
        {
            // if null, set root to new node
            if(root == null)
            {
                root = newNode;
            }

            // compare new node data to root data. If less go left, if greater go right. (check for null nodes)
            if(newNode.Data < root.Data)
            {
                if(root.LeftNode == null)
                {
                    root.LeftNode = newNode;
                }
                else
                {
                    InsertRecursively(root.LeftNode, newNode);
                }
            }
            if(newNode.Data > root.Data)
            {
                if(root.RightNode == null)
                {
                    root.RightNode = newNode;
                }
                else
                {
                    InsertRecursively(root.RightNode, newNode);
                }
            }


        }

        private void DisplayTree(Node root)
        {
            // check for null
            if(root == null)
            {
                return;
            }

            //Recursivley call Display with child node if applicable
            DisplayTree(root.LeftNode);
            Console.WriteLine(root.Data);
            DisplayTree(root.RightNode);
        }

        public void DisplayTree()
        {
            DisplayTree(_root);
        }
    }
}

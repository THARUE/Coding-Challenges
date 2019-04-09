///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  BTree Project 5
//	File Name:         Node.cs
//	Description:       This class represents a single node in the BTree
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Andrew Haselden, andrewhaselden@gmail.com                                               
//	Created:           Friday, April 14, 2017
//	Copyright:         Andrew Haselden, 2017
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
namespace BTree
{
    /// <summary>
    /// This class represents a single node in the BTree
    /// </summary>
    class Node
    {
        #region NodeType Enum
        public enum NodeType { Index, Leaf};
        #endregion

        #region Properties
        public int NumKeys { get; set; }
        public int[] Keys { get; set; }
        public Node[] Children { get; set; }
        #endregion

        #region Properties Full
        private NodeType MyType;
        public NodeType Type
        {
            get
            {
                if (Children[0] == null)
                    return NodeType.Leaf;
                else
                    return NodeType.Index;
            }
            set { MyType = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="size">The size.</param>
        public Node(int size)
        {
            NumKeys = 0;
            Keys = new int[size];
            Children = new Node[size];
        }
        #endregion
    }
}

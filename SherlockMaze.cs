using System;
using System.Diagnostics;

namespace Challenges
{
    /// <summary>
    /// Sherlock Maze
    /// Find all Possible paths from starting node (N, M) to destination node(N, M)
    /// Maximum amount of turns must be <= K
    /// Starting node N,M must be < Destination node N,M
    /// </summary>
    public class SherlockMaze
    {
        #region Properties
        public int MaxTurns { get; set; }
        public Node StartingNode { get; set; }
        public Node DestinationNode { get; set; }
        public int SuccessfulPaths { get; set; }
        public int Count { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor for Sherlock Maze.  Pass the N and M for the starting and ending nodes.
        /// MaxTurns represents the max number of turns allowed in the solution.
        /// Starting Node (N,M) must be < Destination Node (N,M)
        /// </summary>
        /// <param name="starting_N"></param>
        /// <param name="starting_M"></param>
        /// <param name="destination_N"></param>
        /// <param name="destination_M"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        /// <created>Andrew Haselden, andrewhaselden@gmail.com ,4/9/2019</created>
        /// <changed>Andrew Haselden, andrewhaselden@gmail.com ,4/9/2019</changed>
        public SherlockMaze(int starting_N, int starting_M, int destination_N, int destination_M, int k)
        {
            MaxTurns = k;
            DestinationNode = new Node(destination_N, destination_M);
            StartingNode = new Node(starting_N, starting_M);
            SuccessfulPaths = default;
        }
        #endregion

        #region Structs
        /// <summary>
        /// Node represents an N (row) value and an M (column) value
        /// </summary>
        public struct Node
        {
            public int N { get; set; }
            public int M { get; set; }

            public Node(int n, int m)
            {
                N = n;
                M = m;
            }
        }
        #endregion

        #region Recursive Method
        /// <summary>
        /// Recursive method that searchs for all the paths from starting node to destination node
        /// </summary>
        /// <param name="current"></param>
        /// <param name="previous"></param>
        /// <param name="currentPath"></param>
        /// <param name="turns"></param>
        /// <created>Andrew Haselden, andrewhaselden@gmail.com ,4/9/2019</created>
        /// <changed>Andrew Haselden, andrewhaselden@gmail.com ,4/9/2019</changed>
        private void SearchPaths(Node current, Node previous, int turns)
        {
            //increment recursion counter
            Count++;

            //base cases
            if (current.N > DestinationNode.N || current.M > DestinationNode.M || turns > MaxTurns)
                return;
            if (current.N == DestinationNode.N && current.M == DestinationNode.M)
            {
                //add successful path to successful paths
                SuccessfulPaths++;
                return;
            }
            
            //make next turns
            Node nextNodeDown = new Node(current.N, current.M + 1);
            Node nextNodeRight = new Node(current.N + 1, current.M);

            if (previous.N == current.N)
            {
                SearchPaths(nextNodeRight, new Node(current.N, current.M), turns+1);
            }
            else 
                SearchPaths(nextNodeRight, new Node(current.N, current.M), turns);

            if (previous.M == current.M)
            {
                SearchPaths(nextNodeDown, new Node(current.N, current.M), turns + 1);
            }
            else
                SearchPaths(nextNodeDown, new Node(current.N, current.M), turns);

        }       
        
        /// <summary>
        /// Run the algorithm
        /// </summary>
        /// <returns>A string to display the results</returns>
        /// <created>Andrew Haselden, andrewhaselden@gmail.com ,4/9/2019</created>
        /// <changed>Andrew Haselden, andrewhaselden@gmail.com ,4/9/2019</changed>
        public string Run()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            SearchPaths(new Node(StartingNode.N + 1, StartingNode.M), StartingNode, 0);
            SearchPaths(new Node(StartingNode.N, StartingNode.M + 1), StartingNode, 0);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

            return $"There were {SuccessfulPaths} successful paths from {StartingNode.N},{StartingNode.M} to {DestinationNode.N},{DestinationNode.M}" +
                $"\nThe method Recursed {Count} times.\n" +
                $"RunTime = {elapsedTime}";
        }
        #endregion
    }
}

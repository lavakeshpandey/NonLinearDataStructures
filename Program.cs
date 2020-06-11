﻿using System;

namespace NonLinearDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            BTree tree = new BTree();

            tree.Insert(7);
            tree.Insert(4);
            tree.Insert(1);
            tree.Insert(6);
            tree.Insert(9);
            tree.Insert(8);
            tree.Insert(10);

            tree.PreOrderTraversal();

            Console.WriteLine();
        }
    }
}
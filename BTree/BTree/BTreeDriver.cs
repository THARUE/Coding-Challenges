///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  BTree Project 5
//	File Name:         BTreeDriver.cs
//	Description:       This is the driver class for the BTree analyzer program
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Andrew Haselden, andrewhaselden@gmail.com                                                
//	Created:           Friday, April 14, 2017
//	Copyright:         Andrew Haselden, 2017
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;
using System.Windows.Forms;

namespace BTree
{
    /// <summary>
    /// This is the driver class for the BTree analyzer program
    /// </summary>
    static class BTreeDriver
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
            Application.Run(new MainForm());
        }
    }
}

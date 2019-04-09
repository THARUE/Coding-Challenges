///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  BTree Project 5
//	File Name:         AboutBox1.cs
//	Description:       This class constructs the AboutBox
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
    /// This class constructs the AboutBox
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class AboutBox1 : Form
    {
        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="AboutBox1"/> class.
        /// </summary>
        public AboutBox1()
        {
            InitializeComponent();

            //set the information from the AssemblyInfo
            this.Text = String.Format("About {0}", Utility.AssemblyTitle);
            this.labelProductName.Text = Utility.AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0}", Utility.AssemblyVersion);
            this.labelCopyright.Text = Utility.AssemblyCopyright;
            this.labelCompanyName.Text = Utility.AssemblyCompany;
            this.textBoxDescription.Text = Utility.AssemblyDescription;
        }
        #endregion
    }
}

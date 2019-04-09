///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  BTree Project 5
//	File Name:         SplashForm.cs
//	Description:       This class handles the logic for the splash form
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
    /// This class handles the logic for the splash form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SplashForm : Form
    {
        #region Class Attributes
        private Timer t, t1;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="SplashForm"/> class.
        /// </summary>
        public SplashForm()
        {
            InitializeComponent();
            t = new Timer();
            t1 = new Timer();
            LabelCompanyName.Text = Utility.AssemblyCompany;
            LabelProgramName.Text = Utility.AssemblyProduct;
            LabelVersion.Text = "Version " + Utility.AssemblyVersion;
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Handles the Load event of the SplashForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SplashForm_Load(object sender, EventArgs e)
        {
            Opacity = 0;

            t1.Interval = 10;
            t1.Tick += new EventHandler(FadeIn);
            t1.Start();
        }

        /// <summary>
        /// Handles the FormClosing event of the SplashForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
        private void SplashForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            t1.Tick += new EventHandler(FadeOut);  //this calls the fade out function
            t1.Start();

            if (Opacity == 0)  //if the form is completly transparent
            {
                e.Cancel = false;   //resume the event - the program can be closed
            }
        }

        /// <summary>
        /// Handler for the Timer.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OpenTime(object sender, EventArgs e)
        {
            this.Close();
            t.Stop();
        }

        /// <summary>
        /// Fade in animation for Splash Form.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FadeIn(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                t1.Stop();
                Opacity = 1;

                t.Interval = 2000;
                t.Tick += new EventHandler(OpenTime);
                t.Start();
            }
            else
                Opacity += .05;

        }

        /// <summary>
        /// Fades out animation for Splash Form.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void FadeOut(object sender, EventArgs e)
        {
            if (Opacity <= 0)     //check if opacity is 0
            {
                t1.Stop();   //if it is, we stop the timer 
                t.Stop();
                this.Close();
            }
            else
            {
                Opacity -= 0.05;
            }
        }
        #endregion
    }
}

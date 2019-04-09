///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Solution/Project:  BTree Project 5
//	File Name:         MainForm.cs
//	Description:       This class handles the logic for the main form
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
    /// This class handles the logic for the main form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class MainForm : Form
    {
        #region Attributes
        BTree bt;
        Random r;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            //make panels invisible
            panel3.Visible = false;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Populates the b tree.
        /// </summary>
        /// <param name="size">The size.</param>
        private void PopulateBTree(int size)
        {
            bt = new BTree(size);
            r = new Random();
            while (bt.ValueCount < 500)
            {
                bt.Insert(r.Next(0, 10000));
            }
            TextBoxDisplay.Text = bt.ToString();
        }
        #endregion

        #region EventHandlers
        /// <summary>
        /// Handles the Click event of the exitToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using BTree Analyzer!");
            Close();
        }

        /// <summary>
        /// Handles the Click event of the aboutToolStripHelpItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void aboutToolStripHelpItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the button1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(TreeSizeTextBox.Text, out value) && value > 2)
            {
                panel1.Visible = false;
                panel3.Visible = true;
                PopulateBTree(value);
                textBox1.Text = String.Empty;
                textBox2.Text = String.Empty;
                textBox3.Text = String.Empty;
            }
            else
                MessageBox.Show("Enter a valid, positive integer greater than 2.");
        }


        /// <summary>
        /// Handles the Click event of the button2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox1.Text, out value))
            {
                if (bt.Search(value))
                    MessageBox.Show(String.Format("The value {0} was found!", value));
                else
                    MessageBox.Show(String.Format("The value {0} was not found!", value));
            }
            else
                MessageBox.Show("Enter a valid, positive integer");
        }

        /// <summary>
        /// Handles the Click event of the button3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button3_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox2.Text, out value))
            {
                bt.Insert(value);
                TextBoxDisplay.Text = bt.ToString();
                MessageBox.Show(String.Format("The value {0} was successfully inserted!", value));
            }
            else
                MessageBox.Show("Enter a valid, positive integer");
        }

        /// <summary>
        /// Handles the Click event of the button4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(textBox3.Text, out value))
            {
                if (bt.Delete(value))
                {
                    TextBoxDisplay.Text = bt.ToString();
                    MessageBox.Show(String.Format("The value {0} was successfully deleted!", value));
                }
                else
                    MessageBox.Show(String.Format("The value {0} does not exist!", value));
            }
            else
                MessageBox.Show("Enter a valid, positive integer");
        }

        /// <summary>
        /// Handles the Click event of the newToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bt = null;
            TreeSizeTextBox.Text = "";
            panel3.Visible = false;
            panel1.Visible = true;
        }
        #endregion     
    }
}

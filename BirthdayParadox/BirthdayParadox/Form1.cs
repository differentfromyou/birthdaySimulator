//By Piotr Wiatr on 10/30/2020
//Grade 11, just for fun not for any class :(
//Why I made it: Just saw a video from Vsauce2 about the birthday paradox and wanted to create a program that would, at least partly, prove
//the validity of such a theory.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayParadox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Setting variables
            int numPeople = int.Parse(textPeople.Text);             //Sets the number of people per experiment
            int numExperiments = int.Parse(textExperiments.Text);   //Sets the number of experiments
            prgsProgress.Value = 0;                                 //Resets the progress bar
            prgsProgress.Maximum = numExperiments;                  //Makes it so that the progress bar is finished once it has completed all experiments
            richDisplay.Text = "";                                  //Resets the display box
            Random rnd = new Random();                              //Sets the random object
            int[] birthdays = new int[numPeople];                   //Creates array in which the birthdays are stored
            int numOfDuplicates = 0;                                //Number of duplicate birthdays
            int numOfDifferences = 0;                               //Number of non-duplicated birthdays


            //disables all input fields to avoid errors
            textPeople.Enabled = false;
            textExperiments.Enabled = false;
            btnCalculate.Enabled = false;

            //double for loop that goes through the experiments
            for (int i = 0; i < numExperiments; i++)
            {
                //for loop that goes through the number of people and giving them an assigned number
                for (int j = 0; j < numPeople; j++)
                {
                    birthdays[j] = rnd.Next(0, 365);
                }

                //conditional statement to see if there are any duplicate numbers
                if (birthdays.Length != birthdays.Distinct().Count())
                {
                    numOfDuplicates++;
                }
                else
                {
                    numOfDifferences++;
                }

                //Makes the progress bar perform a step and resets the birthdays array
                prgsProgress.PerformStep();
                birthdays = new int[numPeople];
            }

            //calculates and rounds the percentage of duplicates with respect to the number of experiments
            double percentDuplicates = Math.Round((Convert.ToDouble(numOfDuplicates) / Convert.ToDouble(numExperiments)) * 100, 2);

            //displays the result
            richDisplay.Text = "Number of Duplicates: " + numOfDuplicates + "\nNumber of Differences: " + numOfDifferences + "\nPercentage: " + percentDuplicates + "%";

            //renables input sources
            textPeople.Enabled = true;
            textExperiments.Enabled = true;
            btnCalculate.Enabled = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace JumbleSolver
{
    public partial class jumbleSolverApp : Form
    {
        public jumbleSolverApp()
        {
            InitializeComponent();
        }

        string[] wordArray = new string[100000];
        long count = 0;
        int found = 0;
        string solution;

        private void clearButton_Click(object sender, EventArgs e)
        {
            originalWord.Text = "";
            solvedWord.Text = "";
        }

        void permute(int level, String permuted,bool[] used, String original) 
        {
            int length = original.Length;
            if (level == length)
            {
                wordArray[count] = permuted;
                count = count + 1;                
            }
            else
            {
                for (int i = 0; i < length; i++) 
                {
                    if (!used[i]) 
                    {
                        used[i] = true;
                        permute(level + 1, permuted + original.ElementAt(i),used, original);
                        used[i] = false;
                    }
                }
            }
        }
        private void solveButton_Click(object sender, EventArgs e)
        {
            if (count != 0)
                count = 0;
            if (originalWord.Text == "")
                MessageBox.Show("Please enter the word to be solved", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                solvedWord.Text = "";
               try
               {
                    string word = originalWord.Text;
                    word = word.Trim();
                    bool[] used = { false, false, false, false, false,false,false,false,false,false };
                    permute(0, "", used, word);
                    StreamReader dictionary = new StreamReader("dictionary.txt");
                    string line;
                    while ((line = dictionary.ReadLine()) != null)
                    {
                        line = line.Trim();
                        for (long i = 0; i < count; i++)
                        {
                            if (String.Equals(line, wordArray[i]))
                            {
                                found = 1;
                                solution = line;
                                break;
                            }
                        }
                        if (found == 1)
                            break;
                    }
                    if (found == 1)
                    {
                        dictionary.Close();
                        solvedWord.Text = solution;
                        MessageBox.Show("Solution Found!","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        found = 0;
                    }
                    else
                    {
                        dictionary.Close();
                        MessageBox.Show("Solution not Found!", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
               }
               catch(Exception ex)
               {
                  MessageBox.Show(ex.Message, "Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
               }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace maxabsdiff
{

    public partial class Form1 : Form
    {
        private string[] nameList;
        private int count;

        public Form1()
        {
            InitializeComponent();
            nameList = new string[2]; 
            count = 0; 
            UpdateLabel(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text.Trim();

                if (!string.IsNullOrEmpty(name))
                {
                    if (!Contains(name))
                    {
                        if (count >= nameList.Length)
                        {
                            Array.Resize(ref nameList, nameList.Length * 2); // Double the size of the array
                        }
                        nameList[count] = name; // Add to the array
                        count++; // Increment the count
                        UpdateLabel();
                        MessageBox.Show($"{name} has been added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                textBox1.Clear(); // Clear the text box after successful addition
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }//close
        private bool Contains(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (nameList[i] == name)
                {
                    return true; // Name exists
                }
            }
            return false; // Name does not exist
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox2.Text.Trim();

                if (!string.IsNullOrEmpty(name))
                {
                    if (Contains(name))
                    {
                        MessageBox.Show($"{name} is in the list.", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"{name} was not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Search name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                textBox2.Clear(); // Clear the text box after searching
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox3.Text.Trim();

                if (!string.IsNullOrEmpty(name))
                {
                    int index = Array.IndexOf(nameList, name); // Find the index of the name
                    if (index >= 0)
                    {
                        for (int i = index; i < count - 1; i++)
                        {
                            nameList[i] = nameList[i + 1]; // Shift elements left
                        }
                        nameList[count - 1] = null; // Clear the last element
                        count--; // Decrement the count
                        UpdateLabel();
                        MessageBox.Show($"{name} has been deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"{name} was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Name cannot be empty for deletion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateLabel()
        {
            label1.Text = $"Number of people: {count}"; // Display the current count
        }
    }
}

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
        private LinkedList<string> nameList = new LinkedList<string>();

        public Form1()
        {
            InitializeComponent();
            UpdateLabel(); // Update label initially
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox1.Text.Trim();

                if (!string.IsNullOrEmpty(name))
                {
                    if (!nameList.Contains(name))
                    {
                        nameList.AddLast(name); // Add to the end of the linked list
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string name = textBox2.Text.Trim();

                if (!string.IsNullOrEmpty(name))
                {
                    if (nameList.Contains(name))
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
                string
 name = textBox3.Text.Trim();

                if (!string.IsNullOrEmpty(name))
                {
                    if (nameList.Contains(name))
                    {
                        nameList.Remove(name);
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

                textBox3.Clear(); // Clear the text box after deletion
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private  void UpdateLabel()
        {
            label1.Text = $"Number of people: {nameList.Count}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> zodiacList = new List<string>();

        private void btnList_Click(object sender, EventArgs e)
        {
            List<string> teamMembers = new List<string>();
            teamMembers.Add("John");
            teamMembers.Add("Mary");
            teamMembers.Add("Tim");
            teamMembers.Add("Margaret");
            foreach(string X in teamMembers) 
            {
                rtbDisplay.AppendText(X + Environment.NewLine);
            }
        }

        private void btnInitialization_Click(object sender, EventArgs e)
        {
            List<string> teamMembers = new List<string>() { "John", "Mary", "Tim", "Margaret" };
            foreach (string X in teamMembers)
            {
                rtbDisplay.AppendText(X + Environment.NewLine);
            }
            //add a new member
            teamMembers.Add("Edward");
            //insert Peter between John and Mary
            teamMembers.Insert(1, "Peter");
            //remove "Tim"
            teamMembers.Remove("Tim");
            rtbDisplay.AppendText("Edward added, Peter Inserted and Tim removed" + Environment.NewLine);
            for (int x = 0; x <teamMembers.Count(); x++)
            {
                rtbDisplay.AppendText(teamMembers[x] + Environment.NewLine);
            }
            //sorting and displaying
            teamMembers.Sort();
            rtbDisplay.AppendText("After sorting: " + Environment.NewLine);
            for (int x = 0; x < teamMembers.Count(); x++)
            {
                rtbDisplay.AppendText(teamMembers[x] + Environment.NewLine);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string zodiac = System.IO.File.ReadAllText(@"U:\data\zodiac.txt");
            string[] x = zodiac.Split(',');
            zodiacList = x.ToList<string>();
        }

        private void btnSequentialSearch_Click(object sender, EventArgs e)
        {
            //squential search by traversing it
            rtbDisplay.Clear();
            foreach (string x in zodiacList)
            {
                if (x.ToUpper().Contains(txtSeach.Text.ToUpper()))
                    rtbDisplay.AppendText(x + Environment.NewLine);
            }
            if (rtbDisplay.TextLength!=0)
            {
                rtbDisplay.Text = txtSeach.Text + " is found: "
                    + Environment.NewLine + rtbDisplay.Text;            
            }
            else
            {
                rtbDisplay.Text = txtSeach.Text + " is not found: ";
            }
        }

        private void btnIndexOfSearch_Click(object sender, EventArgs e)
        {
            //indexOf method search
            int x = zodiacList.IndexOf(txtSeach.Text);
            if (x != -1)
            {
                rtbDisplay.Text = txtSeach.Text + " is found: " +
                    Environment.NewLine + zodiacList[x];
            }
            else
            {
                rtbDisplay.Text = txtSeach.Text + " is not found: ";
            }
        }

        private void btnListInt_Click(object sender, EventArgs e)
        {
            rtbDisplay.Text = "List works with all types, for example, with integer: "
                + Environment.NewLine;
            List<int> population = new List<int>() { 132000, 231322, 2223, 8900, 8132434 };
            foreach (int x in population)
            {
                rtbDisplay.AppendText(x.ToString() + Environment.NewLine);
            }
        }
        List<double> numberList = new List<double>() { 32.98, 2.15, 952 };
    }
}

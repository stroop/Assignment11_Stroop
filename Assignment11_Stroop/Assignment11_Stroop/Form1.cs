using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment11_Stroop
{
    public partial class Form1 : Form
    {
        // declare fields
        Friend friend;
        FileStream writeStream;
        FileStream readStream;
        StreamReader reader;
        StreamWriter writer;

        // constant(s)
        const string FILEPATH = "Friends.txt";
        const char DELIM = ',';

        // constructor
        public Form1()
        {
            // intitialize form
            InitializeComponent();
            // instantiate new friend object
            friend = new Friend();
            // tab deselected listeners
            tabControl1.Deselecting += new TabControlCancelEventHandler(tabControl1_Deslecting);

            // try/catch block to instantiate IO objects
            try
            {
                writeStream = new FileStream(FILEPATH, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                writer = new StreamWriter(writeStream);
                readStream = new FileStream(FILEPATH, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
                reader = new StreamReader(readStream);
            }
            catch(IOException e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void tabControl1_Deslecting(object sender, TabControlCancelEventArgs e)
        {
            
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            // set friend properties from text boxes
            friend.FirstName = firstNameTxt.Text;
            friend.LastName = lastNameTxt.Text;
            friend.PhoneNumber = phoneNumTxt.Text;
            friend.Month = Convert.ToInt32(birthMonthTxt.Text);
            friend.Day = Convert.ToInt32(birthDayTxt.Text);

            try
            {
                // write new friend to file
                writer.WriteLine(friend.ToString());
                // clear textboxes
                ClearTextBoxes();
                // display success message
                MessageBox.Show("Friend Added", friend.ToString());
                // flush stream buffer
                writeStream.Flush();
            }
            catch (IOException exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void ClearTextBoxes()
        {
            firstNameTxt.Text = "";
            lastNameTxt.Text = "";
            phoneNumTxt.Text = "";
            birthMonthTxt.Text = "";
            birthDayTxt.Text = "";
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            // get list of lines
            List<string> lines = ReadLinesFromfile();

            // for each line in the list, replace the delimiter
            // with a space and add it as a new list box item
            foreach(string line in lines)
            {
                readListBox.Items.Add(line.Replace(DELIM, ' '));
            }

        } // end read button handler
        
        // reminder button handler
        private void reminderBtn_Click(object sender, EventArgs e)
        {
            // get list of lines from file
            List<string> lines = ReadLinesFromfile();
            // loop through all lines
            foreach(string line in lines)
            {
                // create array of fields from each line
                string[] fields = line.Split(DELIM);
                // if friend month is equal to value from reminder text box,
                // then format that line and add it to the list box
                if(fields[3] == reminderTxt.Text)
                {
                    reminderListBox.Items.Add(String.Format("{0} {1} {2} {3}/{4}",
                        fields[0], fields[1], fields[2], fields[3], fields[4]));
                }
            }

            reminderTxt.Text = "";
        }

        // shared reader method returns list of lines
        private List<string> ReadLinesFromfile()
        {
            List<string> lines = new List<string>();

            try
            {
                string line;
                line = reader.ReadLine();
                while (line != null)
                {
                    lines.Add(line);

                    line = reader.ReadLine();
                }

                // reset pointer
                readStream.Seek(0, SeekOrigin.Begin);
            }
            catch (IOException excpetion)
            {
                MessageBox.Show(excpetion.ToString());
            }

            return lines;
        }

        // exit button handler
        private void exitBtn_Click(object sender, EventArgs e)
        {
            // close all IO objects
            reader.Close();
            writer.Close();
            readStream.Close();
            writeStream.Close();
            // call method to exit
            Dispose();
        }

        // second exit button calls primary exit button method
        private void exitBtn2_Click(object sender, EventArgs e)
        {
            exitBtn_Click(sender, e);
        }
        // third exit button calls primary exit button method
        private void exitBtn3_Click(object sender, EventArgs e)
        {
            exitBtn_Click(sender, e);
        }

        private void readTab_Click(object sender, EventArgs e)
        {

        }
    }
}

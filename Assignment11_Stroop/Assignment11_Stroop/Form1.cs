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
        // FileStream readStream;
        Friend friend;
        FileStream writeStream;
        // StreamReader reader;
        StreamWriter writer;

        // constant(s)
        const string FILEPATH = "Friends.txt";

        public Form1()
        {
            InitializeComponent();
            // instantiate new friend object
            //this.friend = new Friend();
            //readStream = new FileStream(FILEPATH, FileMode.OpenOrCreate, FileAccess.Read, FileShare.ReadWrite);
            

        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            // instantiate new friend
            friend = new Friend();

            friend.FirstName = firstNameTxt.Text;
            friend.LastName = lastNameTxt.Text;
            friend.PhoneNumber = phoneNumTxt.Text;
            friend.Month = Convert.ToInt32(birthMonthTxt.Text);
            friend.Day = Convert.ToInt32(birthDayTxt.Text);

            try
            {
                writeStream = new FileStream(FILEPATH, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
                writer = new StreamWriter(writeStream);

                writer.WriteLine(friend.ToString());

                Console.WriteLine("SUCCESSFUL WRITE");
            }
            catch (IOException)
            {
            }
            finally
            {
                writer.Close();
                Console.WriteLine("WRITER CLOSED");
                writeStream.Close();
                Console.WriteLine("STREAM CLOSED");
            }
        }
    }
}

///SR = Special Requirements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Cinema_Booking_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); ///This is stating what items there are going to be
            Genre.Items.Add("Action");
            Genre.Items.Add("Drama");
            Genre.Items.Add("Comedy");
            Genre.Items.Add("Horror");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }



        private void Genre_SelectedIndexChanged(object sender, EventArgs e)///This class lists all of the movies in their sections
        {
            if (Genre.Text == "Action")
            {
                FilmBox.Items.Clear();
                FilmBox.Items.Add("Black Panther");
                FilmBox.Items.Add("Upgrade");
                FilmBox.Items.Add("Avengers: Infinity War");
                FilmBox.Items.Add("Ready Player One");
                    
                    
            } 
            if (Genre.Text == "Drama")
            {
                FilmBox.Items.Clear();
                FilmBox.Items.Add("A Star Is Born");
                FilmBox.Items.Add("Searching");
                FilmBox.Items.Add("First Man");
                FilmBox.Items.Add("Leave No Trace");

            }
            if (Genre.Text == "Comedy")
            {
                FilmBox.Items.Clear();
                FilmBox.Items.Add("Blockers");
                FilmBox.Items.Add("Night School");
                FilmBox.Items.Add("Holmes & Watson");
                FilmBox.Items.Add("Game Night");
            }
            if (Genre.Text == "Horror")
            {
                FilmBox.Items.Clear();
                FilmBox.Items.Add("Halloween");
                FilmBox.Items.Add("Annihilation");
                FilmBox.Items.Add("The Nun");
                FilmBox.Items.Add("Insidious: The Last Key");
            }

        }

        private void button1_Click(object sender, EventArgs e) ///This is what is going to be outputted into the output file
        {
            if (First_Name.Text == "" | Last_Name.Text == "" | Genre.Text == "" | FilmBox.Text == "" | SR.Text == "" | Rows.Text == "" | Seats.Text == "")
            {
                MessageBox.Show("Please complete all sections", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"H:\app\booking.txt", true))
                {
                    file.WriteLine("First Name\r\n " + First_Name.Text + "\r\n\r\nLastName\r\n" + Last_Name.Text + "\r\n\r\nFilm\r\n" + FilmBox.Text + "\r\n\r\nSpecial Requirements\r\n" + SR.Text + "\r\n\r\nRows\r\n" + Rows.Text + "\r\n\r\nSeats\r\n" + Seats.Text + "\r\n\r\n_____________________\r\n\r\n");

                }
                First_Name.Clear();
                Last_Name.Clear();
                Genre.SelectedIndex = -1;
                FilmBox.Items.Clear();
                SR.Items.Clear();
                Rows.Items.Clear();
                Seats.Items.Clear(); ///Upon submit button being clicked it clears all of the boxes 
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void FilmBox_SelectedIndexChanged(object sender, EventArgs e) ///This is the special requirements class. This populates the SR Field if SR is needed
        {
            SR.Items.Clear();
            Rows.Items.Clear();
            SR.Items.Add("N/A");
            SR.Items.Add("Wheelchair Access");
        }

        private void Rows_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Rows.Text == "Any" | Rows.Text == "Rows 1-10" | Rows.Text == "Rows 11-20" | Rows.Text == "Rows 21-30") ///This shows the seats that area avaliable
            {
                Seats.Items.Clear();
                Seats.Items.Add("Any");
                Seats.Items.Add("Seats 1-6");
                Seats.Items.Add("Seats 7-12");
                Seats.Items.Add("Seats 13-18");
            }
        }

        private void SR_SelectedIndexChanged(object sender, EventArgs e)///Rows avalible based on SR requirements 
        {
            if (SR.Text == "N/A")
            {
                Rows.Items.Clear();
                Seats.Items.Clear();
                Rows.Items.Add("Any");
                Rows.Items.Add("Rows 1-10");
                Rows.Items.Add("Rows 11-20");
                Rows.Items.Add("Rows 21-30");
            }
            if (SR.Text == "Wheelchair Access")
            {
                Rows.Items.Clear();
                Seats.Items.Clear();
                Rows.Items.Add("Rows 1-10");
            }
        }

        private void Seats_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Last_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

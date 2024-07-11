using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

// Adding a ToggleButton and using List and Arrays
// Code modified by A. Bonner
// CSC202 Assignment 3.1 - Moonbase Alpha Simulation Coding Decision Logic into the FormMain.cs file

namespace CSC202_Moonbase_Alpha_Simulation // Namespace for the project
{
    public partial class FormMain : Form // FormMain class
    {

        private SoundPlayer doorSound = new SoundPlayer("turboliftdoor.wav"); // Star Trek Door Sound


        private Dictionary<string, string> areaNames = new Dictionary<string, string>(); // Dictionary to store area names
        private Dictionary<string, string> areaDescriptions = new Dictionary<string, string>(); // Dictionary to store area descriptions
        private Dictionary<string, string> areaImages = new Dictionary<string, string>(); // Dictionary to store area images
        private Dictionary<string, List<string>> movementOptions = new Dictionary<string, List<string>>(); // Dictionary to store movement options
        private string currentLocation; // Variable to hold the current location

        private List<string> locationsVisited = new List<string>(); // List to store visited locations
        private string[] directions = { "North", "West", "South", "East" }; // Array of directions



        public FormMain() // Constructor for the FormMain class
        {
            InitializeComponent(); // Initialize the form components
            InitializeAreaInformation(); // Initialize area information
            InitializeMovementOptions(); // Initialize movement options
        }
        //private SoundPlayer doorSound = new SoundPlayer("tos-turboliftdoor.wav"); // Star Trek Door Sound


        // private Dictionary<string, string> areaNames = new Dictionary<string, string>(); // Dictionary to store area names
        //private Dictionary<string, string> areaDescriptions = new Dictionary<string, string>(); // Dictionary to store area descriptions
        //private Dictionary<string, string> areaImages = new Dictionary<string, string>(); // Dictionary to store area images
        //private string currentLocation; // Variable to hold the current location
        private void InitializeAreaInformation() // Method to initialize area information
        {
            areaNames.Add("Command & Control Center", "Command & Control Center"); // Add the Command & Control Center area name
            areaNames.Add("Research & Development", "Research & Development"); // Add the Research & Development area name
            areaNames.Add("Courtyard", "Courtyard"); // Add the Courtyard area name
            areaNames.Add("Bedroom", "Bedroom"); // Add the Bedroom area name

            areaDescriptions.Add("Command & Control Center", "The Control Room is the nerve center of the Moonbase."); // Add the Command & Control Center area description
            areaDescriptions.Add("Research & Development", "The Research and Development Lab is where new technologies are developed."); // Add the Research & Development area description
            areaDescriptions.Add("Courtyard", "The Courtyard is a place for relaxation and recreation."); // Add the Courtyard area description
            areaDescriptions.Add("Bedroom", "The Bedroom is where guests rest and sleep."); // Add the Bedroom area description

            areaImages.Add("Command & Control Center", "Future Lunar Command Room.jpg"); // Add the Command & Control Center area image
            areaImages.Add("Research & Development", "Lunar Moonbase R&D Lab.png"); // Add the Research & Development area image
            areaImages.Add("Courtyard", "Future Moonbase Alpha.jpg"); // Add the Courtyard area image
            areaImages.Add("Bedroom", "Lunar Moonbase Bedroom.jpg"); // Add the Bedroom area image

            currentLocation = "Command & Control Center"; // Set the current location to the Command & Control Center
            UpdateForm(currentLocation); // Update the form with the current location

             
    }
        private void InitializeMovementOptions() // Method to initialize movement options
        {
            movementOptions.Add("Command & Control Center", new List<string> { "West", "South", "East" }); // Add movement options for the Command & Control Center
            movementOptions.Add("Research & Development", new List<string> { "East" });
            movementOptions.Add("Courtyard", new List<string> { "North", "East" });
            movementOptions.Add("Bedroom", new List<string> { "West" });

        }




        private void UpdateForm(string newLocation) // Method to update the form with a new location
        {
            try
            {
                this.BackgroundImage = Image.FromFile(areaImages[newLocation]); // Set the background image
            }
            catch (Exception ex) // Catch any exceptions
            {
                MessageBox.Show("Error loading image for " + newLocation + ": " + ex.Message); // Display an error message
            }

            this.Text = areaNames[newLocation]; // Set the form title (area name)
            textBoxRoom.Text = areaNames[newLocation]; // Set the label text (area name)
            textBoxExplain.Text = areaDescriptions[newLocation]; // Set the textbox content (area description)
        }






        private void BTNcontrol_Click(object sender, EventArgs e) // Event handler for the Control Room button
        {
            MessageBox.Show("This is the Lunar Command and control Room."); // Display a message box
        }

        private void BTNabout_Click(object sender, EventArgs e) // Event handler for the About button
        {
            DialogBox newForm = new DialogBox(); // Create a new instance of the DialogBox form
            newForm.textBoxLocation.Text =
        "The Lunar Moonbase Command Control Room is the nerve center for explorations on the Moon. " +
        "From here, engineers and scientists monitor spacecraft, analyze data, and " +
        "communicate with teams  on the lunar surface. It's a vital role " +
        "in ensuring the success of lunar exploration!";
            newForm.ShowDialog(); // Show the DialogBox form

            newForm.Close(); // Close the DialogBox form



        }


        private void BTNexit_Click(object sender, EventArgs e) // Event handler for the Exit button
        {
            // 
            Application.Exit(); // Exit the application
        }

        private void BTNnorth_Click(object sender, EventArgs e) // North Button is default room(default Background Image) Control Room
        {
            if (movementOptions[currentLocation].Contains("North")) // Check if the current location has a North movement option
            {
                doorSound.Play(); // Play the sound effect
                UpdateForm("Command & Control Center"); // Update the form with the Command & Control Center
                ToggleButtons(BTNnorth); // Disable the North Button
            }
            else
            {
                MessageBox.Show("You cannot go North!"); // Display a message box
            }
            

            //try
            // {
            //    this.BackgroundImage = Image.FromFile("Future Lunar Command Room.jpg"); // Set the Background Image
            //    textBoxRoom.Text = areaNames["Command & Control Center"]; // Set label text North
            //    textBoxExplain.Text = areaDescriptions["The Control Room is the nerve center of the Moonbase."]; // Set textbox content (area description)
            // }
            //catch (Exception ex)
            //{
            // MessageBox.Show("Error loading image: " + ex.Message); //
            //}
            // this.BackgroundImage = Image.FromFile("Future Lunar Command Room.jpg"); // Set the Background Image to the North Room

            {


            }
        }

        private void BTNwest_Click(object sender, EventArgs e) // West Button is the R&D Lab
        {
            if (movementOptions[currentLocation].Contains("West")) // Check if the current location has a West movement option
            {
                doorSound.Play(); // Play the sound effect
                UpdateForm("Research & Development"); // Update the form with the Research & Development Lab
                ToggleButtons(BTNwest); // Disable the West Button                                     
            }
            else
            {
                MessageBox.Show("You cannot go West from here."); // Display a message box
            }
                                                  // try
                                                  //{
                                                  //   this.BackgroundImage = Image.FromFile("Lunar Moonbase R&D Lab.png"); // Set the Background Image
                                                  //    textBoxRoom.Text = areaNames["Research & Development"]; //  label text West
                                                  //    textBoxExplain.Text = areaDescriptions["The Research and Development Lab is where new technologies are developed."]; // Set textbox content (area description)
                                                  //}
                                                  // catch (Exception ex) // Catch any exceptions
                                                  //{
                                                  //     MessageBox.Show("Error loading image: " + ex.Message); // Display error message
                                                  //}




            //this.BackgroundImage = Image.FromFile("Lunar Moonbase R&D Lab.png"); // Set the Background Image to the R&D Lab
        }

        private void BTNsouth_Click(object sender, EventArgs e) // South Button is the Courtyard
        {
            if (movementOptions[currentLocation].Contains("South"))
            {
                doorSound.Play(); // Play the sound effect
                UpdateForm("Courtyard"); // Update the form with the Courtyard
                ToggleButtons(BTNsouth); // Disable the South Button
            }
            else
            {
                MessageBox.Show("You cannot go South from here."); // Display a message box
            }
                                    
                                    // try
                                     // {
                                     //     this.BackgroundImage = Image.FromFile("Future Moonbase Alpha.jpg"); // Set the Background Image
                                     //     textBoxRoom.Text = areaNames["Courtyard"]; //  label South
                                     //     textBoxExplain.Text = areaDescriptions["The Courtyard is a place for relaxation and recreation."]; // Set textbox content (area description)
                                     // }
                                     // catch (Exception ex) // Catch any exceptions
                                     // {
                                     //    MessageBox.Show("Error loading image: " + ex.Message); // Display error message
                                     //}
                                     //this.BackgroundImage = Image.FromFile("Future Moonbase Alpha.jpg"); // Set the Background Image to the Courtyard
        }

        private void BTNeast_Click(object sender, EventArgs e) // East Button is the Bedroom
        {
            if (movementOptions[currentLocation].Contains("East"))
            {
                doorSound.Play(); // Play the sound effect
                UpdateForm("Bedroom"); // Update the form with the Bedroom
                ToggleButtons(BTNeast); // Disable the East Button

            }
            
            else
            {                 
                MessageBox.Show("You cannot go East from here."); // Display a message box
            
            }
            
            // try
                                   // {
                                   //     this.BackgroundImage = Image.FromFile("Lunar Moonbase Bedroom.jpg"); // Set the Background Image
                                   //     textBoxRoom.Text = areaNames["Bedroom"]; //  label  East
                                   //     textBoxExplain.Text = areaDescriptions["The Bedroom is where guests rest and sleep."]; // Set textbox content (area description)
                                   // }
                                   // catch (Exception ex) // Catch any exceptions
                                   //  {
                                   //      MessageBox.Show("Error loading image: " + ex.Message); // Display error message
                                   //}
                                   // this.BackgroundImage = Image.FromFile("Lunar Moonbase Bedroom.jpg");
        }
        // When the button is clicked, the button is disabled and the other buttons are enabled.
        private void ToggleButtons( Button clickedButton) // Event handler for the Toggle Button
        {
            BTNnorth.Enabled = true; // Enable the North Button
            BTNwest.Enabled = true; // Enable the West Button
            BTNsouth.Enabled = true; // Enable the South Button
            BTNeast.Enabled = true; // Enable the East Button
            BTNcontrol.Enabled = true; // Enable the Control Room Button
            BTNabout.Enabled = true; // Enable the About Button

            clickedButton.Enabled = false; // Disable the clicked button
            
            //Button button = (Button)sender; // Cast the sender as a Button
           // button.Text = button.Text == "ON" ? "OFF" : "ON"; // Toggle the button text
                                                              
        }


        private void FormMain_Load(object sender, EventArgs e) // Event handler for the FormMain Load event
        {

        }

    }
}




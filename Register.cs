using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Data.SqlClient;
using BCrypt.Net;


namespace Blackjack_New
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.Gambling_background;

            btn_Register.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Register.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Register.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Register.BackColor = Color.Red;    // sets background colour of button as red
            btn_Register.Font = new Font("Bahnschrift SemiBold", 16);  // Sets the font and size of text
            // Sets the colour of the button when mouse is hovering over it and when clicked            
            btn_Register.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Register.FlatAppearance.MouseDownBackColor = Color.DarkRed;

            btn_Back.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Back.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Back.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Back.BackColor = Color.Red;    // sets background colour of button as red
            btn_Back.Font = new Font("Bahnschrift SemiBold", 16);  // Sets the font and size of text
            // Sets the colour of the button when mouse is hovering over it and when clicked
            btn_Back.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Back.FlatAppearance.MouseDownBackColor = Color.DarkRed;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Startup startup = new Startup();     // Create an instance of startup
            startup.Show();                      // Shows the startup form
            this.Hide();                         // Hides the register form
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;       // Storing the users' details into variables
            string password1 = txt_Password1.Text;     //
            string password2 = txt_Password2.Text;     //

            if (password1 != password2)                         // Checking that the passwords match
            {                                                   // to prevent an incorrectly stored password
                MessageBox.Show("Passwords do not match");
            }            
            
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\NEA\BlackJack\Blackjack New\Blackjack New\RegisterDB.mdf"";Integrated Security=True");
            connection.Open();      // Connected the database table

            string CheckDuplicateUsername = "SELECT COUNT(*) FROM RegisterTBL WHERE Username = @UsernamePlaceholder";     // SQL query to check for existing usernames
            SqlCommand checkCmd = new SqlCommand(CheckDuplicateUsername, connection);                   // Creates an object that runs the query

            checkCmd.Parameters.AddWithValue("@UsernamePlaceholder", username);       // Puts the data in variable username in UsernamePlaceholder

            int userCount = (int)checkCmd.ExecuteScalar();          // Counts the number of times that same username is in the table

            if (userCount > 0)
            {
                MessageBox.Show("That username is already taken.");        // Displays error message        
            }

            if (password1 == password2 && userCount == 0)
            {
                string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password1);                            // Hashes the password
                string StoreDetails = "INSERT INTO RegisterTBL VALUES(@UsernamePlaceholder, @passwordHash, 100)";   // Stores SQL query in string
                SqlCommand StoreCmd = new SqlCommand(StoreDetails, connection);                                     // Creates the object command for the query

                StoreCmd.Parameters.AddWithValue("@UsernamePlaceholder", username);     // Stores the username in the placeholder
                StoreCmd.Parameters.AddWithValue("@passwordHash", passwordHash);        // Stores the password in the placeholder

                StoreCmd.ExecuteNonQuery();     // Executes the command, which executes the SQL query and inputs the username and password into the table                

                Menu menu = new Menu(username);         // Pass the username variable into the Menu form                        
                menu.Show();
                this.Close();
            }
            

        }

        private void txt_Password2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

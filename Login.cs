using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Blackjack_New
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.Gambling_background;

            btn_Login.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Login.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Login.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Login.BackColor = Color.Red;    // sets background colour of button as red
            btn_Login.Font = new Font("Bahnschrift SemiBold", 16);  // Sets the font and size of text
            // Sets the colour of the button when mouse is hovering over it and when clicked
            btn_Login.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Login.FlatAppearance.MouseDownBackColor = Color.DarkRed;

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
            Startup startup = new Startup();    // Creates an instance of the Startup form
            startup.Show();                     // Opens the form
            this.Hide();                        // Hides the Login form
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;            

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\NEA\BlackJack\Blackjack New\Blackjack New\RegisterDB.mdf"";Integrated Security=True");
            connection.Open();      // Connected the database table

            string CheckPassword = "SELECT Password FROM RegisterTBL WHERE Username = @UsernamePlaceholder";
            SqlCommand checkCmd = new SqlCommand(CheckPassword, connection);        // SQL query to check for records where the username and password exists

            checkCmd.Parameters.AddWithValue("@UsernamePlaceholder", username);     // Stores the username in the placeholder
            
            string StoredPasswordHash = (string)checkCmd.ExecuteScalar();          // Stores the password hash from table into StoredPasswordHash
            
            if (StoredPasswordHash == null)                             // Checks whether username exists
            {
                MessageBox.Show("Username or password is invalid");     // if username doesn't exist, display error message
            }
            else        // If username exists, only then compare the inputted password and the password hash in the table   
            {
                bool verifyPassword = BCrypt.Net.BCrypt.EnhancedVerify(password, StoredPasswordHash);   // Checks that the password hash matches inputted password

                if (verifyPassword == false)                                // If password doesn't match
                {
                    MessageBox.Show("Username or password is invalid");     // it displays an error message
                }
                else                                                        // Else, it takes the user to the menu
                {
                    Menu menu = new Menu(username);         // Pass the username variable into the Menu form                        
                    menu.Show();
                    this.Close();
                }
            }
            
        }
    }
}

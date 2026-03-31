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
    public partial class Menu : Form
    {
        private string loggedin_username;   // Variable to hold the username 

        public Menu(string username)        // Passing in the username variable from login
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.Gambling_background;
            loggedin_username = username;   // Sets loggedin_username as the data in username

            btn_Play.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Play.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Play.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Play.BackColor = Color.Red;    // sets background colour of button as red
            btn_Play.Font = new Font("Bahnschrift SemiBold", 16);  // Sets the font and size of text
            // Sets the colour of the button when mouse is hovering over it and when clicked
            btn_Play.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Play.FlatAppearance.MouseDownBackColor = Color.DarkRed;

            btn_Balance.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Balance.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Balance.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Balance.BackColor = Color.Red;    // sets background colour of button as red
            btn_Balance.Font = new Font("Bahnschrift SemiBold", 16);  // Sets the font and size of text
            // Sets the colour of the button when mouse is hovering over it and when clicked
            btn_Balance.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Balance.FlatAppearance.MouseDownBackColor = Color.DarkRed;

            btn_Exit.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Exit.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Exit.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Exit.BackColor = Color.Red;    // sets background colour of button as red
            btn_Exit.Font = new Font("Bahnschrift SemiBold", 16);  // Sets the font and size of text
            // Sets the colour of the button when mouse is hovering over it and when clicked
            btn_Exit.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Exit.FlatAppearance.MouseDownBackColor = Color.DarkRed;
        }

        private void btn_Balance_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=C:\NEA\BLACKJACK\BLACKJACK NEW\BLACKJACK NEW\REGISTERDB.MDF;Integrated Security=True");
            connection.Open();      // Connected the database table

            string query_balance = "SELECT Balance FROM RegisterTBL WHERE Username = @usernameplaceholder"; // SQL query to search for balance
            SqlCommand display_balance = new SqlCommand(query_balance, connection);     // Create the command object

            display_balance.Parameters.AddWithValue("@usernameplaceholder", loggedin_username);     // Stores username in placeholder

            object object_balance= display_balance.ExecuteScalar();        // Executes query and stores the balance in the variable
            int balance = Convert.ToInt32(object_balance);

            MessageBox.Show("Your current balance is " + balance);  // Displays message indicating remaining balance
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();     // Closes the game
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            AskBet askBet = new AskBet(loggedin_username);
            askBet.Show();
            this.Close();
        }
    }
}

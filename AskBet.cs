using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace Blackjack_New
{
    public partial class AskBet : Form
    {
        private string loggedin_username;
        public AskBet(string username)
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.Gambling_background;
            loggedin_username = username;

            btn_Play.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Play.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Play.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Play.BackColor = Color.Red;    // sets background colour of button as red
            btn_Play.Font = new Font("Bahnschrift SemiBold", 16);   // Sets the font and size of text
            btn_Play.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Play.FlatAppearance.MouseDownBackColor = Color.DarkRed;

            btn_Back.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Back.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Back.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Back.BackColor = Color.Red;    // sets background colour of button as red
            btn_Back.Font = new Font("Bahnschrift SemiBold", 16);   // Sets the font and size of text
            btn_Back.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Back.FlatAppearance.MouseDownBackColor = Color.DarkRed;
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            int bet = (int) num_AskBet.Value;

            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\NEA\BlackJack\Blackjack New\Blackjack New\RegisterDB.mdf"";Integrated Security=True");
            connection.Open();      // Connected the database table

            // Stores the SQL query in query balance
            string query_balance = "SELECT Balance FROM RegisterTBL WHERE Username = @UsernamePlaceholder";     
            SqlCommand CheckUserBalance = new SqlCommand(query_balance, connection);

            // Swaps the placeholder for the username for added security instead of directly using the username
            CheckUserBalance.Parameters.AddWithValue("@UsernamePlaceholder", loggedin_username);
            
            //Executes the query and stores it in objectBalance, then stores it in balance, while changing the data type to from object to int
            object objectBalance = CheckUserBalance.ExecuteScalar();
            int balance = Convert.ToInt32(objectBalance);

            // Checks whether the bet is greater than the user's balance
            if (bet > balance)
            {
                MessageBox.Show("You don't have " + bet + " in your account");
            }

            if (bet <= balance)
            {
                // When the user inputs a valid bet, they will be taken to the Play form
                Play play = new Play(loggedin_username, bet);     // Creates an instance of the Play form 
                play.Show();                // and passes the username linked to the account
                this.Close();
            }
            
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(loggedin_username);         // Pass the username variable into the Menu form                        
            menu.Show();
            this.Close();
        }
    }
}

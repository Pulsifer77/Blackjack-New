using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Blackjack_New
{
    public partial class Play : Form
    {
        public class Deck           // Class for the deck with attributes, image, name and value
        {
            public Image image;
            public string name;            
            public int value;         

            public Deck(Image image, string name, int value)    // Constructor for the deck
            {
                this.image = image;
                this.name = name;
                this.value = value;
            }

        }

        private int UserBet;
        private string loggedin_username;
        public Play(string username, int bet)
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.Gambling_background;

            btn_Start.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Start.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Start.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Start.BackColor = Color.Red;    // sets background colour of button as red
            btn_Start.Font = new Font("Bahnschrift SemiBold", 16);  // Sets the font and size of text
            // Sets the colour of the button when mouse is hovering over it and when clicked
            btn_Start.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Start.FlatAppearance.MouseDownBackColor = Color.DarkRed;

            btn_Hit.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Hit.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Hit.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Hit.BackColor = Color.Red;    // sets background colour of button as red
            btn_Hit.Font = new Font("Bahnschrift SemiBold", 16);  // Sets the font and size of text
            // Sets the colour of the button when mouse is hovering over it and when clicked
            btn_Hit.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Hit.FlatAppearance.MouseDownBackColor = Color.DarkRed;

            btn_Stand.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Stand.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Stand.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Stand.BackColor = Color.Red;    // sets background colour of button as red
            btn_Stand.Font = new Font("Bahnschrift SemiBold", 16);  // Sets the font and size of text
            // Sets the colour of the button when mouse is hovering over it and when clicked
            btn_Stand.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Stand.FlatAppearance.MouseDownBackColor = Color.DarkRed;

            loggedin_username = username;
            UserBet = bet;           

            // Creates the Player picture boxes
            PlayerPictureBoxes = new PictureBox[] { PlayerPictureBox1, PlayerPictureBox2 };
            DealerPictureboxes = new PictureBox[] { DealerPictureBox1, DealerPictureBox2 };            
        }

        private void Play_Load(object sender, EventArgs e)
        {

        }       

        private Deck[] card = new Deck[52];        
        public void LoadDeck()
        {            
            int i = 0;

            // Below, each card is becoming an object, with its own image, value and name

            card[i] = new Deck(Properties.Resources.Ace_of_Clubs, "Ace of Clubs", 11);              // Ace
            card[i++] = new Deck(Properties.Resources.Ace_of_Diamonds, "Ace of Diamonds", 11);
            card[i++] = new Deck(Properties.Resources.Ace_of_Hearts, "Ace of Hearts", 11);
            card[i++] = new Deck(Properties.Resources.Ace_of_Spades, "Ace of Spades", 11);

            card[i++] = new Deck(Properties.Resources._2_of_Clubs, "2 of Clubs", 2);              // 2
            card[i++] = new Deck(Properties.Resources._2_of_Diamonds, "2 of Diamonds", 2);
            card[i++] = new Deck(Properties.Resources._2_of_Hearts, "2 of Hearts", 2);
            card[i++] = new Deck(Properties.Resources._2_of_Spades, "2 of Spades", 2);

            card[i++] = new Deck(Properties.Resources._3_of_Clubs, "3 of Clubs", 3);              // 3
            card[i++] = new Deck(Properties.Resources._3_of_Diamonds, "3 of Diamonds", 3);
            card[i++] = new Deck(Properties.Resources._3_of_Hearts, "3 of Hearts", 3);
            card[i++] = new Deck(Properties.Resources._3_of_Spades, "3 of Spades", 3);

            card[i++] = new Deck(Properties.Resources._4_of_Clubs, "4 of Clubs", 4);              // 4
            card[i++] = new Deck(Properties.Resources._4_of_Diamonds, "4 of Diamonds", 4);
            card[i++] = new Deck(Properties.Resources._4_of_Hearts, "4 of Hearts", 4);
            card[i++] = new Deck(Properties.Resources._4_of_Spades, "4 of Spades", 4);

            card[i++] = new Deck(Properties.Resources._5_of_Clubs, "5 of Clubs", 5);              // 5
            card[i++] = new Deck(Properties.Resources._5_of_Diamonds, "5 of Diamonds", 5);
            card[i++] = new Deck(Properties.Resources._5_of_Hearts, "5 of Hearts", 5);
            card[i++] = new Deck(Properties.Resources._5_of_Spades, "5 of Spades", 5);

            card[i++] = new Deck(Properties.Resources._6_of_Clubs, "6 of Clubs", 6);              // 6
            card[i++] = new Deck(Properties.Resources._6_of_Diamonds, "6 of Diamonds", 6);
            card[i++] = new Deck(Properties.Resources._6_of_Hearts, "6 of Hearts", 6);
            card[i++] = new Deck(Properties.Resources._6_of_Spades, "6  of Spades", 6);

            card[i++] = new Deck(Properties.Resources._7_of_Clubs, "7 of Clubs", 7);              // 7
            card[i++] = new Deck(Properties.Resources._7_of_Diamonds, "7 of Diamonds", 7);
            card[i++] = new Deck(Properties.Resources._7_of_Hearts, "7 of Hearts", 7);
            card[i++] = new Deck(Properties.Resources._7_of_Spades, "7 of Spades", 7);

            card[i++] = new Deck(Properties.Resources._8_of_Clubs, "8 of Clubs", 8);              // 8
            card[i++] = new Deck(Properties.Resources._8_of_Diamonds, "8 of Diamonds", 8);
            card[i++] = new Deck(Properties.Resources._8_of_Hearts, "8 of Hearts", 8);
            card[i++] = new Deck(Properties.Resources._8_of_Spades, "8 of Spades", 8);

            card[i++] = new Deck(Properties.Resources._9_of_Clubs, "9 of Clubs", 9);              // 9
            card[i++] = new Deck(Properties.Resources._9_of_Diamonds, "9 of Diamonds", 9);
            card[i++] = new Deck(Properties.Resources._9_of_Hearts, "9 of Hearts", 9);
            card[i++] = new Deck(Properties.Resources._9_of_Spades, "9 of Spades", 9);

            card[i++] = new Deck(Properties.Resources._10_of_Clubs, "10 of Clubs", 10);              // 10
            card[i++] = new Deck(Properties.Resources._10_of_Diamonds, "10 of Diamonds", 10);
            card[i++] = new Deck(Properties.Resources._10_of_Hearts, "10 of Hearts", 10);
            card[i++] = new Deck(Properties.Resources._10_of_Spades, "10 of Spades", 10);

            card[i++] = new Deck(Properties.Resources.Jack_of_Clubs, "Jack of Clubs", 10);              // Jack
            card[i++] = new Deck(Properties.Resources.Jack_of_Diamonds, "Jack of Diamonds", 10);
            card[i++] = new Deck(Properties.Resources.Jack_of_Hearts, "Jack of Hearts", 10);
            card[i++] = new Deck(Properties.Resources.Jack_of_Spades, "Jack of Spades", 10);

            card[i++] = new Deck(Properties.Resources.Queen_of_Clubs, "Queen of Clubs", 10);              // Queen
            card[i++] = new Deck(Properties.Resources.Queen_of_Diamonds, "Queen of Diamonds", 10);
            card[i++] = new Deck(Properties.Resources.Queen_of_Hearts, "Queen of Hearts", 10);
            card[i++] = new Deck(Properties.Resources.Queen_of_Spades, "Queen of Spades", 10);

            card[i++] = new Deck(Properties.Resources.King_of_Clubs, "King of Clubs", 10);              // King
            card[i++] = new Deck(Properties.Resources.King_of_Diamonds, "King of Diamonds", 10);
            card[i++] = new Deck(Properties.Resources.King_of_Hearts, "King of Hearts", 10);
            card[i++] = new Deck(Properties.Resources.King_of_Spades, "King of Spades", 10);            
            
        }
        

        // List that will contain a random sequence of numbers 0-51
        // This contains only one of each number, so won't deal multiple identical cards
        private List<int> order;
        
        // Start of the list of numbers
        private int deal_index = 0;

        public void ShuffleCards()
        {
            // Creates a list of numbers 0 - 51
            order = Enumerable.Range(0, 52).ToList();

            // Shuffles the list
            Random rnd_card = new Random();
            order = order.OrderBy(x  => rnd_card.Next()).ToList();

            // Reset the dealing position of the list
            deal_index = 0;
        }

        
        private Deck DealCard()     // Puts a random card in a new object random_card
        {
            Deck random_card = card[order[deal_index]];
            deal_index++;
            return random_card;
        }

        private void DisplayCard(Deck card, PictureBox box)
        {
            // Procedure to set the card image as the picture box
            box.Image = card.image;
        }

        private int PlayerTotal;        // Player's total points
        private int DealerTotal;        

        private PictureBox[] PlayerPictureBoxes;    // Variable to store the pictures of the Player's cards
        private PictureBox[] DealerPictureboxes;    // Variable to store the pictures of the Dealer's cards

        private Deck PlayerCard1;
        private Deck PlayerCard2;
        private Deck DealerHiddenCard;
        private Deck DealerCard2;

        private bool StartClicked = false;
        private void btn_Start_Click(object sender, EventArgs e)
        {
            // Checks whether the user already clicked Start and prevents them from re-dealing the cards if they have
            if (StartClicked == true)
            {
                MessageBox.Show("You have already clicked Start, please click either Hit or Stand");
            }
            else
            {
                LoadDeck();         // Loads the deck of cards
                ShuffleCards();     // Calls the subroutine

                PlayerTotal = 0;    // Sets the score as 0 for player
                DealerTotal = 0;    // Sets the score as 0 for dealer

                //Random two cards for the player
                PlayerCard1 = DealCard();
                PlayerCard2 = DealCard();

                //Random two cards for the dealer
                DealerHiddenCard = DealCard();
                DealerCard2 = DealCard();

                // Display player's cards
                DisplayCard(PlayerCard1, PlayerPictureBox1);
                DisplayCard(PlayerCard2, PlayerPictureBox2);

                // Display one of dealer's cards and keep the other hidden
                DealerPictureBox1.Image = Properties.Resources.Back_of_card;
                DisplayCard(DealerCard2, DealerPictureBox2);

                // Stores the player's and dealer's cards' values
                PlayerTotal = PlayerCard1.value + PlayerCard2.value;
                DealerTotal = DealerHiddenCard.value + DealerCard2.value;

                StartClicked = true;
            }
            
        }

        private int Player_NewCardDistance = 42;   // Distance between each card
        private Deck[] PlayerCard_Hit = new Deck[10];   // New object with an array of extra cards
        private int PlayerHit_index = 0;      // Counter for the number of times the user has clicked Hit

        private PictureBox[] PlayerExtra_PB = new PictureBox[10];    // Extra Picture boxes for the extra cards        
        private void btn_Hit_Click(object sender, EventArgs e)
        {
            // Creates a new picture box with the same size and moves the new card right by a bit
            PlayerExtra_PB[PlayerHit_index] = new PictureBox();            

            PlayerExtra_PB[PlayerHit_index].Width = 70;
            PlayerExtra_PB[PlayerHit_index].Height = 98;
            PlayerExtra_PB[PlayerHit_index].SizeMode = PictureBoxSizeMode.StretchImage;
            PlayerExtra_PB[PlayerHit_index].Location = new Point(235 + Player_NewCardDistance, 294);
            this.Controls.Add(PlayerExtra_PB[PlayerHit_index]);   // Puts the Picture box in the form
            PlayerExtra_PB[PlayerHit_index].BringToFront();   // Puts the new card in the foreground

            PlayerCard_Hit[PlayerHit_index] = DealCard();     // Deals a card

            DisplayCard(PlayerCard_Hit[PlayerHit_index], PlayerExtra_PB[PlayerHit_index]);  // Displays the image of the new card

            PlayerTotal += PlayerCard_Hit[PlayerHit_index].value;     // Adds the value of the card to the user's total            

            PlayerHit_index++;                // Increments the counter by one
            Player_CheckBust();
            Player_NewCardDistance += 42;      // Sets the distance for the next card
        }


        private SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\NEA\BlackJack\Blackjack New\Blackjack New\RegisterDB.mdf"";Integrated Security=True");
        private string query_balance = "SELECT Balance FROM RegisterTBL WHERE Username = @UsernamePlaceholder";
        private string query_UpdateBalance = "UPDATE RegisterTBL SET Balance = @BalancePlaceholder WHERE Username = @UsernamePlaceholder";

        private int user_balance;
        private int final_balance;
        
        private void Player_CheckBust()
        {
            if (PlayerTotal > 21)       // First checks if the player has gone bust
            {
                int num_Aces = 0;       // Counter for the number of Aces in hand
                PlayerTotal = 0;

                PlayerTotal = PlayerCard1.value + PlayerCard2.value;

                for (int i = 0; i < PlayerHit_index; i++)
                {
                    PlayerTotal += PlayerCard_Hit[i].value;
                }
                
                if (PlayerCard1.value == 11)    // Counts the number of Aces the Player has
                {
                    num_Aces++;
                }

                if (PlayerCard2.value == 11)
                {
                    num_Aces++;
                }
                
                for (int i = 0; i < PlayerHit_index; i++)
                {
                    if (PlayerCard_Hit[i].value == 11)
                    {
                        num_Aces++;
                    }
                }

                while (PlayerTotal > 21 &&  num_Aces > 0)   // Views an Ace as 1 point if over 21 points
                {
                    PlayerTotal -= 10;
                    num_Aces--;
                }

                if (PlayerTotal > 21)      // If the user is still over 21 points, they lose their bet
                {
                    user_balance = 0;       // resets the value of the variable to 0
                    final_balance = 0;      // resets the value of the variable to 0

                    connection.Open();          // Opens the connection with the database

                    SqlCommand CheckBalance = new SqlCommand(query_balance, connection);    // Creates the command to check the user's balance
                    CheckBalance.Parameters.AddWithValue("@UsernamePlaceholder", loggedin_username);    // Uses loggedin_username in place of the placeholder
                    object balance = CheckBalance.ExecuteScalar();  // Stores the retrieved balance
                    user_balance = Convert.ToInt32(balance);   // Stores it into a variable of type integer

                    final_balance = user_balance - UserBet; // Calculates the balance by deducting the user's bet from their current balance

                    SqlCommand UpdateBalance = new SqlCommand(query_UpdateBalance, connection); // Creates the command to update the user's balance
                    UpdateBalance.Parameters.AddWithValue("@UsernamePlaceholder", loggedin_username);   // Uses loggedin_username in place of the placeholder 
                    UpdateBalance.Parameters.AddWithValue("@BalancePlaceholder", final_balance);    // Uses final_balance in place of the placeholder

                    UpdateBalance.ExecuteNonQuery();    // Executes the SQL query

                    connection.Close();

                    // Message telling the user that they have lost, how much money they lost and how much they have left in their account
                    MessageBox.Show("You have gone bust");
                    MessageBox.Show("You had " + PlayerTotal + " points and the Dealer had " + DealerTotal + " points");
                    MessageBox.Show("You lost " + UserBet + " and now have " + final_balance + " remaining");

                    // Allows the user to click the Start button again
                    StartClicked = false;

                    Menu menu = new Menu(loggedin_username);    // Takes the user back to the menu
                    menu.Show();
                    this.Close();
                }
            }
        }

        
        private void Dealer_CheckBust()
        {
            if (DealerTotal > 21)       // First checks if the Dealer has gone bust
            {
                int num_Aces = 0;       // Counter for the number of Aces in hand

                if (DealerHiddenCard.value == 11)   // Counts the number of Aces the Dealer has
                {
                    num_Aces++;
                }

                if (DealerCard2.value == 11)
                {
                    num_Aces++;
                }

                for (int i = 0; i < DealerHit_index; i++)
                {
                    if (DealerCard_Hit[i].value == 11)
                    {
                        num_Aces++;
                    }
                }

                while (DealerTotal > 21 && num_Aces > 0)    // Views an Ace as 1 point if over 21 points
                {
                    DealerTotal -= 10;
                    num_Aces--;
                }

                if (num_Aces == 0 && DealerTotal > 21)  // If the user is still over 21 points, they lose their bet
                {
                    user_balance = 0;       // resets the value of the variable to 0
                    final_balance = 0;      // resets the value of the variable to 0

                    connection.Open();          // Opens the connection with the database

                    // Creates the command to check the user's balance
                    // Uses loggedin_username in place of the placeholder
                    SqlCommand CheckBalance = new SqlCommand(query_balance, connection);    
                    CheckBalance.Parameters.AddWithValue("@UsernamePlaceholder", loggedin_username);
                    
                    object balance = CheckBalance.ExecuteScalar();  // Stores the retrieved balance
                    user_balance = Convert.ToInt32(balance);   // Stores it into a variable of type integer

                    final_balance = user_balance + UserBet; // Calculates the balance by deducting the user's bet from their current balance

                    // Creates the command to update the user's balance
                    // Uses loggedin_username in place of the placeholder
                    // Uses final_balance in place of the placeholder
                    SqlCommand UpdateBalance = new SqlCommand(query_UpdateBalance, connection); 
                    UpdateBalance.Parameters.AddWithValue("@UsernamePlaceholder", loggedin_username);    
                    UpdateBalance.Parameters.AddWithValue("@BalancePlaceholder", final_balance);    

                    UpdateBalance.ExecuteNonQuery();    // Executes the SQL query

                    connection.Close();

                    // Message telling the user that they have lost, how much money they lost and how much they have left in their account
                    MessageBox.Show("The Dealer has gone bust, you have won!");
                    MessageBox.Show("You win " + UserBet + " and now have " + final_balance + " remaining");

                    DealerBust = true;

                    // Allows the user to click the Start button again
                    StartClicked = false;

                    Menu menu = new Menu(loggedin_username);    // Takes the user back to the menu
                    menu.Show();
                    this.Close();
                    
                    
                }
            }
        }

        private int Dealer_NewCardDistance = 42;
        private Deck[] DealerCard_Hit = new Deck[10];
        private int DealerHit_index = 0;

        private PictureBox[] DealerExtra_PB = new PictureBox[10];

        private bool DealerBust = false;
        private void btn_Stand_Click(object sender, EventArgs e)
        {            
            DealerPictureBox1.Image = DealerHiddenCard.image;   // Turns the hidden card face up

            while (DealerTotal < 17)    // Only draws a card if the Dealer's points is less than 17
            {
                // Creates a new picture box with the same size and moves the new card right by a bit
                DealerExtra_PB[DealerHit_index] = new PictureBox();

                DealerExtra_PB[DealerHit_index].Width = 70;
                DealerExtra_PB[DealerHit_index].Height = 98;
                DealerExtra_PB[DealerHit_index].SizeMode = PictureBoxSizeMode.StretchImage;
                DealerExtra_PB[DealerHit_index].Location = new Point(235 + Dealer_NewCardDistance, 48);
                this.Controls.Add(DealerExtra_PB[DealerHit_index]);   // Puts the Picture box in the form
                DealerExtra_PB[DealerHit_index].BringToFront();   // Puts the new card in the foreground

                DealerCard_Hit[DealerHit_index] = DealCard();     // Deals a card

                DisplayCard(DealerCard_Hit[DealerHit_index], DealerExtra_PB[DealerHit_index]);  // Displays the image of the new card

                DealerTotal += DealerCard_Hit[DealerHit_index].value;     // Adds the value of the card to the user's total            

                Dealer_CheckBust();                

                DealerHit_index++;                  // Increments the counter by one
                Dealer_NewCardDistance += 42;       // Sets the distance for the next card
            }

            if (PlayerTotal > DealerTotal)
            {
                connection.Open();          // Opens the connection with the database

                // Creates the command to check the user's balance
                // Uses loggedin_username in place of the placeholder
                SqlCommand CheckBalance = new SqlCommand(query_balance, connection);
                CheckBalance.Parameters.AddWithValue("@UsernamePlaceholder", loggedin_username);

                object balance = CheckBalance.ExecuteScalar();  // Stores the retrieved balance
                user_balance = Convert.ToInt32(balance);   // Stores it into a variable of type integer

                final_balance = user_balance + UserBet; // Calculates the balance by deducting the user's bet from their current balance

                // Creates the command to update the user's balance
                // Uses loggedin_username in place of the placeholder
                // Uses final_balance in place of the placeholder
                SqlCommand UpdateBalance = new SqlCommand(query_UpdateBalance, connection);
                UpdateBalance.Parameters.AddWithValue("@UsernamePlaceholder", loggedin_username);
                UpdateBalance.Parameters.AddWithValue("@BalancePlaceholder", final_balance);

                UpdateBalance.ExecuteNonQuery();    // Executes the SQL query

                connection.Close();

                // Message pop ups telling the user they have won, theirs and Dealer's points and money they won and remaining balance
                MessageBox.Show("Well done, you have won");
                MessageBox.Show("You had " + PlayerTotal + " points, and the Dealer had " + DealerTotal + " points");
                MessageBox.Show("You have won " + UserBet + " money and now have " + final_balance + " remaining");

                // Allows the user to click the Start button again
                StartClicked = false;

                Menu menu = new Menu(loggedin_username);    // Opens the Menu form
                menu.Show();
                this.Close();
            }
            if (PlayerTotal < DealerTotal && DealerBust == false)
            {                
                connection.Open();          // Opens the connection with the database

                SqlCommand CheckBalance = new SqlCommand(query_balance, connection);    // Creates the command to check the user's balance
                CheckBalance.Parameters.AddWithValue("@UsernamePlaceholder", loggedin_username);    // Uses loggedin_username in place of the placeholder
                object balance = CheckBalance.ExecuteScalar();  // Stores the retrieved balance
                user_balance = Convert.ToInt32(balance);   // Stores it into a variable of type integer

                final_balance = user_balance - UserBet; // Calculates the balance by deducting the user's bet from their current balance

                SqlCommand UpdateBalance = new SqlCommand(query_UpdateBalance, connection); // Creates the command to update the user's balance
                UpdateBalance.Parameters.AddWithValue("@UsernamePlaceholder", loggedin_username);   // Uses loggedin_username in place of the placeholder 
                UpdateBalance.Parameters.AddWithValue("@BalancePlaceholder", final_balance);    // Uses final_balance in place of the placeholder

                UpdateBalance.ExecuteNonQuery();    // Executes the SQL query

                connection.Close();

                // Message pop ups telling the user they have lost, theirs and the Dealer's points, money they won and remaining balance
                MessageBox.Show("Unfortunately, you have lost");
                MessageBox.Show("You had " + PlayerTotal + " points, and the Dealer had " + DealerTotal + " points");
                MessageBox.Show("You have lost " + UserBet + " money and now have " + final_balance + " remaining");

                // Allows the user to click the Start button again
                StartClicked = false;

                Menu menu = new Menu(loggedin_username);    // Opens the Menu form
                menu.Show();
                this.Close();
            }
            if (PlayerTotal == DealerTotal)
            {
                // Message pop ups telling the user that this round is a draw, number of points they had and that their money has been returned
                MessageBox.Show("This round is a draw. You and the Dealer both have " + PlayerTotal + " points");
                MessageBox.Show("Your money has been returned to you");

                // Allows the user to click the Start button again
                StartClicked = false;   

                Menu menu = new Menu(loggedin_username);    // Opens the Menu form
                menu.Show();
                this.Close();
            }
        }
    }
}

using Blackjack_New.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_New
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
            BackgroundImage = Properties.Resources.Gambling_background; // Sets the background image

            btn_Login.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Login.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Login.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Login.BackColor = Color.Red;    // sets background colour of button as red
            btn_Login.Font = new Font("Bahnschrift SemiBold", 16);  // Sets the font and size of text
            // Sets the colour of the button when mouse is hovering over it and when clicked
            btn_Login.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Login.FlatAppearance.MouseDownBackColor = Color.DarkRed;

            btn_Register.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Register.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Register.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Register.BackColor = Color.Red;    // sets background colour of button as red
            btn_Register.Font = new Font("Bahnschrift SemiBold", 16);   // Sets the font and size of text
            btn_Register.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Register.FlatAppearance.MouseDownBackColor = Color.DarkRed;

            btn_Exit.FlatStyle = FlatStyle.Flat;   // Sets the style of the button as flat
            btn_Exit.FlatAppearance.BorderSize = 3;    // Sets size of border
            btn_Exit.FlatAppearance.BorderColor = Color.Gold;  // sets colour of border as gold
            btn_Exit.BackColor = Color.Red;    // sets background colour of button as red
            btn_Exit.Font = new Font("Bahnschrift SemiBold", 16);   // Sets the font and size of text
            btn_Exit.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
            btn_Exit.FlatAppearance.MouseDownBackColor = Color.DarkRed;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login login = new Login();  // Creates an instance of Login
            login.Show();               // Opens the Login page
            this.Hide();                // Hides the startup page
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Register register = new Register();     // Creates an instance of Register
            register.Show();                        // Opens the Register page
            this.Hide();                            // Hides the startup page
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();       // Closes the game
        }
    }
}

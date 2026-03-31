# Blackjack – Windows Forms C#

A 2D educational Blackjack game built with C# and Windows Forms as part of an A-Level Computer Science NEA. The aim is to let players experience the highs and lows of gambling using in-game currency, without risking real money.

---

## Features

- **Login & Register system** – Accounts stored securely in a SQL Server database with BCrypt password hashing
- **Persistent balance** – Your currency is saved after every round and retrieved on login
- **Blackjack gameplay** – Hit and Stand buttons, dealer AI that draws until 17 points, bust detection, and Ace value adjustment
- **Card shuffling** – Full 52-card deck shuffled each round using a randomised index list
- **Bet validation** – Players cannot bet more than their current balance
- **Themed UI** – Red and gold colour scheme with a gambling-themed background

---

## Requirements

- Windows OS
- Visual Studio (to run the project)
- SQL Server Express (LocalDB) – for the user database
- .NET Framework (included with Visual Studio)

---

## Setup

1. Clone or download the repository
2. Open `Blackjack New.sln` in Visual Studio
3. Ensure SQL Server LocalDB is installed and running
4. Update the connection string in the source files to match your local database path if needed
5. Build and run the project

---

## Limitations

- Single-player only (vs dealer)
- Double Down and Surrender buttons not yet implemented
- Occasional null card error on Start (known intermittent glitch)
- No logout button on the Menu screen

---

## Future Development

- Add Double Down and Surrender buttons
- Implement a logout button
- Reset balance to 100 when it reaches 0
- Track number of times a player has gone broke

---

## License

This project is licensed under [CC BY-NC-SA 4.0](https://creativecommons.org/licenses/by-nc-sa/4.0/) – free to use for non-commercial purposes with attribution.

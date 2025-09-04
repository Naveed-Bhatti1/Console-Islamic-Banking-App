
# 🏦 Console Islamic Banking App

[![C#](https://img.shields.io/badge/Language-C%23-blue?style=flat-square)](https://docs.microsoft.com/en-us/dotnet/csharp/) 
[![.NET](https://img.shields.io/badge/.NET-7.0-brightgreen?style=flat-square)](https://dotnet.microsoft.com/en-us/)

A **console-based banking app** built in C# and .NET, simulating an **Islamic banking system**. Users can register, create accounts, deposit/withdraw money, and view transaction history—all without interest, following **Sharia-compliant principles**.  

---

## 🚀 Features

- ✅ **User Authentication** – Secure register and login system  
- ✅ **Multiple Account Management** – Savings, Current, Investment  
- ✅ **Balance Inquiry** – Check your account balances anytime  
- ✅ **Transactions** – Deposit, withdraw, and track your money  
- ✅ **Transaction History** – View detailed history for each account  
- ✅ **Islamic Banking Compliance** – No interest (riba), can be extended with profit-sharing  

---

## 💡 How It Works

1. **Start the App**: Run the `Program.cs` file in your IDE.  
2. **Register/Login**: Create a new account or login with existing credentials.  
3. **Account Menu**:  
   - Create new accounts  
   - View account balances  
   - Deposit money  
   - Withdraw money  
   - View transaction history  
4. **Data Storage**: Currently stored in memory. Can be extended with **JSON files** or a **database** for persistence.  

---

## 📁 Project Structure

```

ConsoleBankingApp/
│
├── Program.cs          # Entry point, main menu
├── User.cs             # Stores username, password, accounts
├── Account.cs          # Stores account type, balance, transactions
├── Transaction.cs      # Records deposits, withdrawals, transfers
├── Auth.cs             # Handles registration & login
├── AccountMenu.cs      # Menu after login
└── AccountOperations.cs# Implements all account actions

````

---

## 🎯 Future Improvements

- Persist data using **JSON or a database**  
- Add **profit-sharing** for Islamic banking compliance  
- Enable **transfer between accounts**  
- Add **input validation & error handling**  
- Build a **GUI version** using Windows Forms or WPF  

---

## 💻 How to Run

1. Clone the repository:

```bash
git clone https://github.com/Naveed-Bhatti1/Console-Islamic-Banking-App.git
````

2. Open in **Visual Studio** or your preferred C# IDE.
3. Build & run the project.
4. Interact using the console menu.

---

## 👨‍💻 Author

**Naveed Bhatti** – Aspiring C# & .NET Developer

---

## 📜 License

This project is licensed under the **MIT License**.



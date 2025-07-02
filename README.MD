# MohalemBank

A console-based banking system application built with C# and .NET 9.0.

## Overview

MohalemBank is a simple banking management system that provides a command-line interface for managing customers and
accounts. The application features a login system and menu-driven navigation for various banking operations.

## Features

- **Authentication System**: Secure login with username and password validation
- **Main Menu Navigation**: Easy-to-use menu system with the following options:
    - Customer Management
    - Account Management
    - Fund Transfer (planned)
    - Fund Transfer Statements (planned)
    - Account Statements (planned)

### Current Functionality

- ✅ User authentication and login
- ✅ Customer management menu (structure ready)
- ✅ Account management menu (structure ready)
- ⏳ Fund transfer operations (planned)
- ⏳ Statement generation (planned)

## Requirements

- .NET 9.0 Runtime
- Console/Terminal environment

## Installation

1. Clone or download the project
2. Navigate to the project directory
3. Build the project:
   ```bash
   dotnet build
   ```

## Usage

1. Run the application:
   ```bash
   dotnet run
   ```

2. Log in using the credentials:
    - Username: `admin`
    - Password: `nimda`

3. Navigate through the menu options:
    - **Option 1**: Customer Management
        - Add, delete, update, or view customers
    - **Option 2**: Account Management
        - Add, delete, update, or view accounts
    - **Option 3-5**: Fund operations (coming soon)
    - **Option 0**: Exit the application

## Project Structure

MohalemBank/ 
├── Program.cs # Main application logic 
├── MohalemBank.csproj # Project configuration 
├── MohalemBank.sln # Solution file 
└── README.md # This file

## Development Status

This project is currently in early development. The basic menu structure and authentication are implemented, but most
banking operations are placeholders awaiting implementation.

### Planned Features

- Complete customer management (CRUD operations)
- Complete account management (CRUD operations)
- Fund transfer functionality
- Transaction history and statements
- Data persistence
- Enhanced security features

## Technical Details

- **Language**: C# 13.0
- **Framework**: .NET 9.0
- **Application Type**: Console Application
- **Features Used**: Implicit usings, nullable reference types

## Contributing

This appears to be a learning/demonstration project. If you'd like to contribute:

1. Fork the repository
2. Create a feature branch
3. Implement the planned functionality
4. Submit a pull request

## Security Note

⚠️ **Important**: This application currently uses hardcoded credentials for demonstration purposes. In a production
environment, implement proper authentication mechanisms and secure credential storage.

## License

Please refer to the project maintainer for licensing information.
# License Plate Recognition — Desktop App

Windows desktop application for Vietnamese license plate recognition built with **C# .NET** and **SQL Server** database integration.

## Features
- Real-time license plate detection from camera or image
- SQL Server database for storing recognized plates
- Windows Forms UI
- Integration with AI recognition backend

## Requirements
- Visual Studio 2019 or later
- .NET Framework 4.7+
- SQL Server 2016+

## Setup

### 1. Clone
```bash
git clone https://github.com/doanhtuan123/DoAn_NhanDienBienSo.git
cd DoAn_NhanDienBienSo
```

### 2. Database setup
- Open SQL Server Management Studio
- Run the script: `dbo.Table.sql`
- Update connection string in `App.config`

### 3. Open solution
```
Open doantest.sln in Visual Studio
```

### 4. Build and run
- Press **F5** or **Ctrl+F5** to build and run

## Project Structure
```
DoAn_NhanDienBienSo/
├── doantest.sln           # Visual Studio solution
├── doantest/              # Main project
├── dbo.Table.sql          # Database schema
└── .editorconfig
```

## Tech Stack
- C# / .NET Framework
- Windows Forms
- SQL Server
- OpenCV (via EmguCV)

## License
MIT
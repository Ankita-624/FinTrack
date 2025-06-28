# 📘 FinTrack API

> A secure, production-ready personal finance backend API built with **ASP.NET Core 8**, featuring **JWT authentication**, **SQL Server integration**, and **Swagger UI** for testing. Track your income and expenses, securely manage users, and demonstrate backend excellence.

---

## 🚀 Features

- 🔐 **JWT Authentication** (Login & Register)
- 📊 **Create, View Transactions** (Income / Expense)
- 📂 **Role-based Authorization**
- 🧩 **EF Core with SQL Server Express**
- 📄 **Swagger UI** for seamless testing
- 🛡️ **Secure password hashing**
- ⚙️ **Clean architecture with separation of concerns**

---

## 🛠 Tech Stack

| Layer        | Technology                        |
|--------------|-----------------------------------|
| Backend API  | ASP.NET Core 8                    |
| Auth         | ASP.NET Core Identity + JWT       |
| ORM          | Entity Framework Core             |
| Database     | SQL Server Express                |
| Docs & Test  | Swagger              |

---

## 📦 Installation

### 1️⃣ Clone the repository

```
git clone https://github.com/Ankita-624/FinTrack.git
cd FinTrack
```

### 2️⃣ Add your connection string
```
In appsettings.json (locally):

{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=FinTrackDb;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true"
  },
  "Jwt": {
    "Key": "thisisaverysecurekey1234567890",
    "Issuer": "FinTrack",
    "Audience": "FinTrackUsers"
  }
}
```

### 3️⃣ Run migrations and start server
```
dotnet restore
dotnet ef database update
dotnet run
```

## 🧪 API Testing with Swagger
```
http://localhost:<your-port>/swagger
```

### Endpoints:
🔑 Auth
```
POST /api/Auth/register

POST /api/Auth/login
```
💰 Transactions
```
GET /api/Transactions

POST /api/Transactions
```

### 🔐 Sample JWT Workflow

- Register via /api/Auth/register

- Login via /api/Auth/login → copy token

- Click Authorize in Swagger and paste:
```
Bearer your_token_here
```
Use protected routes like /api/Transactions


### 📸 Screenshots


### 👤 Author
Ankita Gouda




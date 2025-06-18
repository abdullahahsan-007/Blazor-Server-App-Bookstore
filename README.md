# 📘 BlazorProject

This is a **Blazor Server** application connected to **SQL Server LocalDB** using `project.mdf`. The project includes login, signup, book management, and order management features.

---

## 🚀 Features

- 🔐 User Authentication (Sign In / Sign Up)
- 🧑 Admin and User separation (via layouts or logic)
- 📚 Book management (stored in `dbo.Books`)
- 🛒 Order processing (`dbo.Orders`)
- 🧑‍🤝‍🧑 User table (`dbo.Users`)
- 🎯 Blazor Server-side components and routing
- 🗃️ SQL Server LocalDB (`project.mdf`)

---

## 🔧 Setup Instructions

1. **Clone or download the repository**
2. **Ensure the `project` database is attached**:
   - Open **SQL Server Object Explorer** in Visual Studio
   - Under `(localdb)\MSSQLLocalDB`, make sure the `project` database appears with the tables (`Books`, `Orders`, `Users`)
3. **Set up the connection string** in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True"
   }

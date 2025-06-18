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


---

## 🔧 Setup Instructions

1. **Clone or download the repository**
2. **Ensure `project.mdf` is attached:**
   - View it in **SQL Server Object Explorer** (already set up).
3. **Set up the connection string** in `appsettings.json`:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\project.mdf;Integrated Security=True"
   }



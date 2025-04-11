# 🚚 DeliveryApplication

A simple demo app simulating a food delivery system with:

- **Backend**: ASP.NET Core Web API  
- **Frontend**: React + Yarn  
- Delivery agents (starting from the center of a circle)  
- Orders with randomly generated pickup and drop points  
- Each order is assigned to the **closest delivery agent**  
- Agent movement simulated and displayed in a **table format**

---

## 📦 Requirements

- [.NET 6 SDK or later](https://dotnet.microsoft.com/download)
- [Node.js & Yarn](https://yarnpkg.com/getting-started/install)

---

## ▶️ Run the Backend

```bash
cd Backend
dotnet run
```

By default, the backend runs at:

👉 **https://localhost:7022**

> ⚠️ Make sure your browser allows HTTPS requests to `localhost:7022`. You may need to trust the dev certificate.

---

## 💻 Frontend (React + Yarn)

```bash
cd frontend
yarn install
yarn start
```

This will start the frontend at:

👉 **http://localhost:3000**

Make sure the backend is running and accessible for the frontend to work properly.

---

## 🔁 Available API Endpoints

| Method | Endpoint               | Description                                 |
|--------|------------------------|---------------------------------------------|
| POST   | `/api/order/generate` | Generates a new delivery order              |
| GET    | `/api/order/orders`   | Retrieves the list of all generated orders  |
| POST   | `/api/agent/move`     | Moves agents toward their assigned orders   |
| GET    | `/api/agent/agents`   | Retrieves the current status of agents      |

---

## 📝 Notes

- Each new order is assigned every second (on button click for simplicity).
- Agents always move toward the **pickup point first**, then to the **drop point**.
- Distance is Euclidean, and speed is uniform.
- No persistent storage — data is stored in memory.

---

## 📷 UI Preview

Simple frontend with:

- Buttons for triggering actions (`Generate Order`, `Move Agents`, etc.)
- Tables showing:
  - Order ID, From → To points
  - Agent ID, Current Position, Target (if any), Status

---

## 🛠️ Future Improvements (Optional Ideas)

- Visual map with real-time agent movement
- Authentication and login
- Delivery status timeline per order
- Agent profile management

---

## 👨‍💻 Author

Anku Kumar Choudhary

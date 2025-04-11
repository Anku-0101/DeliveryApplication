# DeliveryApplication

- Backend: ASP.NET Core API
- Frontend: React + Yarn
- Simulates delivery orders (pickup and drop points)
- Pool of delivery agents (initially at center)
- Closest agent assigned to each order
- Display of agents and orders in table format

Requirements

- [.NET 6 SDK or later](https://dotnet.microsoft.com/download)

Run the Backend

```bash
cd Backend
dotnet run

By default, the backend runs on:
https://localhost:7022


## Frontend (React + Yarn)
cd frontend
yarn install
yarn start


Available API Endpoints
POST /api/order/generate → Generates a new order
GET /api/order/orders → Get list of orders
POST /api/agent/move → Move all agents toward their targets
GET /api/agent/agents → Get current status of all delivery agents


import React, { useState } from 'react';
//import { generateOrder, moveAgents, getAgents, getOrders } from './api';
import { generateOrder,  moveAgents, getAgents, getOrders} from './api';
import OrdersTable from './components/OrdersTable';
import AgentsTable from './components/AgentsTable';

function App() {
  const [orders, setOrders] = useState([]);
  const [agents, setAgents] = useState([]);

  const handleGenerateOrder = async () => {
    await generateOrder();
    refresh();
  };

  const handleMoveAgents = async () => {
    await moveAgents();
    refresh();
  };

  const refresh = async () => {
    const [ordersRes, agentsRes] = await Promise.all([
      getOrders(),
      getAgents()
    ]);
    setOrders(ordersRes.data);
    setAgents(agentsRes.data);
  };

  return (
    <div style={{ padding: '20px' }}>
      <h1>🚴 Food Delivery Locator</h1>

      <div style={{ marginBottom: '20px' }}>
        <button onClick={handleGenerateOrder}>Generate Order</button>{' '}
        <button onClick={handleMoveAgents}>Move Agents</button>{' '}
        <button onClick={refresh}>Refresh</button>
      </div>

      <OrdersTable orders={orders} />
      <AgentsTable agents={agents} />
    </div>
  );
}

export default App;

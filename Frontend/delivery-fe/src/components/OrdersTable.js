import React from 'react';

const OrdersTable = ({ orders }) => (
  <div>
    <h2>📦 Orders</h2>
    <table border="1" cellPadding="8">
      <thead>
        <tr>
          <th>ID</th>
          <th>From (x, y)</th>
          <th>To (x, y)</th>
          <th>Assigned Agent ID</th>
        </tr>
      </thead>
      <tbody>
        {orders.map((order, idx) => (
          <tr key={idx}>
            <td>{idx + 1}</td>
            <td>({order.fromX.toFixed(2)}, {order.fromY.toFixed(2)})</td>
            <td>({order.toX.toFixed(2)}, {order.toY.toFixed(2)})</td>
            <td>{order.assignedAgentId ?? '-'}</td>
          </tr>
        ))}
      </tbody>
    </table>
  </div>
);

export default OrdersTable;

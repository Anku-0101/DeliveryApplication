import React from 'react';

const AgentsTable = ({ agents }) => (
  <div style={{ marginTop: '30px' }}>
    <h2>👷 Delivery Agents</h2>
    <table border="1" cellPadding="8">
      <thead>
        <tr>
          <th>ID</th>
          <th>Position (x, y)</th>
          <th>Busy</th>
        </tr>
      </thead>
      <tbody>
        {agents.map(agent => (
          <tr key={agent.id}>
            <td>{agent.id}</td>
            <td>({agent.x.toFixed(2)}, {agent.y.toFixed(2)})</td>
            <td>{agent.busy ? '✅' : '❌'}</td>
          </tr>
        ))}
      </tbody>
    </table>
  </div>
);

export default AgentsTable;

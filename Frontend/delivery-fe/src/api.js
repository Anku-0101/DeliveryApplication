import axios from 'axios';

const API = 'https://localhost:7022/api';

export const generateOrder = () => axios.post(`${API}/order/generate`);
export const moveAgents = () => axios.post(`${API}/agent/move`);
export const getOrders = () => axios.get(`${API}/order/orders`);
export const getAgents = () => axios.get(`${API}/agent/agents`);

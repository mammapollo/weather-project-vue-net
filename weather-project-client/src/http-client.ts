import axios, { AxiosInstance } from "axios";

const apiClient: AxiosInstance = axios.create({
  baseURL: import.meta.env.VITE_BACKENDENDPOINT,
  headers: {
    "Content-type": "application/json",
  },
});

export default apiClient;
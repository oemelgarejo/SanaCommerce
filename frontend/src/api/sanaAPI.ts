import axios from "axios";
const apiUrl = import.meta.env.VITE_API_URL;
export const SanaAPI = axios.create({
  baseURL: apiUrl,
});

import axios, { AxiosInstance } from "axios";
const httpClient: AxiosInstance = axios.create({
    baseURL: "http://localhost:5000/api/",
    headers: {
        "Content-type": "application/json",
        "Access-Control-Allow-Methods": "GET, POST, OPTIONS, PUT, DELETE"
    },
});
export default httpClient;
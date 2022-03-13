import axios, { AxiosInstance } from "axios";
const httpClient: AxiosInstance = axios.create({
    baseURL: "http://localhost:5000/api/",
    headers: {
        "Content-type": "application/json",
    },
});
export default httpClient;
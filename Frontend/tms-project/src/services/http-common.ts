import axios from "axios";

export const httpCommon = axios.create({
  baseURL: "https://localhost:44386/",
  headers: {
    "Content-type": "application/json",
  },
});

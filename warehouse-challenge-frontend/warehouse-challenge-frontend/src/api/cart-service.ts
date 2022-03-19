import http from "./http-client";
import type CartItemModel from "@/types/CartItemModel"

class CartService {
    serviceUrl = "cart";

    async getAll(): Promise<CartItemModel[]> {
        let response = await http.get<CartItemModel[]>(`${this.serviceUrl}/all`);
        return response.data;
    }
}

export default new CartService()
import http from "./http-client";
import type CartItemModel from "@/types/CartItemModel"

class CartService {
    serviceUrl = "cart";

    async getAll(): Promise<CartItemModel[]> {
        let response = await http.get<CartItemModel[]>(`${this.serviceUrl}/all`);
        return response.data;
    }

    async add(cartItemId: number) {
        await http.post(`${this.serviceUrl}/${cartItemId}`);
    }
}

export default new CartService()
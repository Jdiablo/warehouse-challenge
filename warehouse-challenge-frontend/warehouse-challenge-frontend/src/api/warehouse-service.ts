import http from "./http-client";
import type Warehouse from "@/types/WarehouseModel"

class WarehouseService {
    serviceUrl = "warehouse";

    async getAll(): Promise<Warehouse[]> {
        let response = await http.get<Warehouse[]>(`${this.serviceUrl}/all`);
        return response.data;
    }
}

export default new WarehouseService()
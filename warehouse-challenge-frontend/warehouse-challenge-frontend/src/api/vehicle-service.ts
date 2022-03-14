import http from "./http-client";
import type VehicleFullModel from "@/types/VehicleFullModel"

class VehicleService {
    serviceUrl = "vehicle";

    async get(id: number): Promise<VehicleFullModel> {
        let response = await http.get<VehicleFullModel>(`${this.serviceUrl}/${id}`);
        return response.data;
    }
}

export default new VehicleService()
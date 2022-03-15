import type VehicleFullModel from "@/types/VehicleFullModel"
import type CartState from "./cart-state"

export default {
    namespaced: true,
    state: {
        cartItems: [] as VehicleFullModel[]
    },
    mutations: {
        add(state: CartState, newItem: VehicleFullModel) {
            if (!state.cartItems.findIndex(x => x.id == newItem.id)) {
                state.cartItems.push(newItem);
            }
        }
    }
}
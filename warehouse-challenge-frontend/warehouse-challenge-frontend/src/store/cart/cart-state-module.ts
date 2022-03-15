import type VehicleFullModel from "@/types/VehicleFullModel"
import type CartState from "./cart-state"

export default {
    namespaced: true,
    state: {
        cartItems: [] as VehicleFullModel[]
    },
    mutations: {
        addCartItem(state: CartState, newItem: VehicleFullModel) {
            let res = [...state.cartItems];
            if (res.findIndex(x => x.id == newItem.id) == -1) {
                res.push(newItem);
            }
            state.cartItems = [...res];
        },
        removeCartItem(state: CartState, id: number) {
            let idx = state.cartItems.findIndex(x => x.id == id);
            if (idx == -1) {
                return;
            }
            state.cartItems.splice(idx, 1);
        },
    }
}
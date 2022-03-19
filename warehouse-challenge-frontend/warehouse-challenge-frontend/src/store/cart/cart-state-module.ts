import type VehicleFullModel from "@/types/VehicleFullModel"
import type CartState from "./cart-state"
import CartService from "@/api/cart-service";
import VehicleService from "@/api/vehicle-service";
import type CartItemModel from "@/types/CartItemModel";
import type { Commit } from "vuex";

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
    },
    actions: {
        getCart({ commit }: { commit: Commit }) {
            CartService.getAll()
                .then((cartItems: CartItemModel[]) => {
                    for (let i = 0; i < cartItems.length; ++i) {
                        VehicleService.get(cartItems[i].itemId)
                            .then((vehicle: VehicleFullModel) => {
                                commit("addCartItem", vehicle);
                            });
                    }
                });
        }
    }
}
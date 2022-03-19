import type VehicleFullModel from "@/types/VehicleFullModel"
import type CartState from "./cart-state"
import CartService from "@/api/cart-service";
import VehicleService from "@/api/vehicle-service";
import type CartItemModel from "@/types/CartItemModel";
import type { Commit, Dispatch } from "vuex";

function addCartItemToState(state: CartState, newItem: VehicleFullModel) {
    let res = [...state.cartItems];
    if (res.findIndex(x => x.id == newItem.id) == -1) {
        res.push(newItem);
    } else {
        return;
    }
    state.cartItems = [...res];
}

export default {
    namespaced: true,
    state: {
        cartItems: [] as VehicleFullModel[]
    },
    mutations: {
        addCartItemWOApiCall(state: CartState, newItem: VehicleFullModel) {
            addCartItemToState(state, newItem);
        },
        addCartItem(state: CartState, newItem: VehicleFullModel) {
            addCartItemToState(state, newItem);
            CartService.add(newItem.id);
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
        getCart({ commit }: { commit: Commit }, state: CartState) {
            CartService.getAll()
                .then((cartItems: CartItemModel[]) => {
                    for (let i = 0; i < cartItems.length; ++i) {
                        VehicleService.get(cartItems[i].itemId)
                            .then((vehicle: VehicleFullModel) => {
                                commit("addCartItemWOApiCall", vehicle);
                            });
                    }
                });
        }
    }
}
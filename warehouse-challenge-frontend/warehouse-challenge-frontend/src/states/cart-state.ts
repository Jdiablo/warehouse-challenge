import { InjectionKey } from 'vue'
import { createStore, useStore as baseUseStore, Store } from 'vuex'
import type VehicleShortModel from "@/types/VehicleShortModel"

export interface CartState {
    cartItems: VehicleShortModel[];
}

export const key: InjectionKey<Store<CartState>> = Symbol()

export const store = createStore<CartState>({
    state: {
        cartItems: [] as VehicleShortModel[]
    },
    mutations: {
        add(state, newItem: VehicleShortModel) {
            if (!state.cartItems.findIndex(x => x.id == newItem.id)) {
                state.cartItems.push(newItem);
            }
        }
    }
})

// define your own `useStore` composition function
export function useStore() {
    return baseUseStore(key)
}
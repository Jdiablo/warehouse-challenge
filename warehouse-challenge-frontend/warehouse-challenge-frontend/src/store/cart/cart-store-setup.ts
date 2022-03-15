import { createStore } from 'vuex'
import cartModule from './cart-state-module'
import type CartState from "./cart-state"

export interface State {
    cart: CartState;
}

export default createStore({
    modules: {
        cart: cartModule
    }
})
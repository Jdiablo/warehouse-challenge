<template>
    <h4 v-if="total > 0">Your cart</h4>
    <div v-for="item in cartItems">
        <div class="cart-item">
            <span>
                {{item.make}} {{item.model}}
            </span>
            <div>
                ${{item.price}}
            </div>
        </div>
        <button class="btn btn-danger"  v-on:click="removeItem(item.id)">Remove</button>
        <hr />
    </div>
    <p class="fw-bold" v-if="total > 0">
        Total: ${{total}}
    </p>
</template>

<script lang="ts">
    import { defineComponent } from "vue";
    import type VehicleFullModel from "@/types/VehicleFullModel";

    export default defineComponent({
        data() {
            return {
                
            }
        },
        computed: {
            cartItems(): VehicleFullModel[] {
                if (this.$store.state.cart.cartItems)
                    return this.$store.state.cart.cartItems;

                return [];
            },
            total(): number {
                if (this.cartItems.length == 0)
                    return 0;

                return this.cartItems.map(x => x.price).reduce((a, b) => { return a + b });
            }
        },
        methods: {
            getCart() {
                this.$store.dispatch('cart/getCart');
            },
            removeItem(id: number) {
                this.$store.commit('cart/removeCartItem', id);
            }
        },
        mounted() {
            this.getCart();
        },
    });
</script>

<style scoped>
</style>
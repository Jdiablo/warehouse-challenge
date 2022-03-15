<template>
    <h4>Your cart</h4>
    <div v-for="item in cartItems">
        <div class="cart-item">
            <span>
                {{item.make}} {{item.model}}
            </span>
            <div>
                {{item.price}}
            </div>
        </div>
    </div>
</template>

<script lang="ts">
    import { defineComponent } from "vue";
    import type VehicleFullModel from "@/types/VehicleFullModel";
    import { Store } from 'vuex'

    export default defineComponent({
        data() {
            return {
                
            }
        },
        computed: {
            cartItems(): VehicleFullModel[] {
                return this.$store.state.cartItems;
            }
        },
        mounted() {
            
        }
    });
</script>

<style scoped>
</style>
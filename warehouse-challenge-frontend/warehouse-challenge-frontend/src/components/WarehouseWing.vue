<template>
    <h5>
        {{currentWing.name}}
    </h5>
    <div style="display: grid; grid-template-columns: repeat(2,minmax(0,1fr)); gap: 4rem">
        <div class="card" v-for="item in currentWing.vehicles">
            <div class="card-body">
                <Vehicle :currentVehicle="item" v-bind:isEditEnabled="isEditEnabled"></Vehicle>
            </div>
        </div>
    </div>
</template>

<script lang="ts">
    import { defineComponent } from "vue";
    import Vehicle from "./Vehicle.vue";

    import type WarehouseWingModel from "@/types/WarehouseWingModel";

    export default defineComponent({
        components: {
            Vehicle
        },
        data() {
            return {
                
            }
        },
        props: {
            currentWing: {
                type: Object,
                required: true
            },
            isEditEnabled: Boolean
        }
    });
</script>

<style scoped>
</style>
<template>
    <h4>
        {{currentWing.name}}
    </h4>
    <ul class="list-group">
        <li class="list-group-item"
            v-for="item in currentWing.vehicles">
            <Vehicle :currentVehicle="item" v-bind:isEditEnabled="isEditEnabled"></Vehicle>
        </li>
    </ul>
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
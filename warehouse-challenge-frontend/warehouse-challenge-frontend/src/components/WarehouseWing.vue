<template>
    <h4>
        {{currentWing.name}}
    </h4>
    <ul class="list-group">
        <li class="list-group-item"
            v-for="item in currentWing.vehicles">
            <Vehicle v-bind:currentVehicle="item"></Vehicle>
        </li>
    </ul>
</template>

<script lang="ts">
    import { defineComponent, PropType } from "vue";
    import Vehicle from "./Vehicle.vue"
    import type WarehouseWingModel from "@/types/WarehouseWing";

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
                type: Object as PropType<WarehouseWingModel>,
                required: true
            },
        }
    });
</script>

<style scoped>
</style>
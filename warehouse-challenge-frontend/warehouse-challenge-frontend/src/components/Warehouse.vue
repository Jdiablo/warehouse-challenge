<template>
    <h4>
        {{currentWarehouse.name}}
    </h4>
    <div class="mb-3 row">
        <label class="col-2">Lat</label>
        <input class="col-4" type="text" v-model="currentWarehouse.locationLat" :disabled="isEditEnabled == false" />
        <label class="col-2">Lon</label>
        <input class="col-4" type="text" v-model="currentWarehouse.locationLong" :disabled="isEditEnabled == false" />
    </div>
    <div>
        <WarehouseWing :currentWing="currentWarehouse.warehouseWing" v-bind:isEditEnabled="isEditEnabled"></WarehouseWing>
    </div>
</template>

<script lang="ts">
    import { defineComponent } from "vue";
    import WarehouseWing from "./warehouse-wing.vue";
    import type WarehouseModel from "@/types/WarehouseModel";

    export default defineComponent({
        components: {
            WarehouseWing
        },
        props: {
            currentWarehouse: {
                type: Object,
                required: true
            },
            isEditEnabled: Boolean
        }
    });
</script>

<style scoped>
</style>
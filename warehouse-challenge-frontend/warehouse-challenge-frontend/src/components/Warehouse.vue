<template>
    <div class="mb-3 row">
        <label class="col-2">Name</label>
        <input class="col-10 form-control" type="text" v-model="currentWarehouse.name" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label class="col-2">Lat</label>
        <input class="col-4 form-control" type="text" v-model="currentWarehouse.locationLat" :disabled="isEditEnabled == false" />
        <label class="col-2">Lon</label>
        <input class="col-4 form-control" type="text" v-model="currentWarehouse.locationLong" :disabled="isEditEnabled == false" />
    </div>
    <div>
        <WarehouseWing v-bind:currentWing="currentWarehouse.warehouseWing"></WarehouseWing>
    </div>
</template>

<script lang="ts">
    import { defineComponent, PropType } from "vue"
    import WarehouseWing from "./WarehouseWing.vue"
    import type WarehouseModel from "@/types/Warehouse"

    export default defineComponent({
        components: {
            WarehouseWing
        },
        props: {
            currentWarehouse: {
                type: Object as PropType<WarehouseModel>,
                required: true
            },
            isEditEnabled: Boolean
        }
    });
</script>

<style scoped>
</style>
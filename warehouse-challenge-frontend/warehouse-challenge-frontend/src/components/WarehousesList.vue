<template>
    <div v-for="curWarehouse in warehousesList">
        <div>
            <Warehouse :currentWarehouse="curWarehouse" v-bind:isEditEnabled="false"></Warehouse>
            <hr />
        </div>
    </div>
</template>

<script lang="ts">
    import { defineComponent } from "vue";
    import Warehouse from "./Warehouse.vue";
    import WarehouseService from "@/api/warehouse-service";

    import type WarehouseModel from "@/types/WarehouseModel";

    export default defineComponent({
        name: "warehouses-list",
        components: {
            Warehouse
        },
        data() {
            return {
                warehousesList: [] as WarehouseModel[]
            }
        },
        methods: {
            getAllWarehouses() {
                WarehouseService.getAll()
                    .then((warehouses: WarehouseModel[]) => {
                        this.warehousesList = warehouses;
                    });
            }
        },
        mounted() {
            this.getAllWarehouses();
        },
    });
</script>

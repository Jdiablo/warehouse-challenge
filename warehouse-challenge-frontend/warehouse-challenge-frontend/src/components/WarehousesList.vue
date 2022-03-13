<template>
    <div class="card" v-for="item in warehousesList">
        <div class="card-body">

        </div>
    </div>
</template>

<script lang="ts">
    import { defineComponent } from "vue"
    import WarehouseService from "@/api/warehouse-service"
    import type WarehouseModel from "@/types/Warehouse"

    export default defineComponent({
        name: "warehouses-list",
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

<template>
</template>

<script lang="ts">
    import { defineComponent } from "vue";
    import WarehouseService from "@/api/warehouse-service"
    import type Warehouse from "@/types/Warehouse"

    export default defineComponent({
        name: "warehouses-list",
        data() {
            return {
                warehousesList: [] as Warehouse[]
            }
        },
        methods: {
            getAllWarehouses() {
                WarehouseService.getAll()
                    .then((warehouses: Warehouse[]) => {
                        this.warehousesList = warehouses;
                    });
            }
        }
    });
</script>

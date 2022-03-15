<template>
    <div v-if="warehousesList.length > 0" class="row">
        <div class="col-8">
            <div class="warehouse-container" v-for="curWarehouse in warehousesList">
                <Warehouse :currentWarehouse="curWarehouse" v-bind:isEditEnabled="false"></Warehouse>
                <hr />
            </div>
        </div>
        <div class="col-4">
            <CartContainer></CartContainer>
        </div>
    </div>
    <div v-else>
        Loading...
    </div>
</template>

<script lang="ts">
    import { defineComponent } from "vue";
    import Warehouse from "./warehouse.vue";
    import CartContainer from "@/components/cart/cart-container.vue";
    import WarehouseService from "@/api/warehouse-service";

    import type WarehouseModel from "@/types/WarehouseModel";

    export default defineComponent({
        name: "warehouses-list",
        components: {
            Warehouse,
            CartContainer
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

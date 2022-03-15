<template>
    <div class="mb-3 row">
        <label class="col-3">Make</label>
        <input class="col-9" type="text" v-model="currentVehicle.make" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label class="col-3">Model</label>
        <input class="col-9" type="text" v-model="currentVehicle.model" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label class="col-3">Licensed</label>
        <input class="col-1" type="checkbox" v-model="currentVehicle.licensed" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label class="col-3">Year model</label>
        <input class="col-9" type="number" v-model="currentVehicle.yearModel" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label class="col-3">Price</label>
        <input class="col-9" type="number" v-model="currentVehicle.price" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label class="col-3">Warehouse</label>
        <input class="col-9" type="text" v-model="currentVehicle.warehouseName" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label class="col-3">Location</label>
        <input class="col-9" type="text" v-model="currentVehicle.locationName" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label class="col-3">Lat</label>
        <input class="col-3" type="text" v-model="currentVehicle.locationLat" :disabled="isEditEnabled == false" />
        <label class="col-3">Lon</label>
        <input class="col-3" type="text" v-model="currentVehicle.locationLong" :disabled="isEditEnabled == false" />
    </div>
    <div class="row">
        <label class="col-3">Date added</label>
        <input class="col-9" type="text" v-model="currentVehicle.dateAdded" disabled />
    </div>
</template>

<script lang="ts">
    import { defineComponent } from "vue";
    import VehicleService from "@/api/vehicle-service";
    import type VehicleFullModel from "@/types/VehicleFullModel";

    export default defineComponent({
        data() {
            return {
                isEditEnabled: false,
                currentVehicle: {} as VehicleFullModel
            }
        },
        methods: {
            getVehicle(id: number) {
                VehicleService.get(id)
                    .then((vehicle: VehicleFullModel) => {
                        this.currentVehicle = vehicle;
                    })
                    .catch(() => {
                        this.$toast('Server returned some error', {
                            type: 'error',
                        });
                    });
            }
        },
        mounted() {
            this.getVehicle(parseInt(this.$route.params.id.toString()));
        },
    });
</script>

<style scoped>
</style>
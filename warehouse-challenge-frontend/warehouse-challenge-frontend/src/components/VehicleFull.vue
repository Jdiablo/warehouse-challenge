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
    <div class="row">
        <label class="col-3">Date added</label>
        <input class="col-9" type="text" v-model="currentVehicle.dateAdded" disabled />
    </div>
</template>

<script lang="ts">
    import { defineComponent } from "vue";
    import type VehicleFullModel from "@/types/VehicleFullModel";

    export default defineComponent({
        props: {
            currentVehicle: {
                type: Object,
                required: true
            },
            isEditEnabled: Boolean
        }
    });
</script>

<style scoped>
</style>
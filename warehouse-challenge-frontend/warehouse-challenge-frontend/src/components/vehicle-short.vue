<template>
    <div class="mb-3 row">
        <label class="col-3">Make</label>
        <input class="col-9" type="text" v-model="currentVehicle.make" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label class="col-3">Model</label>
        <input class="col-9" type="text" v-model="currentVehicle.model" :disabled="isEditEnabled == false" />
    </div>
    <div class="row">
        <label class="col-3">Date added</label>
        <input class="col-9" type="text" v-model="currentVehicle.dateAdded" disabled />
    </div>
    <router-link v-if="currentVehicle.licensed" :to="'/vehicle/' + currentVehicle.id"
                 class="badge bg-primary">Details</router-link>
</template>

<script lang="ts">
    import { defineComponent } from "vue";
    import type VehicleShortModel from "@/types/VehicleShortModel";

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
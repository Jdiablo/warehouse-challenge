<template>
    <div class="mb-3 row">
        <label>Make</label>
        <input type="text" class="form-control" v-model="currentVehicle.make" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label>Model</label>
        <input type="text" class="form-control" v-model="currentVehicle.model" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label>Licensed</label>
        <input type="checkbox" class="form-control" v-model="currentVehicle.licensed" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label>Year model</label>
        <input type="number" class="form-control" v-model="currentVehicle.yearModel" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label>Price</label>
        <input type="number" class="form-control" v-model="currentVehicle.price" :disabled="isEditEnabled == false" />
    </div>
    <div class="mb-3 row">
        <label>Date added</label>
        <input type="number" class="form-control" v-model="currentVehicle.dateAdded" disabled />
    </div>
</template>

<script lang="ts">
    import { defineComponent, PropType } from "vue";
    import type Vehicle from "../types/Vehicle";

    export default defineComponent({
        data() {
            return {
                
            }
        },
        props: {
            currentVehicle: {
                type: Object as PropType<Vehicle>,
                required: true
            },
            isEditEnabled: Boolean
        }
    });
</script>

<style scoped>
</style>
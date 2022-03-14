import { mount } from '@vue/test-utils'
import { assert, expect, test } from 'vitest'
import type VehicleShortModel from "@/types/VehicleShortModel"
import VehicleShort from "@/components/VehicleShort.vue"
import router from "@/router"

test('renders a vehicle short card info', async () => {
    let vehicleData = {} as VehicleShortModel;

    const wrapper = mount(VehicleShort, {
        props: {
            currentVehicle: vehicleData
        },
        global: {
            plugins: [router]
        }
    });

    expect(wrapper.html()).toContain('Model');
});

test('non licensed car doesnt have Details button', async () => {
    let vehicleData = { licensed: false } as VehicleShortModel;

    const wrapper = mount(VehicleShort, {
        props: {
            currentVehicle: vehicleData
        },
        global: {
            plugins: [router]
        }
    });

    expect(wrapper.html()).not.toContain('Details');
});

test('isEditEnabled prop affects inputs', async () => {
    let vehicleData = { licensed: true, id: 1 } as VehicleShortModel;

    const wrapper = mount(VehicleShort, {
        props: {
            currentVehicle: vehicleData,
            isEditEnabled: false
        },
        global: {
            plugins: [router]
        }
    });

    expect(wrapper.find('input').html()).toContain('disabled');
    await wrapper.setProps({ isEditEnabled: true });

    expect(wrapper.find('input').html()).not.toContain('disabled');
});
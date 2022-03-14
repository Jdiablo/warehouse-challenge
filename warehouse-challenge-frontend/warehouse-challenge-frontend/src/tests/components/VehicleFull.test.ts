import { mount, createLocalVue  } from '@vue/test-utils'
import { assert, expect, test, vi } from 'vitest'
import type VehicleFullModel from "@/types/VehicleFullModel"
import VehicleFull from "@/components/VehicleFull.vue"
import router from "@/router"
import axios from "axios";
import VueRouter from 'vue-router'

test('renders a vehicle full card info on mounted', async () => {
    let vehicleData = {} as VehicleFullModel;

    vi.spyOn(axios, 'get').mockResolvedValue(vehicleData);

    const wrapper = mount(VehicleFull, {
        global: {
            mocks: {
                $route: {
                    params: {
                        id: 1
                    }
                },
                $router: {

                }
            }
        }
    });

    expect(wrapper.html()).toContain('Model');
});

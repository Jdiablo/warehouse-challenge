import { mount  } from '@vue/test-utils'
import { assert, expect, test, vi } from 'vitest'
import type VehicleFullModel from "@/types/VehicleFullModel"
import VehicleFull from "@/components/VehicleFull.vue"

import VehicleService from "@/api/vehicle-service"

test('renders a vehicle full card info on mounted', async () => {
    let vehicleData = {} as VehicleFullModel;

    vi.spyOn(VehicleService, 'get').mockResolvedValue(vehicleData);

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

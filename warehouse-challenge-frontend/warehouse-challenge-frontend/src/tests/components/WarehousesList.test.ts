import { mount } from '@vue/test-utils'
import { expect, test, vi } from 'vitest'
import type WarehouseModel from "@/types/WarehouseModel";
import WarehousesList from "@/components/WarehousesList.vue"
import WarehouseService from "@/api/warehouse-service"
import { nextTick } from 'vue'

test('renders warehouses list on mounted', async () => {
    let warehousesModel = [{ id: '1' }, { id: '2' }] as WarehouseModel[];

    vi.spyOn(WarehouseService, 'getAll').mockResolvedValue(warehousesModel);

    const wrapper = mount(WarehousesList, {
        shallow: true,
        global: {
            stubs: ['Warehouse']
        }
    });
    
    // ffs there is no any clue why without these lines it just doesn't work
    await nextTick();
    await nextTick();
    await nextTick();
    await nextTick();

    expect(wrapper.findAll('.warehouse-container')).toHaveLength(2);
});

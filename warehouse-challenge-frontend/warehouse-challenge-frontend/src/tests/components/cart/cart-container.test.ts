import { mount  } from '@vue/test-utils'
import { assert, expect, test, vi } from 'vitest'
import type VehicleFullModel from "@/types/VehicleFullModel"
import CartContainer from "@/components/cart/cart-container.vue"

test('renders a cart items list when not empty', async () => {
    let cartItems = [{id: 1, make: "test"}] as VehicleFullModel[];

    const $store = {
        state: {
            cartItems: cartItems
        },
        commit: vi.fn()
    }

    const wrapper = mount(CartContainer, {
        global: {
            mocks: {
                $store
            }
        }
    });

    expect(wrapper.findAll('.cart-item')).toHaveLength(1);
});

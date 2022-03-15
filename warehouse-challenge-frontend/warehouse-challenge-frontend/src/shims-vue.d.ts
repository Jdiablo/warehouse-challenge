import VueRouter, { Route } from 'vue-router'
/* eslint-disable */
declare module '*.vue' {
    import type { DefineComponent } from 'vue'
    const component: DefineComponent<{}, {}, any>
    export default component
}
declare module 'vue/types/vue' {
    interface Vue {
        $router: VueRouter
    }
}

import { ComponentCustomProperties } from "vue";
import { Store } from "vuex";

declare module "@vue/runtime-core" {
    interface ComponentCustomProperties {
        $store: Store<State>;
    }
}

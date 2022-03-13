import { createWebHistory, createRouter } from "vue-router";
import type { RouteRecordRaw } from "vue-router";
const routes: Array<RouteRecordRaw> = [
    {
        path: "/",
        alias: "/warehouse",
        name: "warehouse",
        component: () => import("@/components/WarehousesList.vue"),
    }
];
const router = createRouter({
    history: createWebHistory(),
    routes,
});
export default router;
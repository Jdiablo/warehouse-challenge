import { createWebHistory, createRouter } from "vue-router";
import type { RouteRecordRaw } from "vue-router";
const routes: Array<RouteRecordRaw> = [
    {
        path: "/",
        alias: "/warehouse",
        name: "warehouse",
        component: () => import("@/components/warehouses-list.vue"),
    },
    {
        path: "/vehicle/:id",
        name: "vehicle",
        component: () => import("@/components/vehicle-full.vue"),
    }
];
const router = createRouter({
    history: createWebHistory(),
    routes,
});
export default router;
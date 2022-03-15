import { createApp } from 'vue'
import App from './App.vue'
import router from "@/router"
import 'bootstrap'
import 'bootstrap/dist/css/bootstrap.min.css'
import DKToast from 'vue-dk-toast';
import CartStore from "@/store/cart/cart-store-setup"

createApp(App).use(router).use(DKToast).use(CartStore).mount('#app')

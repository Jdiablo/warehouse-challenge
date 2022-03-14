import { createApp } from 'vue'
import App from './App.vue'
import router from "@/router"
import 'bootstrap'
import 'bootstrap/dist/css/bootstrap.min.css'
import DKToast from 'vue-dk-toast';

createApp(App).use(router).use(DKToast).mount('#app')

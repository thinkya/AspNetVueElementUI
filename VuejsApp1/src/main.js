import Vue from 'vue';
import App from './App.vue';

Vue.config.productionTip = true;

var vm = new Vue({
    render: h => h(App)
}).$mount('#app');

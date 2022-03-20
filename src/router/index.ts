import Vue from 'vue'
import VueRouter, { RouteConfig } from 'vue-router'
import ListChampions from '../components/ListChampions.vue'
import ChampionDetails from '../components/ChampionDetails.vue'

Vue.use(VueRouter)

const routes: Array<RouteConfig> = [
  {
    path: '/',
    name: 'Home',
    component: ListChampions
  },
  {
    path: '/Champion/:id',
    name: 'ChampionDetails',
    component: ChampionDetails
  },

]

const router = new VueRouter({
  routes
})

export default router

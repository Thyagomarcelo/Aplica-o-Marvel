import Vue from 'vue'
import Vuex, { Store } from 'vuex'
import axios from 'axios'

Vue.use(Vuex)

const url = "https://localhost:44364"

export default new Vuex.Store({
  state: {
    backgroundTheme : null,
    championsFilter: [
      {
        champion :
        {
          nome : "",
          id: "",
          image: "",
          title: ""
        }
      }
    ],
    championModel : {

    }
  },
  mutations: {
    setChampionsFilter(state, response){
      state.championsFilter = response
    },
    setBackgroundTheme(state, obj){
      state.backgroundTheme = obj
    },
    setChampionDetails(state, obj){
      state.championModel = obj
    }
  },
  actions: {

    getChampions(){
      axios.get(`${url}/Character/getAllCharacters`).then((response) => {      
        this.commit("setChampionsFilter", response.data.data)
      })
      .catch((error => {
        console.log(error)
      })
      )
    },

    getChampionDetails({commit}, params){
      console.log(params)
      return new Promise((resolve, reject) => {
        axios.get(`${url}/Character/getChampionDetails?championId=${params}`)
         .then((response) => {
            commit('setChampionDetails', response.data.data);
            resolve(response.data);
         })
         .catch(function (error) {
            reject(error);
         });
     
       });
    }

  },
  modules: {
  }
})

<style scoped>
   .containerPage{
     background: rgb(66, 66, 66);   
   }
  .containerChampion{
    margin-top: 10px;
    margin-right: 100px;
    display: inline-block;
    color: rgb(12, 12, 12);
    margin-left: auto;
  }
  .nameChampion{
    font-size: 1.3rem;
    font-family:  "Impact, fantasy";
  }
</style>

<template>
  <section class="containerPage">
    <v-card
        class="mx-auto containerChampion"
        max-width="344"
        v-for="champion in championsFilter" :key="champion.id"
        @click="$router.push('/Champion/' + champion.id)">
            <v-img
            :src="`http://ddragon.leagueoflegends.com/cdn/img/champion/loading/${champion.id}_0.jpg`" @mouseenter="setBackgroundTheme(champion.id)"
            height="500px"
            ></v-img>

            <v-card-title class="nameChampion">
            {{champion.name}}
            </v-card-title>

            <v-card-subtitle style="float: left">
            {{champion.title}}
            </v-card-subtitle>

            <v-card-actions style="float: right">
            <v-btn
                color="blue lighten-2"
                text
                
            >
                Detalhes
            </v-btn>
            </v-card-actions>
  </v-card>  
  </section>
</template>

<script lang="ts">
import Vue from 'vue';

export default Vue.extend({
    mounted() {
      this.getChampions();
    },

    computed:{
      championsFilter(){
        return this.$store.state.championsFilter
      },   
      
    },

    methods:{
        async getChampions(){

        try{
          var resp = await this.$store.dispatch("getChampions")
        }
        catch{

        }

      },

      setBackgroundTheme(championId: any){
         this.$store.commit("setBackgroundTheme", championId)
      }
    }
});
</script>

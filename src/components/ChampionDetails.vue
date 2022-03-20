<style scoped>


.image{
    width: 100%;
}
.title{
    font-size: 5rem;
}
.lore{
    margin: 0 auto;
    width: 700px;
    line-height: 50px;
    font-size: 2rem;
}
</style>

<template>
    <div :style="`background-image: url(http://ddragon.leagueoflegends.com/cdn/img/champion/splash/${this.championDetails.id}_0.jpg); background-position: center top;background-size: 100% auto;background-attachment: fixed;`">
        <h1 class="title">{{this.championDetails.id}}</h1>
        <p class="lore">{{this.championDetails.lore}}</p>
    </div>
</template>

<script lang="ts">

    import Vue from 'vue'

    export default Vue.extend({

        beforeMount(){
            this.getChampionDetails(this.$route.params.id)
        },

        computed:{
            championDetails(){
                return this.$store.state.championModel
            },
        },

        methods:{
            async getChampionDetails(championId: any){

                try{

                    const resp = await this.$store.dispatch("getChampionDetails", championId)
                    console.log(this.$store.state.championModel)
                    
                }
                catch{
                    console.log("Erro")
                }

            }
        }
    })

</script>
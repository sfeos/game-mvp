<template>

    <div id="app">
        <div id="main-layout">
            <div id="navigation">
                <nav-menu params="route: route"></nav-menu>
            </div>
            <div id="content">
                <router-view></router-view>
            </div>
        </div>
    </div>

</template>




<script>
import Vue from 'vue'
import CounterExample from './counter-example'
import FetchData from './fetch-data'
import HomePage from './home-page'
import NavMenu from './nav-menu'

Vue.component('counter-example', CounterExample);
Vue.component('fetch-data', FetchData);
Vue.component('home-page', HomePage);
Vue.component('nav-menu', NavMenu);

export default {
    data() {
        return {
        }
    }
}
</script>




<style>
    #main-layout {
        display: grid;
        grid-template-columns: auto;
        grid-template-rows: 1fr auto;
        grid-template-areas: 'nav' 'content'
    }

    @media only screen and (min-width: 64em) {
        #main-layout {
            display: grid;
            grid-template-columns: 2fr 10fr;
            grid-template-rows: 1fr auto;
            grid-template-areas: 'nav content' 'nav content';
        }
    }

    #navigation {
        grid-area: nav;
        border: dashed 1px gray;
        padding: 0 .5rem;
    }

    #content {
        grid-area: content;
        border: dashed 1px gray;
        padding: 0 1rem;
    }
</style>

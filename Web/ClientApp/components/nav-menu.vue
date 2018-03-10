<template>

    <div >
        <div>
            <button type="button" v-on:click="toggleCollapsed">
                <span class="sr-only">Toggle navigation</span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
                <span class="icon-bar"></span>
            </button>
        </div>
        <div v-show="!collapsed">
            <ul >
                <li v-for="route in routes" v-bind:key="route.path">
                    <!-- TODO: highlight active link -->
                    <router-link :to="route.path">
                        <span :class="route.style"></span> {{ route.display }}
                    </router-link>
                </li>
            </ul>
        </div>
    </div>

</template>




<script>
import { routes } from "../routes";

export default {
  data() {
    return {
      routes,
      collapsed: true
    };
  },
  methods: {
    toggleCollapsed: function(event) {
      this.collapsed = !this.collapsed;
    }
  }
};
</script>




<style>
.slide-enter-active,
.slide-leave-active {
  transition: max-height 0.35s;
}
.slide-enter,
.slide-leave-to {
  max-height: 0px;
}

.slide-enter-to,
.slide-leave {
  max-height: 20em;
}
</style>

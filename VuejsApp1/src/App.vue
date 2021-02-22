<template>
    <div id="app">
        <Home msg="Hello world!" />
        <TodoItem />
    </div>
</template>

<script>
    import Home from './components/Home.vue';
    import TodoItem from './components/todo-item.vue';

    export default {
        name: 'app',
        components: {
            Home, TodoItem
        }
    };
</script>

<style>
</style>


<template>
    <div class="home">
        <h1>{{ msg }}</h1>
        <h2>{{ message }}</h2>
        <ol>
            <li v-bind:title="message" v-if="seen" v-for="todo in todos">
                {{ todo.text }}
            </li>
        </ol>
        <button v-on:click="reverseMessage">反转消息</button>
        <input v-model="message">
    </div>
</template>

<script>
    export default {
        name: 'Home',
        props: {
            msg: String
        },
        data: function () {
            return {
                message: '页面加载于 ' + new Date().toLocaleString(),
                seen: true,
                todos: [
                    { text: '学习 JavaScript' },
                    { text: '学习 Vue' },
                    { text: '整个牛项目' }
                ]
            }
        },
        methods: {
            reverseMessage: function () {
                this.message = this.message.split('').reverse().join('')
            }
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>
</style>


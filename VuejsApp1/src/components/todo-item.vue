<template>
    <div class="todoitem">
        <ol>
            <li v-for="item in groceryList" v-bind:todo="item" v-bind:key="item.id">{{ item.text }}</li>
        </ol>
    </div>
</template>

<script>
    var groceryList = [
        { id: 0, text: '蔬菜' },
        { id: 1, text: '奶酪' },
        { id: 2, text: '随便其它什么人吃的东西' }
    ];
    Object.freeze(groceryList);
    export default {
        name: 'TodoItem',
        props: ['todo'],
        data: function () {
            return {
                groceryList: groceryList
            }
        }
    };
    
    groceryList[1].text = "修改";
</script>

<style scoped>
</style>
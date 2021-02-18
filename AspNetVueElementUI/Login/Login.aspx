<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AspNetVueElementUI.Login.Login" %>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="/Scripts/vue.js"></script>
    <script src="/Scripts/vue-resource.js"></script>
    <script src="/Scripts/ElementUI/element-ui.js"></script>
    <%--<script src="/Scripts/kit.js"></script>--%>
    <%--<script src="/Scripts/global.js"></script>--%>
    <link href="/Content/ElementUI/element-ui.css" rel="stylesheet" />
    <title>管理系统</title>
    <style>
        .el-row {
            margin-bottom: 20px;
        }
 
        .login-box {
            margin-top: 20%;
            margin-left: 40%;
        }
    </style>
</head>
<body>
    <div class="login-box" id="app">
        <el-row>
            <el-col :span="8">
                <el-input id="name" v-model="name" placeholder="请输入帐号">
                    <template slot="prepend">
                        帐号
                    </template>
                </el-input>
            </el-col>
        </el-row>
        <el-row>
            <el-col :span="8">
                <el-input id="password" v-model="password" type="password" placeholder="请输入密码">
                    <template slot="prepend">
                        密码
                    </template>
                </el-input>
            </el-col>
        </el-row>
        <el-row>
            <el-col :span="8">
                <el-button id="login" v-on:click="check" style="width:100%" type="primary" v-loading.fullscreen.lock="logining">登录</el-button>
            </el-col>
        </el-row>
    </div>
</body>
 
<script type="text/javascript">
    window.onload = function () {
        new Vue({
            el: '#app',
            data: {
                name: '',
                password: '',
                logining: false
            },
            methods: {
                check: function (event) {
                    //获取值
                    var name = this.name;
                    var password = this.password;
                    if (name == '' || password == '') {
                        this.$message({
                            message: '账号或密码为空！',
                            type: 'error'
                        })
                        return;
                    }
                    var turnUrl = "/default.aspx";// kit.getQueryString('ReturnUrl');
                    //if (turnUrl == undefined || turnUrl == null || turnUrl.length <= 0) {
                    //    turnUrl = "/default.aspx";
                    //}
                    var url = '/API/Login/Login?account=' + name + "&password=" + password;
                    this.logining = true;
                    this.$http.get(url).then(function (res) {
                        var result = res.body;
                        this.$message({
                            message: result.Message,
                            type: result.Status == 0 ? 'success' : 'error'
                        })
                        this.logining = false;
                        if (result.Status == 0) {
                            //global.setUser(result.Data.UserGuid, result.Data.UserName);
                            window.location = turnUrl;
                        }
                    }, function (e) {
                        console.log(e);
                        this.$message({
                            message: '登录异常',
                            type: 'error'
                        })
                        this.logining = false;
                    });
                }
            }
        })
    }
</script>
</html>
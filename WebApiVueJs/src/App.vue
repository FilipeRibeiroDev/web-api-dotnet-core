<template>
    <div class="login-header flex row col-12 q-my-md justify-center">
       <img alt="Vue logo" src="./assets/logo.png">
    </div>
    <div class="row col-12 justify-center">
        <form @submit.prevent="authenticate" class="row">
          <div class="col-12 q-mt-md">
              <q-input v-model="data.username" outlined bg-color="white" label="Usuário" id="username" dense
                  input-class="input-default" />
          </div>
          <div class="col-12 q-mt-md">
            <q-input v-model="data.password" type="password" bg-color="white" outlined label="Senha" id="password" dense
              input-class="input-default" />
          </div>
          <div class="flex row col-12 justify-end q-pt-lg">
              <q-btn v-if="loading" type="submit" color="primary"  >
                  <q-spinner-hourglass color="white" size="1.5rem" />
              </q-btn>
              <q-btn v-else type="submit" color="primary" label="Login" />
          </div>
        </form>
    </div>
</template>

<script setup>
import { ref } from 'vue';
import LoginService from '@/services/LoginService';

let _loginService = new LoginService();
let loading = ref(false);

let data = ref({
    username: "",
    password: "",
})

async function authenticate(){
  loading.value  = true;
  await _loginService.Login(data.value).then((response) => {
    alert(response.token);
  }).catch(() => {
    alert("Falha");
  });
}

</script>

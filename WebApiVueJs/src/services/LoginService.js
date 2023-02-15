import http from '@/http-common';

export default class LoginService {
    async Login(data){
        let response = await http.post(`api/v1/auth?username=${data.username}&password=${data.password}`);
        return response.data;
    }
}
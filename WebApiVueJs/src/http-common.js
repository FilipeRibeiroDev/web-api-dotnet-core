import Axios from 'axios';

const createAxios = Axios.create({
    baseURL: "https://localhost:7283"
});

export default createAxios;

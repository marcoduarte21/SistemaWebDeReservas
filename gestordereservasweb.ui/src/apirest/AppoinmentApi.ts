import axios from 'axios'; 
import { User } from '../models/User';

const API = 'https://localhost:7232/api/Admin/';


export const getUsers = async () => {

    return axios.get<User[]>(`${API}GetUsers`);
}

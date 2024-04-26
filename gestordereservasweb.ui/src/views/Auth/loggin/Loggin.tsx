import React, { useEffect, useState } from 'react';
import { useAuth } from '../../../hooks/useAuth';
import { User } from '../../../models/User';
import './Loggin.css';
import * as API from '../../../apirest/AppoinmentApi'


interface LogginProps {

}

export const Loggin: React.FC<LogginProps> = () => {

    const { login, user, setUser } = useAuth();
    const [ListUsers, setListUsers] = useState<User[]>([]);


    useEffect(() => {
        getListUsers();
    }, [])

    const getListUsers = async () => {

        const response = await API.getUsers();
        setListUsers(response.data)
    }

    const handleLogin = () => {
        login({});
    };

    const verificarInicioDeSesion = () => {

        const userNameInput = document.querySelector("#username");
        const passwordInput = document.querySelector("#clave");

        ListUsers.map(user =>
            if (user.userId? == userNameInput && user.password¡ == passwordInput) {
            setUser(user);
        }
        );
    }


    return (

        <div className="container">
            <div className="loggin-container">
                    <h1>Iniciar sesion</h1>
                <div>
                    <input type='text' placeholder="nombre de usuario" id='username' name='username'/>
                </div>
                <div>                   
                    <input type='password' placeholder="Clave" id='clave' name='clave'/>
                </div>
                <div>
                    <button onClick={handleLogin}>iniciar sesion</button>
                </div>
            </div>
        </div>

    );
}
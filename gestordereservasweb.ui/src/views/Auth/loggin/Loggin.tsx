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
        console.log(response.data)
    }

    const verificarInicioDeSesion = () => {

        const inputUserName = document.getElementById("username") as HTMLInputElement;
        const inputPassword = document.getElementById("clave") as HTMLInputElement;

        // Acceder al valor del campo de contraseña
        const textoContrasena: string = inputPassword.value;
        const textoUserName: string = inputUserName.value;
        
        ListUsers.map(userr => {

            if (userr.userId == textoUserName && userr.password == textoContrasena) {
                setUser(userr);
                window.location.href = "/";
            } else {
                const miParrafo = document.querySelector("#aviso");
                if (miParrafo) {
                    miParrafo.innerHTML = "User or password incorrect";
                } else {
                    console.error("No se encontró el elemento.");
                }
            }
        });
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
                    <button onClick={verificarInicioDeSesion}>iniciar sesion</button>
                    <p id="aviso"></p>
                </div>
            </div>
        </div>

    );
}
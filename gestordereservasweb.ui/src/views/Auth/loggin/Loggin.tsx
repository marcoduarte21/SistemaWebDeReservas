import React, { useEffect } from 'react';
import './Loggin.css';

interface LogginProps {

}

export const Loggin: React.FC<LogginProps> = () => {

    useEffect(() => {

        document.title = 'Loggin';
    },[])

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
                    <button>iniciar sesion</button>
                </div>
            </div>
        </div>

    );
}
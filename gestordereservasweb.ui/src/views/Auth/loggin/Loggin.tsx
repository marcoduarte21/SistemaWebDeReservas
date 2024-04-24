import React from 'react';
import './Loggin.css';

interface LogginProps {

}

export const Loggin: React.FC<LogginProps> = () => {

    return (

        <div className="container">
            <div className="loggin-container">
                    <h1>Iniciar sesion</h1>
                <div>
                    <label htmlFor='username'>Nombre de usuario</label>
                    <input type='text' placeholder="nombre de usuario" id='username' name='username'/>
                </div>
                <div>
                    <label htmlFor='clave'>Clave</label>
                    <input type='password' placeholder="Clave" id='clave' name='clave'/>
                </div>
                <div>
                    <button>iniciar sesion</button>
                </div>
            </div>
        </div>

    );
}
import React, { useEffect, useState } from 'react';
import { Table } from 'react-bootstrap';
import { User } from '../../models/User';
import * as API  from '../../apirest/AppoinmentApi'

interface TableUsersProps {

}

export const TableUsers: React.FC<TableUsersProps> = () => {

    const [ListUsers, setListUsers] = useState<User[]>([]);


    useEffect(() => {
        getListUsers();
    }, [])

    const getListUsers = async () => {

        const response = await API.getUsers();
       setListUsers(response.data)
    }

    return (
        <div className="table-users">
            <h1>Lista de Usuarios</h1><Table striped bordered hover>
                <thead>
                    <tr>
                        <th>User Name</th>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Primer Apellido</th>
                        <th>Segundo Apellido</th>
                        <th>Email</th>
                        <th>Telefono</th>
                        <th>Role</th>
                    </tr>
                </thead>
                <tbody>
                    {ListUsers.map(user =>
                        <tr key={user.userId }>
                            <td>{user.userId}</td>
                            <td>{user.idCard}</td>
                            <td>{user.name}</td>
                            <td>{user.firstSurname}</td>
                            <td>{user.secondSurname}</td>
                            <td>{user.email}</td>
                            <td>{user.cellNumber}</td>
                            <td>{user.rolle}</td>
                        </tr>
                    )}
                </tbody>
            </Table>
        </div >
    );
}

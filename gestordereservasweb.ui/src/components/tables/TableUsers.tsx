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
                        <th>#</th>
                        <th>First Name</th>
                        <th>Role</th>
                        <th>Password</th>
                    </tr>
                </thead>
                <tbody>
                    {ListUsers.map(user =>
                        <tr key={user.userId }>
                            <td>{user.userId}</td>
                            <td>{user.idPerson}</td>
                            <td>{user.rolle}</td>
                            <td>{user.passwordd}</td>
                        </tr>
                    )}
                </tbody>
            </Table>
        </div >
    );
}

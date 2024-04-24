import React, { useEffect } from 'react';
import logo from './logo.svg';
import './App.css';
import NavBar from './components/navbar/NavBar';
import 'bootstrap/dist/css/bootstrap.min.css';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import { Nav } from 'react-bootstrap';
import { TableUsers } from './components/tables/TableUsers';
import { Home } from './views/home/Home';
import { Loggin } from '../src/views/Auth/loggin/Loggin'

function App() {

  return (
      <BrowserRouter>
      <NavBar />
          <Routes>
              <Route path='/loggin' element={ <Loggin /> } />
              <Route path='/' element={<Home /> } />
              <Route path='/users' element={<TableUsers />} />
          </Routes>
      </BrowserRouter>
  );
}

export default App;

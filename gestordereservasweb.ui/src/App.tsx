import React, { useEffect } from 'react';
import logo from './logo.svg';
import './App.css';
import NavBar from './components/navbar/NavBar';
import 'bootstrap/dist/css/bootstrap.min.css';
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import { Nav } from 'react-bootstrap';
import { TableUsers } from './components/tables/TableUsers';

function App() {

  return (
      <BrowserRouter>
      <NavBar />
          <Routes>
              <Route path='/' element={<TableUsers />} />
          </Routes>
      </BrowserRouter>
  );
}

export default App;

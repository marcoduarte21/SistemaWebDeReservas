import React from 'react';
import { Container, Nav, Navbar } from 'react-bootstrap';
import { Link } from "react-router-dom";

function NavBar() {
  return (
      <>
          <Navbar bg="dark" data-bs-theme="dark">
              <Container>
                  <Navbar.Brand><Link to="/">Reserva de citas</Link></Navbar.Brand>
                  <Nav className="me-auto">
                      <Nav.Link><Link to="/">Home</Link></Nav.Link>
                      <Nav.Link><Link to='/users'>Users List</Link></Nav.Link>
                      <Nav.Link href="#pricing">Appoinments List</Nav.Link>
                      <Nav.Link href="#pricing">Employees List</Nav.Link>
                      <Nav.Link href="#pricing">Programar cita</Nav.Link>
                      <Nav.Link href="#pricing">Citas programadas</Nav.Link>
                  </Nav>
              </Container>
          </Navbar>
      </>
  );
}

export default NavBar;
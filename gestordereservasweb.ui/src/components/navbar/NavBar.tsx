import React from 'react';
import { Container, Nav, Navbar } from 'react-bootstrap';

function NavBar() {
  return (
      <>
          <Navbar bg="dark" data-bs-theme="dark">
              <Container>
                  <Navbar.Brand href="#home">Reserva de citas</Navbar.Brand>
                  <Nav className="me-auto">
                      <Nav.Link href="#home">Home</Nav.Link>
                      <Nav.Link href="#features">Users List</Nav.Link>
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
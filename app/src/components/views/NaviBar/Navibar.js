import React from "react";
import { Nav, Navbar } from "react-bootstrap";
import ToggleMenu from "./ToggleMenu";
import logo from "../../../../src/gym.png";

function Navibar2() {
  return (
    <>
      <style type="text/css">
        {`
            .nav-link {
                margin-right :10px;
            }
        `}
      </style>
      <Navbar collapseOnSelect expand="lg" bg="light" variant="light">
        <Navbar.Brand href="/">
          <img
            alt=""
            src={logo}
            width="30"
            height="30"
            className="d-inline-block align-top"
          />{" "}
          CGM GYM
        </Navbar.Brand>

        <Navbar.Toggle aria-controls="responsive-navbar-nav" />
        <Navbar.Collapse id="responsive-navbar-nav">
          <Nav className="mr-auto">
            <Nav.Link href="About">Gym Genie</Nav.Link>
            <Nav.Link href="#pricing">About us</Nav.Link>
            {/* <NavDropdown title="Dropdown" id="collasible-nav-dropdown">
              <NavDropdown.Item href="#action/3.1">Action</NavDropdown.Item>
              <NavDropdown.Item href="#action/3.2">
                Another action
              </NavDropdown.Item>
              <NavDropdown.Item href="#action/3.3">Something</NavDropdown.Item>
              <NavDropdown.Divider />
              <NavDropdown.Item href="#action/3.4">
                Separated link
              </NavDropdown.Item>
            </NavDropdown> */}
          </Nav>
          <Nav>
            <ToggleMenu />
          </Nav>
        </Navbar.Collapse>
      </Navbar>
    </>
  );
}

export default Navibar2;

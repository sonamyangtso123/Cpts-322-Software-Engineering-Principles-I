import React from "react";
import { withRouter } from "react-router-dom";
import logo from "../../../../src/gym.png";
import ToggleMenu from "./ToggleMenu";

function Navibar(props) {
  return (
    <>
      <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
        <button
          className="navbar-toggler"
          type="button"
          data-toggle="collapse"
          data-target="#navbarNav"
          aria-controls="navbarNav"
          aria-expanded="false"
          aria-label="Toggle navigation"
        >
          <span className="navbar-toggler-icon"></span>
        </button>
        <div className="collapse navbar-collapse" id="navbarNav">
          <a className="navbar-brand" href="/">
            <img src={logo} width="30" height="30" alt="" />
          </a>
          <ul className="navbar-nav" style={{ padding: "0px 10px" }}>
            <li className="nav-item active">
              <a className="nav-link" href="/">
                Home <span className="sr-only">(current)</span>
              </a>
            </li>
            <li className="nav-item">
              <a className="nav-link" href="/">
                About
              </a>
            </li>
            <li className="nav-item">
              <a className="nav-link" href="/">
                Contact
              </a>
            </li>
          </ul>
        </div>
        <form className="form-inline">
          <ToggleMenu />
        </form>
      </nav>
    </>
  );
}

export default withRouter(Navibar);

import React from "react";
import axios from "axios";
import { useSelector } from "react-redux";
import { withRouter } from "react-router-dom";

function ToggleMenu(props) {
  const user = useSelector((state) => state.user);

  const logoutHandler = () => {
    axios.get("api/users/logout").then((response) => {
      if (response.status === 200) {
        props.history.push("/login");
      } else {
        alert("Log Out Failed");
      }
    });
  };

  if (user.userData && !user.userData.isAuth) {
    return (
      <>
        <div className="form-inline my-2 my-lg-0">
          <a className="nav-link text-secondary" href="/login">
            Sign in
          </a>
          <a type="button" className="btn btn-outline-info" href="/register">
            Sign up
          </a>
          
        </div>
      </>
    );
  } else {
    return (
      <>
        <a
          className="nav-link text-white"
          href="/login"
          onClick={logoutHandler}
        >
          Sign out
        </a>
      </>
    );
  }
}

export default withRouter(ToggleMenu);

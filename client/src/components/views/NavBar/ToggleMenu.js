import React from "react";
import { Nav,Button } from "react-bootstrap";
import { logoutUser } from "../../../_actions/user_actions";
import { useDispatch } from "react-redux";
import { useSelector } from "react-redux";
import { withRouter } from "react-router-dom";

function ToggleMenu(props) {
  const dispatch = useDispatch();
  const user = useSelector((state) => state.user);

  const logoutHandler = () => {
    dispatch(logoutUser()).then((response) => {
      console.log(response.payload.success);
      if (response.payload.success) {
        props.history.push("/login");
      } else {
        alert("Fail to logout");
      }
    });
  };

  if (user.userData && !user.userData.isAuth) {
    return (
      <div className="form-inline my-2 my-lg-0">
        <Nav.Link  href="/login">Sign in</Nav.Link>{" "}
        <Button variant="outline-info" href="/register">
          Sign up
        </Button>
      </div>
    );
  } else {
    return <Nav.Link onClick={logoutHandler}>Sign out</Nav.Link>;
  }
}

export default withRouter(ToggleMenu);

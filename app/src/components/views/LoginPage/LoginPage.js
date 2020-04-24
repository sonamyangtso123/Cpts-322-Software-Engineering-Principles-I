import React, { useState } from "react";
import { useDispatch } from "react-redux";
import { loginUser } from "../../../_actions/user_action";
import { withRouter } from "react-router-dom";
import logo from "../../../../src/gym.png";

function LoginPage(props) {
  const dispatch = useDispatch();

  const [Email, setEmail] = useState("");
  const [Password, setPassword] = useState("");
  const [ErrorMessage, setErrorMessage] = useState("");

  const onEmailHandler = (event) => {
    setEmail(event.currentTarget.value);
  };

  const onPasswordHandler = (event) => {
    setPassword(event.currentTarget.value);
  };

  const onSubmitHandler = (event) => {
    event.preventDefault();

    let body = {
      email: Email,
      password: Password,
    };

    dispatch(loginUser(body)).then((response) => {
      console.log(response.payload.loginSuccess);
      if (response.payload.loginSuccess) {
        props.history.push("/");
      } else {
        setErrorMessage("Email or Password is invalid");
      }
    });
  };

  return (
    <>
      <div className="text-center container">
        <form className="form-signin" onSubmit={onSubmitHandler}>
          <img className="mb-4" src={logo} alt="" width="72" height="72" />
          <h1 className="h3 mb-3 font-weight-normal">Please sign in</h1>
          <label htmlFor="inputEmail" className="sr-only">
            Email address
          </label>
          <input
            type="email"
            id="top"
            className="form-control top"
            placeholder="Email address"
            // required=""
            autoFocus=""
            value={Email}
            onChange={onEmailHandler}
          />
          <label htmlFor="inputPassword" className="sr-only">
            Password
          </label>
          <input
            type="password"
            id="bottom"
            className="form-control bottom"
            placeholder="Password"
            // required=""
            value={Password}
            onChange={onPasswordHandler}
          />
          {/* <div className="checkbox mb-3">
            <label>
              <input type="checkbox" value="remember-me" /> Remember me
            </label>
          </div> */}
          <textarea
            type="text"
            className="error-message"
            value={ErrorMessage}
            readOnly
          />
          <button className="btn btn-lg btn-primary btn-block" type="submit">
            Sign in
          </button>
          <p className="mt-5 mb-3 text-muted">© 2020</p>
        </form>
      </div>
    </>
  );
}

export default withRouter(LoginPage);

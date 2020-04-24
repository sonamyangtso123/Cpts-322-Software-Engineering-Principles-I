import React, { useState } from "react";
// import moment from "moment";
import { useDispatch } from "react-redux";
import { loginUser, registerUser } from "../../../_actions/user_action";
import { withRouter } from "react-router-dom";
import logo from "../../../../src/gym.png";

function RegisterPage(props) {
  const dispatch = useDispatch();

  const [Firstname, setFirstname] = useState("");
  const [Lastname, setLastname] = useState("");
  const [Email, setEmail] = useState("");
  const [Password, setPassword] = useState("");
  const [Confirm, setConfirm] = useState("");
  const [ErrorMessage, setErrorMessage] = useState("");

  const onFirstnameHandler = (event) => {
    setFirstname(event.currentTarget.value);
  };
  const onLastnameHandler = (event) => {
    setLastname(event.currentTarget.value);
  };

  const onEmailHandler = (event) => {
    setEmail(event.currentTarget.value);
  };

  const onPasswordHandler = (event) => {
    setPassword(event.currentTarget.value);
  };

  const onConfirmHandler = (event) => {
    setConfirm(event.currentTarget.value);
  };

  const onSubmitHandler = (event) => {
    event.preventDefault();

    if (!Firstname.trim() || !Lastname.trim()) {
      return setErrorMessage("Name is required");
    }
    if (!Email.trim()) {
      return setErrorMessage("Email is required");
    }
    if (!checkPasswordPattern(Password)) {
      return setErrorMessage(
        "Password must contain in at least 6 characters,\nlncluding UPPER/lowercase and numbers"
      );
    }
    if (!Confirm.trim()) {
      return setErrorMessage("Confrim Password is required");
    }
    if (Password !== Confirm) {
      return setErrorMessage("The password do not match.");
    }

    let body = {
      name: Firstname,
      lastname: Lastname,
      email: Email,
      password: Password,
    };

    dispatch(registerUser(body)).then((response) => {
      if (response.payload.success) {
        dispatch(loginUser(body)).then((response) => {
          console.log(response.payload.loginSuccess)
          if (response.payload.loginSuccess) {
            props.history.push("/");
          } else {
            return setErrorMessage("Failed to sign in");
          }
        });
      } else {
        return setErrorMessage("Failed to sign up");
      }
    });
  };

  return (
    <>
      <div className="text-center">
        <form className="form-signin" onSubmit={onSubmitHandler}>
          <img className="mb-4" src={logo} alt="" width="72" height="72" />
          <h1 className="h3 mb-3 font-weight-normal">Create new account</h1>
          <div className="row text-left">
            <div className="col-6">
              <label className="label-signup" htmlFor="inputFirstname">
                First name
              </label>
              <input
                type="text"
                className="form-control"
                value={Firstname}
                onChange={onFirstnameHandler}
              ></input>
            </div>
            <div className="col-6">
              <label className="label-signup" htmlFor="inputLastname">
                Last name
              </label>
              <input
                type="text"
                className="form-control"
                value={Lastname}
                onChange={onLastnameHandler}
              ></input>
            </div>
            <div className="col-12">
              <label className="label-signup" htmlFor="inputEmail">
                Email address
              </label>
              <input
                type="email"
                className="form-control"
                value={Email}
                onChange={onEmailHandler}
              />
              <label className="label-signup" htmlFor="inputPassword">
                Password
              </label>
              <input
                type="password"
                className="form-control"
                value={Password}
                onChange={onPasswordHandler}
              />
              <label className="label-signup" htmlFor="inputPassword">
                Confirm Password
              </label>
              <input
                type="password"
                className="form-control"
                value={Confirm}
                onChange={onConfirmHandler}
              />
            </div>
            <div className="col-12">
              <textarea
                type="text"
                className="error-message"
                value={ErrorMessage}
                readOnly
              />
            </div>
          </div>
          <button className="btn btn-lg btn-primary btn-block" type="submit">
            Register
          </button>
          <p className="mt-5 mb-3 text-muted">© 2020</p>
        </form>
      </div>
    </>
  );
}

function checkPasswordPattern(str) {
  var pattern1 = /[0-9]/;
  var pattern2 = /[a-z]/
  var pattern3 = /[A-Z]/;

  if (pattern1.test(str) && pattern2.test(str) && pattern3.test(str) &&  str.length > 5) {
    return true;
  } else {
    return false;
  }
}

export default withRouter(RegisterPage);

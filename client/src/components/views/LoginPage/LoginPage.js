import React, { useState } from "react";
import { Alert, Form, Button } from "react-bootstrap";
import { useDispatch } from "react-redux";
import { loginUser } from "../../../_actions/user_actions";
import { withRouter } from "react-router-dom";
import logo from "../../../assets/gym.png";


function LoginPage(props) {
  const dispatch = useDispatch();

  const [Email, setEmail] = useState("");
  const [Password, setPassword] = useState("");
  const [ErrorMessage, setErrorMessage] = useState("");
  const [isError, setisError] = useState(false);

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
        setisError(!response.payload.loginSuccess);
        setErrorMessage("Email or Password is invalid");
      }
    });
  };

  return (
    <>
      <style type="text/css">
        {`  
            .form-container .centered{
              text-align: center; 
            }
            .form-container{
              width: 100%;
              max-width: 330px;
              margin-top: 3rem;
              margin-left: auto;
              margin-right: auto;
              position: relative;
              box-sizing: border-box;
              height: auto;
              padding: 10px;
            }
            .alert-danger{
              font-size:12px;
            }
        `}
      </style>
      <div className="form-container">
        <Form onSubmit={onSubmitHandler}>
          <div className="centered">
          <img className="mb-4" src={logo} alt="" width="72" height="72" />
          <h1 className="h3 mb-3 font-weight-normal">Please sign in</h1>
          </div>
          <Form.Group controlId="formBasicEmail">
            <Form.Label srOnly="true">Email address</Form.Label>
            <Form.Control
              type="email"
              placeholder="Enter email"
              onChange={onEmailHandler}
            />
          </Form.Group>

          <Form.Group controlId="formBasicPassword">
            <Form.Label srOnly="true">Password</Form.Label>
            <Form.Control
              type="password"
              placeholder="Password"
              onChange={onPasswordHandler}
            />
          </Form.Group>

          <Alert variant="danger" show={isError}>
            {ErrorMessage}
          </Alert>
          <Button variant="primary" type="submit" block>
            Sign in
          </Button>
          <div className="centered">
            <p className="mt-5 mb-3 text-muted">© 2020</p>
          </div>
        </Form>
      </div>
    </>
  );
}

export default withRouter(LoginPage);

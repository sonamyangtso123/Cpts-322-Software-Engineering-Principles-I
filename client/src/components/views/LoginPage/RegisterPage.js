import React, { useState } from "react";
import moment from "moment";
import { Alert, Form, Button, Col } from "react-bootstrap";
import { useDispatch } from "react-redux";
import { loginUser, registerUser } from "../../../_actions/user_actions";
import { withRouter } from "react-router-dom";
import logo from "../../../assets/gym.png";

function RegisterPage(props) {
  const dispatch = useDispatch();

  const [Firstname, setFirstname] = useState("");
  const [Lastname, setLastname] = useState("");
  const [Email, setEmail] = useState("");
  const [Password, setPassword] = useState("");
  const [Confirm, setConfirm] = useState("");
  const [ErrorMessage, setErrorMessage] = useState("");
  const [Check, setCheck] = useState("");
  const [isError, setisError] = useState(false);

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
  const onCheckHandler = (event) => {
    setCheck(event.currentTarget.value);
  };

  const onSubmitHandler = (event) => {
    event.preventDefault();

    if (!Firstname.trim() || !Lastname.trim()) {
      setisError(true);
      console.log(Check);
      return setErrorMessage("Name is required");
    }
    if (!Email.trim()) {
      setisError(true);
      return setErrorMessage("Email is required");
    }
    if (!checkPasswordPattern(Password)) {
      setisError(true);
      return setErrorMessage(
        "Password must contain in at least 6 characters,\nlncluding UPPER/lowercase and numbers"
      );
    }
    if (!Confirm.trim()) {
      setisError(true);
      return setErrorMessage("Confrim Password is required");
    }
    if (Password !== Confirm) {
      setisError(true);
      return setErrorMessage("Passward does not matched");
    }
    if (!Check) {
      setisError(true);
      return setErrorMessage("Check the agreement");
    }

    let body = {
      name: Firstname,
      lastname: Lastname,
      email: Email,
      password: Password,
      image: `http://gravatar.com/avatar/${moment().unix()}?d=identicon`,
    };

    dispatch(registerUser(body)).then((response) => {
      if (response.payload.success) {
        dispatch(loginUser(body)).then((response) => {
          console.log(response.payload.loginSuccess);
          if (response.payload.loginSuccess) {
            props.history.push("/");
          } else {
            setisError(true);
            return setErrorMessage("Please try later");
          }
        });
      } else {
        setisError(true);
        return setErrorMessage("Email already exists");
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
            label.form-label{
              text-align: left;
              margin-top: 0;
              margin-bottom: 0;
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
            <h1 className="h3 mb-3 font-weight-normal">Create new account</h1>
          </div>
          <Form.Row>
            <Form.Group as={Col} controlId="formGridFirst">
              <Form.Label>First name</Form.Label>
              <Form.Control
                type="text"
                // placeholder="John"
                onChange={onFirstnameHandler}
              />
            </Form.Group>

            <Form.Group as={Col} controlId="formGridLast">
              <Form.Label>Last name</Form.Label>
              <Form.Control
                type="text"
                // placeholder="Doe"
                onChange={onLastnameHandler}
              />
            </Form.Group>
          </Form.Row>

          <Form.Group controlId="formGridEmail">
            <Form.Label>Email</Form.Label>
            <Form.Control
              // placeholder="Enter email"
              type="email"
              onChange={onEmailHandler}
            />
          </Form.Group>

          <Form.Group controlId="formGridPassword">
            <Form.Label>Password</Form.Label>
            <Form.Control
              // placeholder="Password"
              type="password"
              onChange={onPasswordHandler}
            />
          </Form.Group>

          <Form.Group controlId="formGridConfirm">
            <Form.Label>Confirm Password</Form.Label>
            <Form.Control
              // placeholder="Confrim Password"
              type="password"
              onChange={onConfirmHandler}
            />
          </Form.Group>

          <Form.Group controlId="formBasicCheckbox">
            <Form.Check
              type="checkbox"
              label="I agree term"
              onChange={onCheckHandler}
            />
          </Form.Group>

          <Alert variant="danger" show={isError}>
            {ErrorMessage}
          </Alert>
          <Button variant="primary" type="submit" block>
            Register
          </Button>
          <div className="centered">
            <p className="mt-5 mb-3 text-muted">© 2020</p>
          </div>
        </Form>
      </div>
    </>
  );
}

function checkPasswordPattern(str) {
  var pattern1 = /[0-9]/;
  var pattern2 = /[a-z]/;
  var pattern3 = /[A-Z]/;

  if (
    pattern1.test(str) &&
    pattern2.test(str) &&
    pattern3.test(str) &&
    str.length > 5
  ) {
    return true;
  } else {
    return false;
  }
}

export default withRouter(RegisterPage);

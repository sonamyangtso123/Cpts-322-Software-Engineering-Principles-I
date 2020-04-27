import React, { Suspense } from "react";
import { Route, Switch } from "react-router-dom";
import Auth from "../hoc/auth";

// pages for this product
import MainPage from "./views/MainPage/MainPage.js"
import LoginPage from "./views/LoginPage/LoginPage.js";
import RegisterPage from "./views/LoginPage/RegisterPage.js";
import NavBar from "./views/NavBar/NavBar.js";

import "bootstrap/dist/css/bootstrap.min.css";
import "./App.scss";

//null   Anyone Can go inside
//true   only logged in user can go inside
//false  logged in user can't go inside

function App() {
  return (
    <>
      <style type="text/css">
        {`
          #root {
            font-family: "Fira Sans", sans-serif;
            position: relative;
            min-height: 100vh;
          }
          
          #content-wrap {
            padding-bottom: 5rem;    /* Footer height */
          }
          
          #footer {
            position: absolute;
            bottom: 0;
            width: 100%;
            height: 5rem;            /* Footer height */
          }
        `}
      </style>
      <Suspense fallback={<div>Loading...</div>}>
        <NavBar />
        <Switch>
          <Route exact path="/" component={Auth(MainPage, null)} />
          <Route exact path="/login" component={Auth(LoginPage, false)} />
          <Route exact path="/register" component={Auth(RegisterPage, false)} />
        </Switch>
      </Suspense>
    </>
  );
}

export default App;

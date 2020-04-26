import React, { Suspense } from "react";
import { Switch, Route } from "react-router-dom";
import Auth from "../hoc/auth";
import NaviBar2 from "./views/NaviBar/Navibar";
import MainPage from "./views/MainPage/MainPage";
import LoginPage from "./views/LoginPage/LoginPage";
import RegisterPage from "./views/LoginPage/RegisterPage";

import "bootstrap/dist/css/bootstrap.min.css";
import './App.scss';
// import "./App.css";

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
            padding-bottom: 2.5rem;    /* Footer height */
          }
          
          #footer {
            position: absolute;
            bottom: 0;
            width: 100%;
            height: 2.5rem;            /* Footer height */
          }
        `}
    </style>
    <Suspense fallback={<div>Loading...</div>}>
      <NaviBar2 />
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

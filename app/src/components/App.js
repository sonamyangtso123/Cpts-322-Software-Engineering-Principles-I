import React, { Suspense } from "react";
import { Switch, Route } from "react-router-dom";
import Auth from "../hoc/auth";
import NaviBar from "./views/NaviBar/Navibar";
import MainPage from "./views/MainPage/MainPage";
import LoginPage from "./views/LoginPage/LoginPage";
import RegisterPage from "./views/LoginPage/RegisterPage";

import "bootstrap/dist/css/bootstrap.min.css";
import "./App.css";

function App() {
  return (
    <Suspense fallback={<div>Loading...</div>}>
      <NaviBar />
      {/* <div style={{height:"60px"}}></div> */}
      <Switch>
        <Route exact path="/" component={Auth(MainPage, null)} />
        <Route exact path="/login" component={Auth(LoginPage, false)} />
        <Route exact path="/register" component={Auth(RegisterPage, false)} />
      </Switch>
    </Suspense>
  );
}

export default App;

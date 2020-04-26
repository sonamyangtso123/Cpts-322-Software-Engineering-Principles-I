import React from "react";
import Footer from "./Footer";
import { Jumbotron, Button, Container } from "react-bootstrap";
import { withRouter } from "react-router-dom";

const image1 = require("../../../assets/images/person-holding-barbell-841130.jpg");
const bImage = {
  backgroundImage: `url(${image1})`,
  backgroundSize: "100%",
  backgroundRepeat: "no-repeat",
};
console.log(image1);

function LandingPage(props) {
  return (
    <>
    <style type="text/css">
        {`
            div.container {
              color:white;
            }
            h1.main-message{
              text-align: center;
              font-size: 70px;
            }
            p.main-message{
              text-align: center;
              font-size: 30px;
            }
            .btn-primary{
              text-align: center;
            }
            
        `}
      </style>
      <Jumbotron fluid style={bImage}>
          <Container >
            <h1 className="display-4">CGM Gym</h1>
            <p className="lead">
              STAY IN, STAY FIT<br/>
              WITH CGM LIVE<br/>
              FREE FOR ALL MEMBER
            </p>
            <Button variant="primary">Learn more</Button>
          </Container>
      </Jumbotron>

      <Footer />
    </>
  );
}

export default withRouter(LandingPage);

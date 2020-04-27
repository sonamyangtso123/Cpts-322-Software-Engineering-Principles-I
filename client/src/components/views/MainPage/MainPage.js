import React from "react";
import Footer from "./Footer";
import { Jumbotron, Container, Button} from "react-bootstrap";

const image1 = require("../../../assets/images/person-holding-barbell-841130.jpg");
const bImage = `url(${image1})`;

function MainPage() {
  return (
    <>
      <style type="text/css">
        {`
            .jumbotron-fluid {
              background-image: ${bImage};
              background-size: cover;
            }
            div.container {
              color:white;
            }
        `}
      </style>
      <Jumbotron fluid>
          <Container>
            <h1 className="display-4">CGM Gym</h1>
            <p className="lead">
              STAY IN, STAY FIT
              <br />
              WITH CGM LIVE
              <br />
              FREE FOR ALL MEMBER
            </p>
            <Button variant="primary">Learn more</Button>
          </Container>
        </Jumbotron>
      <Footer />
    </>
  );
}

export default MainPage;

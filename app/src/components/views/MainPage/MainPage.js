import React from "react";
import Footer from "./Footer";
import { withRouter } from "react-router-dom";

function LandingPage(props) {
  return (
    <>
      <main className="container-fluid">
        <div className="container">
          <h1 className="mt-5">Sticky footer with fixed navbar</h1>
          <p className="lead">
            Pin a footer to the bottom of the viewport in desktop browsers with
            this custom HTML and CSS. A fixed navbar has been added with{" "}
            <code>padding-top: 60px;</code> on the{" "}
            <code>main &gt; .container</code>.
          </p>
          <p>
            Back to{" "}
            <a href="/docs/4.4/examples/sticky-footer/">
              the default sticky footer
            </a>{" "}
            minus the navbar.
          </p>
        </div>
      </main>
      <Footer />
    </>
  );
}

export default withRouter(LandingPage);

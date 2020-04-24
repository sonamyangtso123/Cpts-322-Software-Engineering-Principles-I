const express = require("express");
const app = express();

const bodyParser = require("body-parser");
app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());

const cookieParser = require("cookie-parser");
app.use(cookieParser());

const config = require("./config/key");
const mongoose = require("mongoose");
mongoose
  .connect(config.mongoURI, {
    useNewUrlParser: true,
    useUnifiedTopology: true,
    useCreateIndex: true,
    useFindAndModify: false,
  })
  .then(() => console.log("MongoDB Connected..."))
  .catch((err) => console.log(err));

app.get("/", (req, res) => res.send("Hello World!"));

app.use("/api/users", require("./routes/users"))

const port = process.env.PORT || 3001;
app.listen(port, () =>
  console.log(`Example app listening at http://localhost:${port}`)
);


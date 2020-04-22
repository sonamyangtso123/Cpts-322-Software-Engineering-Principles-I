const express = require("express");
const app = express();
const port = 5000;
const bodyParser = require("body-parser");
const cookiePaser = require("cookie-parser");
const config = require("./config/key");
const { User } = require("./models/User");
const { auth } = require("./middleware/auth");

app.use(bodyParser.urlencoded({ extended: true }));
app.use(bodyParser.json());
app.use(cookiePaser());

// connect DB
const mongoose = require("mongoose");
mongoose
  .connect(config.mongoURI, {
    useNewUrlParser: true,
    useUnifiedTopology: true,
    useCreateIndex: true,
    useFindAndModify: false,
  })
  .then(() => console.log("MongoDB connected..."))
  .catch((err) => console.log(err));

app.get("/", (req, res) => res.send("HELLO, CGM GYM"));

app.post("/user/register", (req, res) => {
  // put user infomation into database when customer sign in
  const user = new User(req.body);
  user.save((err, user) => {
    if (err) return res.json({ success: false, err });
    console.log("signup:\t%s", user.email)
    return res.status(200).json({ success: true });
  });
});

app.post("/user/login", (req, res) => {
  // find request email in the database
  User.findOne({ email: req.body.email }, (err, user) => {
    if (!user) {
      return res.json({
        loginSuccess: false,
        message: "The email doesn't exist.",
      });
    }
    // if it found, check password correct
    user.comparePassword(req.body.password, (err, isMatch) => {
      if (!isMatch) {
        return res.json({
          loginSuccess: false,
          message: "Incorrect password.",
        });
      }
      // then, it generates token
      user.generateToken((err, user) => {
        if (err) {
          return res.status(400).send(err);
        }
        res.cookie("x_auth", user.token).status(200).json({
          loginSuccess: true,
          userId: user._id,
        });
        console.log("login:\t%s", user.email)
      });
    });
  });
});

app.get("/user/auth", auth, (req, res) => {
  // Authentication is ture at the moment
  res.status(200).json({
    _id: req.user._id,
    isAdmin: req.user.role === 0 ? true : false,
    isTrainer: req.user.role === 1 ? true : false,
    isMember: req.user.role === 2 ? true : false,
    isAuth: true,
    email: req.user.email,
    name: req.user.name,
    lastname: req.user.lastname,
    role: req.user.role,
    image: req.user.image,
  });
});

app.get("/user/logout", auth, (req, res) => {
  User.findOneAndUpdate({ _id: req.user._id }, { token: "" }, (err, user) => {
    if (err) {
      return res.json({
        success: false,
        err,
      });
    }
    console.log("logout:\t%s", user.email)
    return res.status(200).send({
      success: true,
    });
  });
});

app.listen(port, () =>
  console.log(`Example app listening at http://localhost:${port}`)
);

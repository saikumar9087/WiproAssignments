
require('dotenv').config();
console.log("Mailtrap User:", process.env.MAILTRAP_USER);
console.log("Mailtrap Pass:", process.env.MAILTRAP_PASS);
const nodemailer = require('nodemailer');



var transport = nodemailer.createTransport({
    host: "smtp.mailtrap.io",
    port: 2525,
    auth: {
        user: process.env.MAILTRAP_USER,
        pass: process.env.MAILTRAP_PASS
    }
});

message = {
   from: "sai90878114@gmail.com",
   to: "sai90878114@gmail.com",
   subject: "WiproTraining",
   text: "Hello SMTP Email"
}
transport.sendMail(message, function(err, info) {
   if (err) {
      console.log(err);
   } else {
   console.log(info);
   }
});
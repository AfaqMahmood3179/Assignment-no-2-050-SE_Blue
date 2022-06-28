function log() {

    var Username = document.getElementById("Username").value;
    var Password = document.getElementById("Password").value;
    if (Username == "Afaq" && Password == "Afaq3179") {

        window.open("http://127.0.0.1:5501/entry.html");
    } else {
        alert("Username or Passcode is incorrect");
    }
}
var http = require("http");
var log = require("./log.js");
var sayHello = require("./exportsDemo");

http
  .createServer(function (request, response) {
    console.log(request.url);
    if (request.url == "/admin") {
      response.writeHead(200, { "Content-Type": "text/html" });
      response.write(
        "<html><body><strong>Admin sayfası</strong></body></html>"
      );
    } else if (request.url == "/") {
      response.writeHead(200, { "Content-Type": "text/html" });
      response.write("<html><body><strong>Ana sayfa</strong></body></html>");
    } else if (request.url == "/customer") {
      response.writeHead(200, { "Content-Type": "application/json" });
      response.write(JSON.stringify({ name: "Engin", lastName: "Demiroğ" }));
    }
  })
  .listen(8080);

log.information("Sunucu yayına geçti");
console.log(sayHello());

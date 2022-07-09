var fs = require("fs");

fs.readFile("file.txt", "utf-8", function (hata, data) {
  if (hata) {
    throw hata;
  }
  console.log(data);
});

// fs.writeFile("file2.txt", "Derin Demiroğ", function (hata) {
//   if (hata) {
//     throw hata;
//   }
//   console.log("Yazıldı");
// });

// fs.appendFile("file2.txt", "Engin Demiroğ", function (hata) {
//   if (hata) {
//     throw hata;
//   }
//   console.log("Eklendi");
// });

fs.unlink("file2.txt", function (hata) {
  if (hata) {
    throw hata;
  }
  console.log("Silindi");
});

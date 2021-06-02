//MARKS:
//------
//var, let, const ->
//Değişken tanımlamada kullanılır.
//Js type (tip) güvenli değildir!!
//undefined gönderdiğimizde ben aslında yokum demiş olur
//ve default hali döner.

let sayi1 = 10;
sayi1 = "Ahmet Berkay Yılmaz";
let student = { id: 1, name: "Ahmet Berkay" };

//console.log(student);

function save(puan = 10, ogrenci) {
  console.log(ogrenci.name + " : " + puan);
}

//save(undefined, student);

let students = ["Engin Demiroğ", "Ahmet Berkay Yılmaz", "Mehmet Basrioğlu"];

//console.log(students);

let students2 = [
  student,
  { id: 1, name: "Berkay Yılmaz" },
  "Eskişehir",
  { city: "Ankara" },
];

//console.log(students2);

//MARKS:
//------
//rest geriye kalanlar demektir.
//c# da params karşılığı.
//java da varArgs karşılığı.
//spread ayrıştırmak anlamına gelir. Bir diziyi parametreyi
//virgül ile ayırmayı sağlar.

let showProducts = function (id, ...products) {
  console.log(id);
  console.log(products[0]);
};

//console.log(typeof showProducts)

//showProducts(10, ["Elma", "Armut", "Karpuz"])
let points = [1, 2, 3, 4, 50, 4, 60, 14];

console.log(...points);
console.log(Math.max(...points));

//MARKS:
//------
//... da ABC yi ayırır diğer ... da EFG yi ayrırır sonra
//birleştirip boşluk bırakarak sırayla getirir.

console.log(..."ABC", "D", ..."EFG", "H");

//Destructuring ->
//----------------
//Parçalamak anlamına gelir.
//Elimizdeki dizileri değişkenlere atamak.
//Kendi içinde destructuring yapımı line 74 örneğidir.
//Objede de yapılır.

let populations = [10000, 20000, 30000, [40000, 100000]];
let [small, medium, high, [veryHigh, maximum]] = populations;

console.log(small);
console.log(medium);
console.log(high);
console.log(veryHigh);
console.log(maximum);

function someFunction([small1], number) {
  console.log(small1);
}

someFunction(populations);

let category = { id: 1, name: "İçecek" };

console.log(category.id);
console.log(category["name"]);

let { id, name } = category;

console.log(id);
console.log(name);

//map() creates a new array for every element present in array
const number =[4,9,16,23,25]
let newArr = number.map(Math.sqrt);
console.log(newArr);
newArr=number.map((n)=>n*10);
console.log(newArr);
newArr=number.map((n)=>n%2==0);
console.log(newArr);
const persons=[
    {fname:"sachin",lname:"tendulkar"},
    {fname:"virat",lname:"kohli"},
    {fname:"rohith",lname:"sharma"},
];

let result = persons.map((item)=>
[item.fname,item.lname].join(" ")
);

console.log(result);
let flowers =["rose","lilly","jasmine"];
let r = flowers.map((f)=>{
    let m = f[0].toUpperCase()+f.slice(1,f.length);
    return m;
});
console.log(r);

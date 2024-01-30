// const fn=(args)=>expression
let Greet = (name) => "Hello " +name;
console.log(Greet("adithya"));
const Add =(a,b) => a+b;
console.log(Add(10,5));

let IsEven =(n) => n%2==0;
console.log(IsEven(2)?"Even":"Odd");
console.log(IsEven(3)?"Even":"Odd");

const Sum =(a) => 
{
    let result =0;
    for (let k of a)
        result=result+k;
    return result;
}

console.log(Sum([1,33,44.6,233,44,22,"adithya",3,33,44]));
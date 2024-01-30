let a=[12,423,33,22,13,44];
let b=[1,2,...a];
console.log(b);
function sum(...a)
{
    let r=0;
    for(let k of a)
        r=r+k;
    console.log("sum :"+r);
}

sum(12,33,44,3);
sum(12,4,5,56,6,6,6,6);
sum(6464,1231,2);
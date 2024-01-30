let no=[12,33,42,3,223,312,33,323,222];
no.forEach((i)=>console.log(i));
no.forEach((i)=>console.log(i*i));
no.forEach((i)=>{
    if(i%2==0)
    console.clear();
});

let k=no.find((i)=>i>50);
console.log(k);
k=no.find((i)=>i%2!=0);
console.log(k);

let a = no.filter((i)=>i%2==0);
console.log(a);
a=no.filter((i)=>i>80);
console.log(a);
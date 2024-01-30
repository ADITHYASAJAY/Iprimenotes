function fn(f1,f2)
{
    console.log(f1());
    console.log(f2());
}
fn(
    ()=>"Function 1!!",
    ()=>"function 2!!"
);

setTimeout(function()
{
    console.log("anoymous function")
},5000);

setTimeout(()=>console.log("arrow function"),5000);
function fn(f1,f2)
{
    console.log(f1());
    console.log(f2());
}
function a()
{
    return " Hello Dotnet Learners!!!";
}
function b()
{
    return " Happy moringn every day!!!";
}
fn(a,b);

fn(
    function()
    {
        return "Hi";
    },
    function()
    {
        return "Hello";
    }
)
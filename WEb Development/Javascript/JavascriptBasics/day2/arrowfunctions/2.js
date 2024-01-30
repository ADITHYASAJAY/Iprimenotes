let students =[
    { Id:343,Name:"Rohan",Age:12},
    { Id:333,Name:"Akash",Age:12},
    { Id:353,Name:"Leo",Age:12},
    { Id:363,Name:"Aromal",Age:12},
    { Id:373,Name:"Vishnu",Age:12},
    { Id:383,Name:"Nithin",Age:12},
    { Id:393,Name:"Kiran",Age:12},
];

let GetStudents=()=> students;
for(let s of GetStudents() )
{
    console.log(`ID:${s.Id} Name:${s.Name} Age:${s.Age} `);
} 

let GetStudentById = (id)=>
{
    for(let s of GetStudents() )
    {
        if(s.Id==id)
        return s;
    }
    return null;
};
let s=GetStudentById(333);
if(s!=null)
{
    console.log(`ID:${s.Id} Name:${s.Name} Age:${s.Age} `);
}
else{
    console.log("Invalid Id");
}

 
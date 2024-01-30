namespace HandsOnProgramFile
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);//using builder instance we configure services to the profect
            var app = builder.Build();//using app instance we cunfigure the milddlewares 

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}

Please find the GitHub repository URL below where I’ve uploaded the source code:


🔗 GitHub: https://github.com/priteshmore/SocialAssistInfoSystem.git
📁 Branch: master

The repository contains the Visual Studio solution named SocialAssistInfoSystem.

🔧 Database Connection Setup

Before running the project, please update the database connection string in the appsettings.json file as shown below:

"ConnectionStrings": {
  "DefaultConnection": "Server=localhost\\SQLEXPRESS;Database=SAIS_DB;User Id=sam;Password=Abc@123;TrustServerCertificate=True;"
}


🧪 Running Migrations
Once the connection string is set, please follow the steps below to apply the EF Core migrations:

Open the solution in Visual Studio.

Navigate to the terminal within the SocialAssistInfoSystem server project directory. Example: C:\Users\prite\source\Repos\SocialAssistInfoSystem\SocialAssistInfoSystem\SocialAssistInfoSystem

Execute the following commands:

dotnet ef migrations add InitialCreate
dotnet ef database update

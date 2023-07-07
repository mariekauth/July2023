# July2023
# Simple WebAPI
Language: C#.Net
Targets: net6


dotnet new webapi -n "Sample" -o ./Sample -lang "C#" -f "net6.0"
dotnet new xunit -n "SampleTest" -o ./SampleTest -lang "C#"
dotnet add .\SampleTest reference .\Sample\Sample.csproj
dotnet dev-certs https --trust

cd Sample
dotnet run

Go to: https://localhost:7278/swagger

Stop Program: [Ctrl][C]

cd ..\SampleTest
dotnet add package Microsoft.Extensions.Logging
dotnet test
dotnet test --collect "XPlat Code Coverage"
reportgenerator -reports:".\TestResults\{guid}\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html

reportgenerator -reports:".\TestResults\e827d780-64c6-42bf-9e5f-bc0ba3360bde\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html
reportgenerator -reports:".\TestResults\de88c3d4-49df-406f-9086-432ed43f2fd3\coverage.cobertura.xml" -targetdir:"coveragereport" -reporttypes:Html

7/6/2023 
- DotNet 6.0 webapi
- DotNet 7.0 xunit
- Dependency Injection
- TDD (Test Driven Development)
- Code Coverage (60%)

# TODO: 
Understand and implement builder pattern
Once implemented, add the unit tests for the Builder, increasing Code Coverage

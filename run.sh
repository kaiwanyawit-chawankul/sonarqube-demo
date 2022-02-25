dotnet sonarscanner begin /k:"SonarDemo" /d:sonar.host.url="http://192.168.64.2:9000"  /d:sonar.login="4d49fa43188f4be2bb770c2b59223402aba05588" /d:sonar.cs.opencover.reportsPaths=\"./test/coveragereport/result.opencover.xml\" /d:sonar.coverage.exclusions="**Test*.cs"

dotnet build SonarDemo.sln 
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=\"opencover\" /p:CoverletOutput="./coveragereport/result"

dotnet sonarscanner end /d:sonar.login="4d49fa43188f4be2bb770c2b59223402aba05588"
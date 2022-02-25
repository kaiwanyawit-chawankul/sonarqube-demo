# TODO


## Create a sonarqube server

docker run -d --name sonarqube -p 9000:9000 sonarqube:9.3-community

http://docker.local:9000

## Login with admin/admin and change a password
![Login image](docs/login.png)

## Create a project(this will need for uploading a codecoverage)
![Create a project image](docs/create-a-project.png)

## Copy a token(this will need for uploading a codecoverage)
![Create a token image](docs/create-a-token.png)

## Download tool for uploading a codecoverage
![Setup a project image](docs/setup-a-project.png)

dotnet tool install --global dotnet-sonarscanner

## Update the run.sh
![Update the run.sh image](docs/change-setting.png)

![See it in action image](docs/what-you-found.png)

## Open the project
http://docker.local:9000/dashboard?id=SonarDemo
   pipeline{
    agent any
    stages{
        stage("Git pull"){
            steps{
                 git branch: 'main',url: 'https://github.com/TienMinh1998/jenkins.git'
            }
        }
         stage("Build"){
            steps{
                 echo 'Start build'
                 sh '''docker ps'''
                 sh '''dotnet --version'''
                 sh '''dotnet build'''
                 sh '''docker build -t jenkinsdemo .'''
                 sh '''docker run -it -d -p 8181:80 --name demo -e ASPNETCORE_ENVIRONMENT=Development jenkinsdemo'''
                 echo 'MT007'
                 echo 'Nguyen Viet Minh Tien 1'
            }
        }
         stage("Triển Khai"){
            steps{
                 sh '''docker ps'''
                 sh '''docker images'''
                 sh '''docker ps -a'''
            }
        }
    }
}
   pipeline{
    agent any
    stages{
        stage("Git pull"){
            steps{
                 git branch: 'main',url: 'https://github.com/TienMinh1998/jenkins.git'
            }
        }
         stage("Stop,Remove Container, Images and Build"){
            steps{
                 echo 'Start build'
                 sh '''docker ps'''
                 sh '''dotnet --version'''
                 sh '''dotnet build'''
                 sh '''docker stop demo'''
                 sh '''docker rm -f demo'''
                 sh '''docker rmi jenkinsdemo'''
                 sh '''docker build -t jenkinsdemo .'''
            }
        },
         stage("Remove Old Version"){
            steps{
                  sh '''docker run -it -d -p 8181:80 --name demo -e ASPNETCORE_ENVIRONMENT=Development jenkinsdemo'''
            }
        }
         stage("implementation"){
            steps{
                 sh '''docker ps'''
                 sh '''docker images'''
                 sh '''docker ps -a'''
            }
        }
    }
}
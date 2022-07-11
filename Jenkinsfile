pipeline {
    agent none
     environment {
                   HOME = '/tmp'
                 } 
    stages {
        stage('Dockerize dotnet SDK 3.1') {
            agent {
                docker { image 'mcr.microsoft.com/dotnet/sdk:3.1' }
            }
            steps {               
               sh 'dotnet build /var/jenkins_home/workspace/DotNetBuild/FlexyBox.sln -c Release -o /var/jenkins_home/workspace/DotNetBuild/out'
            }
        }        
    }
}
pipeline {
    agent none
    stages {
        stage('Dockerize dotnet SDK 3.1') {
            agent {
                docker { image 'mcr.microsoft.com/dotnet/sdk:3.1' }
            }
            steps {
                sh 'cd /var/jenkins_home/workspace/TestMultiBranch_master'
                sh 'dotnet build "FlexyBox.sln" -c Release -o flexyout'
            }
        }        
    }
}

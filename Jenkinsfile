pipeline {
    agent none
     environment {
                   HOME = '/tmp'
                 } 
    stages {
        stage('Dockerize dotnet SDK 3.1') {            
            steps {               
               sh 'dotnet --version'
            }
        }        
    }
}

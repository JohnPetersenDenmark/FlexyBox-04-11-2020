pipeline {    
   agent 
              { dockerfile true }
         
    stages {
        stage('Dockerize dotnet SDK 3.1') {           
            steps {               
               sh 'dotnet build /var/jenkins_home/workspace/DotNetBuildInDocker_master/FlexyBox.sln -c Release -o /var/jenkins_home/workspace/TestMultiBranch_master/out'
            }
        }        
    }
}
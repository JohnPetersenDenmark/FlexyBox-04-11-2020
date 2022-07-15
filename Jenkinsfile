pipeline {
    agent none
     environment {
                   HOME = '/tmp'
                 } 
    stages {
          
            
            stage('Test Dockerize dotnet SDK 3.1')
            {

              agent {
                        docker { image 'mcr.microsoft.com/dotnet/sdk:3.1' }
                    }
            steps {    
            
               
               sh 'dotnet test /var/jenkins_home/workspace/DotNetBuild/UnitTestFlexyBox/UnitTestFlexyBox.csproj --no-build'
            }


         
            }

         
                
    }
}
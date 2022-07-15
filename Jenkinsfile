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
            
               sh 'cd /var/jenkins_home/workspace/DotNetBuild/UnitTests/Domain/bin/Release/netcoreapp2.1 '
               sh 'dotnet test /var/jenkins_home/workspace/DotNetBuild/UnitTests/Domain/bin/Release/netcoreapp2.1/NUnit3.TestAdapter.dll /var/jenkins_home/workspace/DotNetBuild/FlexyBox.sln --no-build'
            }


         
            }

         
                
    }
}
pipeline {     
     environment {
                   HOME = '/tmp'
                 } 

    agent {
            docker { image 'mcr.microsoft.com/dotnet/sdk:3.1' 
          }
    stages {                      
                stage('Build project FlexyBox')
                    {            
                        steps 
                                {                               
                                    sh 'dotnet test /var/jenkins_home/workspace/DotNetBuild/UnitTestFlexyBox/UnitTestFlexyBox.csproj --no-build --logger trx'
                                }
                     }

                stage('Unit test on project FlexyBox')
                   {            
                    steps 
                                {                               
                                    sh 'dotnet test /var/jenkins_home/workspace/DotNetBuild/UnitTestFlexyBox/UnitTestFlexyBox.csproj --no-build --logger trx'
                                }
                   }

         
            }                 
    }
}
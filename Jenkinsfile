pipeline {     
     environment {
                   HOME = '/tmp'
                 } 

    agent {
            docker { image 'mcr.microsoft.com/dotnet/sdk:3.1'}
          }

    stages {                      
                stage('Build project FlexyBox')
                    {            
                        steps 
                                {                               
                                    sh 'dotnet build /var/jenkins_home/workspace/DotNetBuild/FlexyBox.sln -c Release -o /var/jenkins_home/workspace/DotNetBuild/out --no-restore'
                                }
                     }

                                
    }
}
pipeline {
    agent none
     environment {
                   HOME = '/tmp'
                 } 
    stages {
            stage('Build Dockerize dotnet SDK 3.1')
            {
                agent {
                        docker { image 'mcr.microsoft.com/dotnet/sdk:3.1'}
                      }
            
                steps {               
                        sh 'dotnet build /var/jenkins_home/workspace/DotNetBuild/FlexyBox.sln -c Release -o /var/jenkins_home/workspace/DotNetBuild/out'
                      }
            }


            
            stage('Test Dockerize dotnet SDK 3.1')
            {
                agent {
                       docker { image 'mcr.microsoft.com/dotnet/sdk:3.1'}
                  }
            
                steps {               
                    sh 'dotnet test  /var/jenkins_home/workspace/DotNetBuild/FlexyBox.sln'
                  }
            }

            stage('Publish Dockerize dotnet SDK 3.1')
            {
                agent {
                        docker { image 'mcr.microsoft.com/dotnet/sdk:3.1'}
                      }
            
            steps {               
                    sh 'dotnet publish /var/jenkins_home/workspace/DotNetBuild/FlexyBox.sln -c Release -o /var/jenkins_home/workspace/DotNetBuild/out'
                  }
            }


                
    }
}
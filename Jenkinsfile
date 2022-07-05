pipeline {
    stages {
        stage('Initialize') {
                def dockerHome = tool 'MyjenkinsDocker'
                env.PATH = "${dockerHome}/bin:${env.PATH}"
            }
        stage('Build') {
            steps {
             agent {       
                    docker { image 'node:16.13.1-alpine' }
                    }
                echo 'Building..'
            }
        }
        stage('Test') {
            steps {
                echo 'Testing..'
            }
        }
        stage('Deploy') {
            steps {
                echo 'Deploying....'
            }
        }  
    } 
}
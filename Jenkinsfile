pipeline {
stage('Initialize'){
        def dockerHome = tool 'MyjenkinsDocker'
        env.PATH = "${dockerHome}/bin:${env.PATH}"
    }
    agent {       
        docker { image 'node:16.13.1-alpine' }
    }

    stages {
        stage('Build') {
            steps {
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
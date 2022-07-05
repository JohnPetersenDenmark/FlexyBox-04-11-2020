pipeline {
    stages {
            agent {
                    docker { image 'node:16.13.1-alpine' }
                    }
       stage('Initialize'){
         steps {
                echo 'Initializing..'
            }       
        }


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
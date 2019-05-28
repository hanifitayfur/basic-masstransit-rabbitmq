pipeline {
  agent any
  stages {
    stage('Build') {
      steps {
        powershell 'echo \'Build\''
      }
    }
    stage('Sonar') {
      steps {
        echo 'Sonar'
      }
    }
    stage('Test') {
      steps {
        echo 'Test'
      }
    }
    stage('Quality Gate') {
      steps {
        echo 'Gate'
      }
    }
    stage('Deploy') {
      steps {
        echo 'Deploy'
      }
    }
  }
}
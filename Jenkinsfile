pipeline {
     agent any
     stages {
        stage("Build") {
            steps {
				sh "sudo -i"
				sh "cd ${WORKSPACE}/FE/izprj-app"
				sh "npm install"
				sh "npm run build"
            }
        }
		stage("Deploy") {
			steps {
				sh "rm -rf /var/www/jenkins-react-app"
				sh "cp -r ${WORKSPACE}/FE/izprj-app/build/ /var/www/jenkins-react-app/"
			}
		}
    }
}


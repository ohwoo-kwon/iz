pipeline {
     agent any
     stages {
        stage("Build") {
            steps {
				sh script:'''
					sudo -i
					cd ${WORKSPACE}/FE/izprj-app
					npm install
					npm run build
				'''
            }
        }
		stage("Deploy") {
			steps {
				sh "sudo rm -rf /var/www/jenkins-react-app"
				sh "sudo cp -r ${WORKSPACE}/FE/izprj-app/build/ /var/www/jenkins-react-app/"
			}
		}
    }
}


pipeline {
     agent any
     stages {
        stage("Build") {
            steps {
				sh script:'''
					sudo -i
					cd ${WORKSPACE}/FE/iz_project
					npm install
					npm run build
				'''
            }
        }
		stage("Deploy") {
			steps {
				sh "sudo rm -rf /var/www/jenkins-react-app"
				sh "sudo cp -r ${WORKSPACE}/FE/iz_project/build/ /var/www/jenkins-react-app/"
			}
		}
    }
}


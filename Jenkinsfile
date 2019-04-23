pipeline
  {
  agent any
stages{

    stage('Build Solution')
	{
		steps
		{
		 sh 'dotnet clean'
		 sh 'dotnet build'
		}
	}
	
	stage('Unit Test')
	{
		steps
		{
         sh 'dotnet test Equinox.Domain.Tests/Equinox.Domain.Tests.csproj'
		}
	}
	stage ('SonarQube Analysis and Quality Gates')
      	{
         steps
		 {
			 withSonarQubeEnv('sonarqube')
			 {
			  sh '''
			  dotnet /home/mukesh/Desktop/sonar-scanner-msbuild-4.6.0.1930-netcoreapp2.0/SonarScanner.MSBuild.dll begin /k:"Equinox" /v:1.1
			  dotnet build Equinox.sln
			  dotnet /home/mukesh/Desktop/sonar-scanner-msbuild-4.6.0.1930-netcoreapp2.0/SonarScanner.MSBuild.dll end
			  '''
			 } 
			 sleep(10)
			 script
			  {
              def qg = waitForQualityGate()
              if (qg.status != 'OK') {
                  //error "Pipeline aborted due to quality gate failure: ${qg.status}"
				  currentBuild.result = "FAILURE"
              }
              }
		 }	
      	}	
	stage('Application Deploy')
	{
		steps
		{
         sh '''    '''
		}
	}
		
	
      }
  }

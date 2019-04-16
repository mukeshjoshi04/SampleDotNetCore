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
         sh 'dotnet test Equinox.Domain.Tests\Equinox.Domain.Tests.csproj"
		}
	}
	
      }
  }

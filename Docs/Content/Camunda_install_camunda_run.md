# Instalacja Camunda8 - Run: 

Camunda na potrzeby lokalnego developmentu możę być hostowana jako CamundaRun - czyli proces(y) odpalane z wykorzystaniem JDK.


## Prerekwizyty

## Java Development Kit:

Zainstalować Java SE Development Kit dla Windows: [click](https://www.oracle.com/java/technologies/downloads/?er=221886#jdk23-windows)

Uwaga: na moment pisania tego readme Camunda8 __nie działa__ z najnowszą wersja JDK (JDK 24):   
Problem z uruchomieniem ElasticSearch (Wpis w logu: ERROR: Elasticsearch 8.17.x cannot run with JDK 24+, but you are running JDK 24+36-3646, with exit code 64)
Sugerowana wersja: JDK 23

Z poziomu terminala (np. powershell) potwierdzić, że instalacja JDK przebiegła prawidłowo:  
![alt text](Images/javaversion.png)

Zdefiniować zmienne środowiskowe - z poziomu system variables dodać wpis dla JAVA_HOME:
 
![alt text](java_env_variable.png)

Dodatkowo - w PATH uwzględnić JAVA_HOME

![alt text](java_home.png)


## Camunda Run:
Ściągnij Camunda Run wybierając najnowszą wersję [click](https://github.com/camunda/camunda/releases/tag/c8run-8.8/)

Rozpakuj archiwum gdzieś na dysku

[Powrót](../Camunda_ReadMe.md)
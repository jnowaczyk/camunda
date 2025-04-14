# Camunda 8 - głowne componenty (Docker compose):

### Zeebe
Skalowalny silnik przepływu pracy i decyzji o natywnej architekturze chmurowej. Jest to centralny element Camundy 8, odpowiedzialny za wykonywanie procesów BPMN i decyzji DMN. Zeebe charakteryzuje się wysoką wydajnością i odpornością na awarie.
Docker service: zebee
Port: 26500


### Operate 
Narzędzie do monitorowania, zarządzania i rozwiązywania problemów związanych z działającymi/wykonanymi instancjami procesów w Zeebe. Umożliwia wgląd w aktualny stan procesów, identyfikowanie błędów i podejmowanie działań naprawczych.
Docker service name: operate
Depends on: Zeebe, Elasticsearch

### Tasklist
What it is: User task interface.
Role: Lets users claim and complete user tasks from processes.
Docker service name: tasklist
Depends on: Zeebe, Elasticsearch

### Connectors
Gotowe, konfigurowalne integracje z różnymi systemami zewnętrznymi (np. bazy danych, systemy CRM, API REST). Ułatwiają łączenie procesów z innymi aplikacjami bez konieczności pisania dużej ilości kodu. Dodają feature takie jak API, wysyłka maily etc.
Docker service name: connectors



Tasklist: Podobnie jak w Camundzie 7, jest to aplikacja dla użytkowników do pracy z zadaniami ludzkimi. W Camundzie 8 jest zintegrowana z Zeebe.


Optimize: (Podobnie jak w Camundzie 7) Narzędzie do analizy danych procesowych z Zeebe, dostarczające wgląd w wydajność procesów i możliwości ich ulepszenia.





Desktop Modeler: Narzędzie desktopowe do modelowania procesów BPMN, decyzji DMN i formularzy.
Web Modeler: (Opcjonalny, część SaaS) Narzędzie webowe do współpracy przy modelowaniu procesów.
Console: (Część SaaS) Centralne miejsce do zarządzania użytkownikami, uprawnieniami i konfiguracją w środowisku Camundy 8.
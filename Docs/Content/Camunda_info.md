# Czym jest Camunda?

**Camunda** to platforma do zarządzania procesami biznesowymi (BPM - *Business Process Management*), która pozwala modelować, automatyzować, monitorować i optymalizować procesy. Wspiera standardy takie jak:

- **BPMN** – Business Process Model and Notation (modelowanie procesów)
- **CMMN** – Case Management Model and Notation (zarządzanie przypadkami)
- **DMN** – Decision Model and Notation (reguły decyzyjne)

---

## Do czego służy Camunda?

Camunda umożliwia:

- Graficzne modelowanie procesów (BPMN)
- Automatyzację procesów biznesowych
- Integrację z zewnętrznymi systemami (np. REST, gRPC, Kafka)
- Obsługę reguł decyzyjnych (DMN)
- Monitorowanie stanu i wydajności procesów

---

## Przykładowe zastosowania

| Branża         | Zastosowanie                                 |
|----------------|----------------------------------------------|
| **Bankowość**  | Wnioski kredytowe, AML, onboarding klienta   |
| **Ubezpieczenia** | Likwidacja szkód, ocena ryzyka             |
| **E-commerce** | Obsługa zamówień, reklamacji, logistyka      |
| **Logistyka**  | Śledzenie dostaw, zarządzanie przesyłkami    |
| **Administracja** | Obieg dokumentów, cyfrowa obsługa spraw   |
| **IT**         | Orkiestracja mikroserwisów, workflow devops  |

---

## Jak działa Camunda?

**Podstawowe komponenty Camundy:**

### 1. Modeler  
Desktopowa aplikacja do tworzenia modeli BPMN i DMN.

### 2. Silnik (Engine)  
Wykonuje procesy – analizuje modele i zarządza przepływem.

### 3. WebApps (Camunda 7) lub Operate/Tasklist (Camunda 8)  
- **Operate**: wizualizacja przebiegu procesów  
- **Tasklist**: interfejs użytkownika do zadań manualnych  
- **Cockpit (Camunda 7)**: narzędzie administracyjne

---

## Camunda 7 vs Camunda 8

| Cecha                  | Camunda 7               | Camunda 8                   |
|------------------------|-------------------------|-----------------------------|
| Architektura           | Monolityczna (Java)     | Mikrousługowa (Cloud-native)|
| Silnik wykonawczy      | Java BPMN Engine        | Zeebe (event-driven, gRPC)  |
| Przechowywanie danych  | Relacyjne bazy danych   | Elasticsearch               |
| Interfejs webowy       | Cockpit, Tasklist       | Operate, Tasklist, Optimize |
| Komunikacja            | REST API                | gRPC                        |

[Idź do spisu treści](../Camunda_ReadMe.md)
# HRMS - Backend (Human Resource Management System)

Questo progetto rappresenta il backend di un sistema semplificato di gestione delle risorse umane (HRMS). L'applicazione consente di gestire dipendenti, progetti e il tracciamento delle ore lavorate, con l'obiettivo di fornire una base solida per applicazioni aziendali moderne.

## 🔧 Tecnologie Utilizzate

- **ASP.NET Core Web API**
- **Entity Framework Core**
- **PostgreSQL** (database relazionale)
- **JWT (JSON Web Token)** per autenticazione
- **Swagger / Swashbuckle** per la documentazione interattiva delle API
- **AutoMapper** per la mappatura tra entità e DTO
- **Ocelot** (opzionale, per API Gateway)
- **xUnit / Moq** per i test unitari

## 🧠 Funzionalità Principali

### ✅ Gestione Dipendenti
- Creazione, modifica e visualizzazione dei dipendenti.
- Attributi: Nome, Cognome, Data di assunzione, Dipartimento, Ruolo, Salario, ecc.

### ✅ Gestione Progetti
- Creazione e gestione dei progetti.
- Attributi: Nome, Descrizione, Data Inizio/Fine, Stato, Budget, ecc.

### ✅ Assegnazione ai Progetti
- Associazione di dipendenti a progetti.
- Percentuale di tempo assegnata per ciascun progetto.

### ✅ Monitoraggio Ore
- Tracciamento delle ore lavorate da ciascun dipendente su ciascun progetto.

# SMS Service Project

## Description

This project implements an SMS sending service using a .NET Core Web API. The service selects different SMS vendors based on the country code of the phone number and ensures that the message content and length meet specific vendor requirements.

## Features

- REST API to send SMS messages.
- Vendor selection based on country code.
- Special handling for Greek and Cypriot numbers.
- Fluent Validation for request validation.
- Strategy Pattern for vendor-specific logic.
- Repository Pattern for database operations.
- Entity Framework Core for data persistence.

## Getting Started

### Prerequisites

- .NET Core 6.0 or later.
- SQL Server (or any compatible SQL database).

### Installation

1. Clone the repository:
   ```bash
   git clone [repository URL]
   
2. In the Sql Server run the following command
    CREATE DATABASE SmsServiceDb

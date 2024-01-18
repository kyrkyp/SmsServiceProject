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
   
2. In the Sql Server run the following command :
   ```bash
    CREATE DATABASE SmsServiceDb

## Architecture
This project follows Clean Architecture principles with a focus on separation of concerns and modularity.

1. Controllers: Handle incoming HTTP requests and responses.
2. Services: Contain business logic.
3. Repositories: Encapsulate data access and persistence logic.
4. Models: Represent data entities and DTOs.
5. Vendor Strategies: Implement vendor-specific SMS sending logic.

## Usage
Send a POST request to /api/sms with the following JSON payload:
   ```bash
      {
     "phoneNumber": "+[CountryCode][PhoneNumber]",
     "message": "Your message here"
   }

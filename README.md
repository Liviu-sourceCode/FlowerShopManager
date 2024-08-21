# FlowerShopManager

## Overview

**FlowerShopManager** is a console application developed in C# that simulates the sales and inventory management of a flower shop. The application focuses on utilizing Object-Oriented Programming (OOP) principles to manage flower sales, bouquet compositions, and inventory.

## Features

- **Bouquet Sales Management**: Manages three types of bouquets—Big, Medium, and Small—each with a specific composition of flowers:
  - **Big Bouquet**: 9 Roses, 10 Gladiolus, 3 Hydrangeas
  - **Medium Bouquet**: 6 Roses, 5 Gladiolus
  - **Small Bouquet**: 5 Roses
- **Individual Flower Sales**: Tracks sales of Roses, Gladiolus, and Hydrangeas.
- **Revenue Calculation**: Computes the total revenue from both bouquets and individual flower sales, including assembly costs.
- **Inventory Management**: Monitors the total usage of flowers for both bouquets and individual sales.

## Object-Oriented Design

The application demonstrates key OOP concepts:

- **Classes and Inheritance**:
  - `Flower` is an abstract base class with derived classes such as `Rose`, `Gladiolus`, and `Hydrangea`, each implementing specific properties.
  - `Bouquet` is an abstract base class, with derived classes `BigBouquet`, `MediumBouquet`, and `SmallBouquet`, each defining different bouquet compositions and prices.

- **Encapsulation**:
  - Flower prices and bouquet compositions are encapsulated within their respective classes, promoting modularity and reusability.

- **Abstraction**:
  - The application abstracts the details of flower and bouquet management, allowing high-level operations to be performed without needing to understand the underlying complexities.

- **Polymorphism**:
  - Polymorphic behavior is demonstrated through the use of base class references to manage different types of flowers and bouquets, enabling flexibility and extendibility.

## Customization

- **Adjust Flower Prices**: Modify the `flowerPrices` dictionary in the `FlowerShop` class to update prices.
- **Modify Bouquet Compositions**: Change the flower quantities in the bouquet classes (`BigBouquet`, `MediumBouquet`, `SmallBouquet`) if bouquet compositions need to be altered.

## Docker

Docker is a platform that enables developers to package applications and their dependencies into a standardized unit called a container. Containers are lightweight, portable, and ensure that the application runs consistently across different environments.

### Usage with Docker

To build and run the FlowerShopManager application using Docker, follow these steps:

1. **Clone the Repository**: Clone the repository to your local machine using Git:
   ```sh
   git clone https://github.com/Liviu-SourceCode/FlowerShopManager

2. **Ensure Docker is Installed**: Make sure Docker is installed on your machine. You can download it from [Docker's official website](https://www.docker.com/products/docker-desktop).

3. **Build the Docker Image**: Use the provided Dockerfile to build the Docker image for the FlowerShopManager application. Run the following command in the directory containing the Dockerfile:
   ```sh
   docker build -t flowershopmanager .

 4. **Run the Docker Container**: After building the image, run the application in a Docker container:
   ```sh
   docker run --rm -it flowershopmanager


# Event-Driven Development Example

This repository demonstrates a basic example of event-driven development in C#. The project uses events and delegates to handle the process of placing an order and notifying subscribers about the order details.

## Features
- Implements an event-driven architecture to decouple components.
- Uses a custom event data model (`OrderPlacedEntity`) to encapsulate order details.
- Demonstrates how to declare, subscribe to, and handle events in C#.
- Includes a sample handler (`OrderPlacedHandler`) that processes the event and outputs the order details to the console.

## Code Overview

### Program Flow
1. An `OrderService` class is responsible for placing an order.
2. When an order is placed, the `OrderPlaced` event is raised with the details of the order.
3. A `OrderPlacedHandler` class subscribes to this event and processes the order, logging its details to the console.

### Event Flow
- `OrderService.PlaceOrder` method raises the `OrderPlaced` event.
- The `OrderPlacedHandler` listens to the event and executes its `Handle` method.

## Key Classes

### `OrderService`
Handles the order placement logic and raises the `OrderPlaced` event.

**Methods:**
- `PlaceOrder(int orderId, decimal orderTotal)`: Creates an order and raises the `OrderPlaced` event.

**Event:**
- `OrderPlaced`: An event triggered when an order is successfully placed.

---

### `OrderPlacedEntity`
Represents the event data passed to the subscribers of the `OrderPlaced` event.

**Properties:**
- `OrderId`: Unique identifier for the order.
- `CustomerEntity`: Contains customer information (name and email).
- `OrderTotal`: Total cost of the order.
- `TimeStamp`: Date and time when the order was placed.

---

### `CustomerEntity`
Holds customer details for an order.

**Properties:**
- `Name`: Customer's name.
- `Email`: Customer's email address.

---

### `OrderPlacedHandler`
A sample subscriber class that listens to the `OrderPlaced` event and processes the event data.

**Methods:**
- `Handle(OrderPlacedEntity orderEvent)`: Logs order details to the console.

---

## Usage
To run the project:

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/event-driven-example.git

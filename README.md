## Mediator pattern

The Mediator design pattern is a behavioral design pattern. The Mediator design pattern is used in situations where there is a lot of communication and dependency between classes to
reduce these dependencies. In this design pattern, communication takes place through a single channel and classes know what to communicate for, not how to communicate. This pattern
reduces the interdependency of objects and makes the system more organized. The basic idea is that objects use a middleware to communicate with each other. This middleware manages the
functions that objects need to do together. Thus, objects work without direct reference to each other.


## CQRS (Command Query Responsibility Segregation) pattern

CQRS is a design pattern where applications manage writing and reading through different objects. It is based on the principle of separation of Command and Query responsibilities.

Command : It is responsible for writing operations to the database, such as updating and deleting existing data or inserting new data: INSERT, DELETE, UPDATE.

Query : Used to list and read existing data. It is responsible for reading from the database: SELECT.

CQRS basically provides separation of read and write operations and improves performance. Managing read and write operations through different objects makes the project more modular
and allows these operations to remain independent. As the project grows, you can control read and write operations on different databases and in case of a database crash, these two
operations are not affected by each other. The user can continue reading data even if an error occurs in the write operation, and vice versa. In addition, complex domain logic can
be generated separately for these two operations. It also simplifies the complex object mapping, so that for each operation we can easily present the user with only the information
he needs.

In the CQRS design pattern, Queries return a data, Command objects return NoContent, only the Status Code of the operation can be retrieved if needed.

## MediatR library

MediatR is a library used when developing on the .NET platform. This library is built on the Mediator design pattern and is used for managing and processing messages in software applications.

MediatR helps to write more maintainable and editable code by making the layers and components of ap``plications independent of each other. MediatR is especially powerful and useful when
used with the CQRS (Command Query Responsibility Segregation) pattern. In this way, the separate handling of commands and queries within the application makes the application more scalable
and better manageable.

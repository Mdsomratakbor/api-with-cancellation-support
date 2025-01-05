Here’s a **README.md** file for your repository, focusing on your **TODO API with Cancellation Token support**:

```markdown
# TODO API with Cancellation Token Support

A high-performance, scalable **TODO API** built with **.NET Core** and **gRPC**. This project demonstrates efficient request handling using **CancellationToken** for asynchronous operations, allowing graceful cancellation of long-running tasks. The API implements standard CRUD operations for managing TODO items with enhanced cancellation support.

## Features

- **CRUD Operations**: Create, Read, Update, and Delete TODO items.
- **Cancellation Token Support**: Supports graceful cancellation of long-running operations.
- **Scalability**: Designed to handle growing data and manage asynchronous requests efficiently.
- **Logging**: Console logging for request lifecycle tracking.
- **Asynchronous Programming**: Built using `async/await` for better performance and responsiveness.

## Endpoints

### 1. Get All TODO Items (Without Cancellation Token)
- **URL**: `/api/todoitem/GetAllWithoutCancellationToken`
- **Method**: `GET`
- **Description**: Fetches all TODO items without cancellation support. Useful for testing basic CRUD functionality.
  
#### Example Request:
```bash
GET http://localhost:5000/api/todoitem/GetAllWithoutCancellationToken
```

### 2. Get All TODO Items (With Cancellation Token)
- **URL**: `/api/todoitem`
- **Method**: `GET`
- **Description**: Fetches all TODO items with cancellation support.

#### Example Request:
```bash
GET http://localhost:5000/api/todoitem
```

### 3. Get a TODO Item by ID
- **URL**: `/api/todoitem/{id}`
- **Method**: `GET`
- **Description**: Retrieves a specific TODO item by its unique ID.

#### Example Request:
```bash
GET http://localhost:5000/api/todoitem/1
```

### 4. Create a New TODO Item
- **URL**: `/api/todoitem`
- **Method**: `POST`
- **Description**: Creates a new TODO item.

#### Example Request:
```bash
POST http://localhost:5000/api/todoitem
Content-Type: application/json
{
  "title": "New Task",
  "isCompleted": false
}
```

### 5. Update an Existing TODO Item
- **URL**: `/api/todoitem/{id}`
- **Method**: `PUT`
- **Description**: Updates an existing TODO item by its ID.

#### Example Request:
```bash
PUT http://localhost:5000/api/todoitem/1
Content-Type: application/json
{
  "id": 1,
  "title": "Updated Task",
  "isCompleted": true
}
```

### 6. Delete a TODO Item
- **URL**: `/api/todoitem/{id}`
- **Method**: `DELETE`
- **Description**: Deletes a specific TODO item by its ID.

#### Example Request:
```bash
DELETE http://localhost:5000/api/todoitem/1
```

## Project Setup

### Prerequisites

- **.NET Core 5.0+**
- **Visual Studio** or any preferred code editor.
- **Postman** or any HTTP client for testing endpoints.

### Steps to Run Locally

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/todo-api-with-cancellation-support.git
   ```

2. Navigate to the project folder:
   ```bash
   cd todo-api-with-cancellation-support
   ```

3. Restore the dependencies:
   ```bash
   dotnet restore
   ```

4. Run the project:
   ```bash
   dotnet run
   ```

5. The API will be accessible at `http://localhost:5000`.

### Running Tests

Tests can be run using the following command:
```bash
dotnet test
```

## Contributing

1. Fork this repository.
2. Create a new branch (`git checkout -b feature-name`).
3. Make your changes.
4. Commit your changes (`git commit -am 'Add new feature'`).
5. Push to the branch (`git push origin feature-name`).
6. Create a pull request.

## License

This project is licensed under the **MIT License** - see the [LICENSE](LICENSE) file for details.

## Acknowledgements

- **.NET Core**: For providing a powerful platform to build scalable APIs.
- **gRPC**: For efficient, low-latency communication in distributed systems.

---

Feel free to contribute or use this API as a base for building your own gRPC-based applications!
```

### Key Elements of the README:

1. **Overview**: A brief introduction to the project and its key features, including cancellation token support.
2. **API Endpoints**: A section outlining the available API endpoints, their HTTP methods, and descriptions.
3. **Project Setup**: Instructions on how to set up and run the project locally.
4. **Testing**: How to run tests if applicable.
5. **Contributing**: Instructions for others to contribute to the project.
6. **License**: Information about the license under which the project is distributed.

Make sure to replace `https://github.com/yourusername/todo-api-with-cancellation-support.git` with the actual URL of your repository.

# Employee Management API - Postman Testing Guide

## Base URL
```
https://localhost:5044/api
```

## Authentication Required
All employee endpoints require authentication. You'll need to register/login first.

## 1. Authentication Endpoints

### Register a New User
- **Method**: POST
- **URL**: `https://localhost:5044/api/AuthApi/register`
- **Headers**: 
  ```
  Content-Type: application/json
  ```
- **Body** (JSON):
  ```json
  {
    "email": "test@example.com",
    "password": "Test123!",
    "confirmPassword": "Test123!"
  }
  ```
- **Expected Response**: 200 OK
  ```json
  {
    "message": "User registered successfully",
    "userId": "guid-here"
  }
  ```

### Login
- **Method**: POST
- **URL**: `https://localhost:5044/api/AuthApi/login`
- **Headers**: 
  ```
  Content-Type: application/json
  ```
- **Body** (JSON):
  ```json
  {
    "email": "test@example.com",
    "password": "Test123!"
  }
  ```
- **Expected Response**: 200 OK
  ```json
  {
    "message": "Login successful",
    "userId": "guid-here",
    "email": "test@example.com"
  }
  ```

### Logout
- **Method**: POST
- **URL**: `https://localhost:5044/api/AuthApi/logout`
- **Headers**: 
  ```
  Content-Type: application/json
  ```
- **Expected Response**: 200 OK
  ```json
  {
    "message": "Logout successful"
  }
  ```

## 2. Employee CRUD Operations

**Important**: After logging in, Postman should automatically handle the authentication cookie for subsequent requests.

### Get All Employees
- **Method**: GET
- **URL**: `https://localhost:5044/api/EmployeesApi`
- **Headers**: None required (cookies handled automatically)
- **Expected Response**: 200 OK
  ```json
  [
    {
      "employeeId": 1,
      "fullName": "John Wick",
      "email": "john.doe@company.com",
      "position": "HR Manager",
      "department": "Human Resources",
      "phone": "123-456-7890",
      "hireDate": "2020-01-15T00:00:00",
      "updatedBy": "System",
      "updated": "2024-08-01T10:30:00"
    }
  ]
  ```

### Get Employee by ID
- **Method**: GET
- **URL**: `https://localhost:5044/api/EmployeesApi/1`
- **Expected Response**: 200 OK (single employee object)

### Create New Employee
- **Method**: POST
- **URL**: `https://localhost:5044/api/EmployeesApi`
- **Headers**: 
  ```
  Content-Type: application/json
  ```
- **Body** (JSON):
  ```json
  {
    "fullName": "Alice Johnson",
    "email": "alice.johnson@company.com",
    "position": "Software Engineer",
    "department": "Information Technology",
    "phone": "555-123-4567",
    "hireDate": "2024-08-01"
  }
  ```
- **Expected Response**: 201 Created
  ```json
  {
    "employeeId": 6,
    "fullName": "Alice Johnson",
    "email": "alice.johnson@company.com",
    "position": "Software Engineer",
    "department": "Information Technology",
    "phone": "555-123-4567",
    "hireDate": "2024-08-01T00:00:00",
    "updatedBy": "test@example.com",
    "updated": "2024-08-01T10:30:00"
  }
  ```

### Update Employee
- **Method**: PUT
- **URL**: `https://localhost:5044/api/EmployeesApi/6`
- **Headers**: 
  ```
  Content-Type: application/json
  ```
- **Body** (JSON):
  ```json
  {
    "employeeId": 6,
    "fullName": "Alice Smith",
    "email": "alice.smith@company.com",
    "position": "Senior Software Engineer",
    "department": "Information Technology",
    "phone": "555-123-4567",
    "hireDate": "2024-08-01"
  }
  ```
- **Expected Response**: 204 No Content

### Delete Employee
- **Method**: DELETE
- **URL**: `https://localhost:5044/api/EmployeesApi/6`
- **Expected Response**: 204 No Content

## 3. Testing Scenarios

### Scenario 1: Complete Workflow
1. Register a new user
2. Login with the user
3. Get all employees
4. Create a new employee
5. Get the newly created employee
6. Update the employee
7. Delete the employee
8. Logout

### Scenario 2: Error Testing
1. Try accessing employees without authentication (should get 401)
2. Try creating employee with invalid data (should get 400)
3. Try updating non-existent employee (should get 404)
4. Try deleting non-existent employee (should get 404)

## 4. Postman Collection Setup

### Creating a Collection
1. Open Postman
2. Create a new Collection called "Employee Management API"
3. Add all the requests above to the collection

### Setting Up Environment Variables
1. Create a new Environment called "Employee API"
2. Add variables:
   - `baseUrl`: `https://localhost:5044/api`
   - `userEmail`: `test@example.com`
   - `userPassword`: `Test123!`

### Using Variables in Requests
- Replace `https://localhost:5044/api` with `{{baseUrl}}`
- Use `{{userEmail}}` and `{{userPassword}}` in login requests

## 5. Common Response Codes

- **200 OK**: Request successful
- **201 Created**: Resource created successfully
- **204 No Content**: Request successful, no response body
- **400 Bad Request**: Invalid request data
- **401 Unauthorized**: Authentication required
- **404 Not Found**: Resource not found
- **500 Internal Server Error**: Server error

## 6. Notes

- Make sure the application is running before testing
- Authentication uses cookies, so keep the same session in Postman
- The `EmployeeId` is auto-generated, don't include it in POST requests
- Dates should be in ISO format: "YYYY-MM-DD"
- All employee endpoints require authentication
- The `UpdatedBy` and `Updated` fields are automatically set by the API

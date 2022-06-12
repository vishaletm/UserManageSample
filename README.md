# UserManageSample



![UserManageSample workflow](https://github.com/vishaletm/UserManageSample/actions/workflows/dotnet.yml/badge.svg)

For the ease of access   
**Swagger**: API Documentation & Design Tool is implimented which will be the default landing page of the application

**Dependency injection** implimented

All the requirements are imlimented as **APIs**, urls are detailed below and the same can be accessed and easily tested using Swagger.

Build Pipeline is implimented using [**Github Action**](https://github.com/vishaletm/UserManageSample/actions)

Seed data is provided using Static Class **UserContext,** data can be altered there.

3 Layers are implimented - 1. Repository, 2. Business, 3. UI/API Layer

![alt text](https://github.com/vishaletm/UserManageSample/raw/main/.github/Screenshot.PNG)

1\. Provide the C# classes to modelize those users  
2\. Given a list of users as input parameter, write the necessary classes/methods to be  
able to:

1.  Return all women having age  25 -
    
        https://localhost:7101/api/GetFemalesBelow25
    
2.  Return the joungest man -
    
        https://localhost:7101/api/GetYoungestMale
    
3.  Return all men having age  40 - 
    
        https://localhost:7101/api/GetMaleAbove40
    
4.  Return all women having the Manage and Admin role - 
    
        https://localhost:7101/api/GetAllAdminManagerFemale
    
5.  Return all Managers having firstname starting with "Jo" - 
    
        https://localhost:7101/api/GetAllManagerNameStartWithJo
    
6.   Create a file with one line per user with the following info  
        1. {Firtsname} {Lastname} is {Age} old. It is a {man/woman}.            He  has the following roles (Manager,Employee,Admin) - 
    
        https://localhost:7101/api/ExportUserData
        
        File path will be returned from API

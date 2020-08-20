# db_example
Simple program that connects to a local MySQL database

**Requires:**
- MySQLConnector/NET 8.0.21

###### Database Setup

A MySQL Database Server need to be set up with a specific database and table to interface with the program.

**Requires:**
- MySQLServer 8.0.21
- MySQL Shell 8.0.21

1. Create a new database named `hello`
```CREATE DATABASE hello;```
```USE hello;```
2. Create a new table named `mytable` with a char(255) **name** field, and an integer **age** field
```CREATE TABLE mytable (name char(255), age int);```

Done.

C# Programming Exercise 2

> Projects written on C# 7.3, .NET Framework 4.7.2 Microsoft Visual Studio Community 2019

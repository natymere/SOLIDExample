# Open Closed Principle

- Software entities such as classes, modules, functions, should open for extension but closed for modification. 

## Implementation Guidelines
- The simplest way to implement OCP is to implement new functionality on **new derived class**
- Allow clients to access the original class with abstract interface

## If not followed...
- Have to test the entire functionality
- QA team needs to test the entire flow
- Costly process for the organisation
- Break single responsibility as well
- Maintenance overheads increases on the class

# Liskov Substitution Principle

- Derived types must be completely substitutable for their base types
- Extension of the Open closed principle 

## Implementation guideline
- No new exceptions can be thrown by the subtype durin substitution
- Client should not know which specific subtype they are calling (abstraction do not shows the specific subtype)
- New derived classes just extend without replacing the functionality of old classes

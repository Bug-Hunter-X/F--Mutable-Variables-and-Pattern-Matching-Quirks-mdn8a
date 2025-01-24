# Uncommon F# Bugs

This repository demonstrates a couple of less common errors that can occur in F#, particularly when dealing with mutable variables within functions and using pattern matching in unexpected ways.

## Bug 1: Mutable Variable Scope in Functions

In F#, mutable variables are generally discouraged within functions, but if you encounter situations where you must use them, it is important to understand their scope and how they behave with function calls. 
The 'swap2' and related examples show that when you return a tuple containing the values of the mutable variables, the values are returned correctly, but they are not reflected in the original variables.

## Bug 2: Pattern Matching and Function Application

The 'add2' function illustrates how pattern matching can lead to issues if you are not careful about how you specify your function application.  The pattern matching syntax might lead to unexpected errors if the function's structure doesn't align perfectly with what's expected by the compiler.

## How to Reproduce

Clone the repository and run the F# code in a suitable environment (e.g., using the F# Interactive).  Observe the outputs and how they vary from what is initially expected.

## Solution

The `bugSolution.fs` file offers a clearer, more idiomatic F# approach to addressing the bugs.
Specifically, for the mutable variables, avoiding them is often better.
For the pattern matching, make sure it aligns with the parameters and return value.

## License

[MIT](https://opensource.org/licenses/MIT)
# \# .NET Command-Line Calculator

# 

# A simple .NET console application that performs arithmetic operations using command-line arguments.

# 

# ---

# 

# \## Description

# 

# This program accepts three command-line arguments: two integer operands and one operator (`+`, `-`, `\*`, `/`).  

# It performs the specified arithmetic operation and prints the result.  

# It also handles common errors like missing arguments, invalid numbers, unknown operators, and division by zero.

# 

# ---

# 

# \## Steps to Run

# 

# 1\. Clone the repository:

# &nbsp;  git clone https://github.com/skeleton111222/Dot-net-Command-line-argument

# 

# 2\. Navigate to the project folder:

# &nbsp;  cd Dot-net-Command-line-argument

# 

# 3\. Run the application using the following format:

# &nbsp;  dotnet run <a> <b> <operator>

# 

# &nbsp;  - `a` and `b` are integer operands  

# &nbsp;  - `operator` is one of `+`, `-`, `\*`, `/`

# 

# ---

# 

# \## Example Runs

# 

# Addition:

# dotnet run 2 3 +

# Output:

# 5

# 

# Subtraction:

# dotnet run 5 2 -

# Output:

# 3

# 

# Multiplication:

# dotnet run 4 3 \*

# Output:

# 12

# 

# Division:

# dotnet run 10 2 /

# Output:

# 5

# 

# Division by Zero:

# dotnet run 5 0 /

# Output:

# Cannot divide by zero.

# 

# ---

# 

# \## Error Handling

# 

# \- Not enough arguments: Not enough arguments were provided.

# \- Invalid numbers: error: Input string was not in a correct format.

# \- Unknown operator: Unknown operator.

# 

# ---

# 

# \## Supported Operators

# 

# | Operator | Description    |

# |---------|----------------|

# | `+`     | Addition       |

# | `-`     | Subtraction    |

# | `\*`     | Multiplication |

# | `/`     | Division       |

# 

# ---

# 

# \## Notes

# 

# \- All arguments must be provided in a single line.  

# \- If your shell requires, you can use: dotnet run -- <a> <b> <operator>  

# \- This program uses basic error handling for exceptions like invalid input and division by zero.

# 

# ---

# 

# \## Requirements

# 

# \- .NET SDK 6.0 or later  

# \- Command-line interface (Command Prompt, Terminal, or PowerShell)

# 

# ---


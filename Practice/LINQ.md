# LINQ Practice Tasks

## Elementary 🔥

These tasks cover various LINQ methods
like `Sum()`, `Where()`, `OrderBy()`, `Count()`, `Max()`, `Distinct()`, `FirstOrDefault()`, and `Aggregate()`, offering
a practical way to enhance your LINQ skills.

Here's a table with a brief description of each LINQ method and links to their MSDN documentation:

| Method             | Description                                                            | MSDN Link                                                                                            |
|--------------------|------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|
| `Sum()`            | Calculates the sum of a sequence of numeric values.                    | [Sum](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum)                       |
| `Where()`          | Filters a sequence based on a predicate.                               | [Where](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where)                   |
| `OrderBy()`        | Sorts the elements of a sequence in ascending order.                   | [OrderBy](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby)               |
| `Count()`          | Counts the elements in a sequence, optionally with a predicate.        | [Count](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count)                   |
| `Max()`            | Finds the maximum value in a sequence.                                 | [Max](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.max)                       |
| `Distinct()`       | Returns distinct elements from a sequence.                             | [Distinct](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.distinct)             |
| `FirstOrDefault()` | Returns the first element of a sequence, or a default value if empty.  | [FirstOrDefault](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.firstordefault) |
| `Aggregate()`      | Applies an accumulator function over a sequence.                       | [Aggregate](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.aggregate)           |

### Task 1: Find the Sum

**Description**: Given an array of integers, find the sum of all elements.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
var sum = 0;
Console.WriteLine("Sum: " + sum);
```

### Task 2: Get Even Numbers

**Description**: From an integer array, create a new array containing only even numbers.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
var evenNumbers = new[] {};
Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));
```

### Task 3: Sort Strings Alphabetically

**Description**: Sort a string array in alphabetical order.

```csharp
string[] strings = { "apple", "orange", "banana" };
var sortedStrings = strings;
Console.WriteLine("Sorted: " + string.Join(", ", sortedStrings));
```

### Task 4: Count Specific Element

**Description**: Count how many times a specific number appears in an integer array.

```csharp
int[] numbers = { 1, 2, 2, 3, 4, 2 };
var count = numbers;
Console.WriteLine("Count of 2: " + count);
```

### Task 5: Filter by Length

**Description**: Find all strings in an array with a length greater than 3.

```csharp
string[] strings = { "hi", "hello", "world", "yes", "no" };
var longStrings = strings;
Console.WriteLine("Strings longer than 3: " + string.Join(", ", longStrings));
```

### Task 6: Find Maximum Value

**Description**: Find the maximum value in an integer array.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
var max = 0;
Console.WriteLine("Max: " + max);
```

### Task 7: Concatenate Strings

**Description**: Concatenate all strings in an array into a single string. Do not use `string.Join()` as a solution. It
allows to achieve the goal, but it's not a part of LINQ

```csharp
string[] strings = { "apple", "orange", "banana" };
var concatenated = string.Join("", strings);
Console.WriteLine("Concatenated: " + concatenated);
```

### Task 8: Distinct Elements

**Description**: Create a new array of distinct elements from an integer array.

```csharp
int[] numbers = { 1, 2, 2, 3, 4, 2 };
var distinctNumbers = numbers;
Console.WriteLine("Distinct: " + string.Join(", ", distinctNumbers));
```

### Task 9: First Element or Default

**Description**: Get the first element of an integer array, or a default value if empty.

```csharp
int[] numbers = { 1, 2, 3, 4, 5 };
var firstOrDefault = 0;
Console.WriteLine("First or Default: " + firstOrDefault);
```

### Task 10: Aggregate Strings

**Description**: Aggregate elements of a string array into a single string, separated by a comma.

```csharp
string[] strings = { "apple", "orange", "banana" };
var aggregated = string.Join(", ", strings);
Console.WriteLine("Aggregated: " + aggregated);
```

## Easy 🔥🔥

TBA

## Medium 🔥🔥🔥

TBA

## Advanced 🔥🔥🔥🔥

TBA

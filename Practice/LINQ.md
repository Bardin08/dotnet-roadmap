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


| LINQ Method        | Description                                                                    | MSDN Link                                                                                                 |
|--------------------|--------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------|
| Where              | Filters a sequence of values based on a predicate                              | [Where](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where)                         |
| Select             | Projects each element of a sequence into a new form                            | [Select](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.select)                       |
| OrderBy            | Sorts the elements of a sequence in ascending order                            | [OrderBy](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby)                     |
| OrderByDescending  | Sorts the elements of a sequence in descending order                           | [OrderByDescending](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderbydescending) |
| GroupBy            | Groups the elements of a sequence based on a key selector                      | [GroupBy](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.groupby)                     |
| Join               | Joins two sequences based on matching keys                                     | [Join](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.join)                           |
| Count              | Returns the number of elements in a sequence                                   | [Count](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count)                         |
| Any                | Determines whether any element of a sequence satisfies a condition             | [Any](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.any)                             |
| Take               | Returns a specified number of contiguous elements from the start of a sequence | [Take](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.take)                           |
| Distinct           | Returns distinct elements from a sequence                                      | [Distinct](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.distinct)                   |

### Task 1: Filter Even Numbers

**Description**: Filter a list of integers to select only even numbers.

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var evenNumbers = ___;
Console.WriteLine(string.Join(",", evenNumbers))
```

### Task 2: Find Longest Word

**Description**: Find the longest word in a list of strings.

```csharp
List<string> words = new List<string> { "apple", "banana", "orange", "grapefruit" };
var longestWord = ___;
Console.WriteLine("Longest word: " + longestWord);
```

### Task 3: Calculate Average

**Description**: Calculate the average of a list of decimal numbers.

```csharp
List<decimal> decimals = new List<decimal> { 2.5m, 3.7m, 1.9m, 4.2m };
var average = ___;
Console.WriteLine("Average: " + average);
```

### Task 4: Group by Property

**Description**: Group a list of objects by a specific property.

```csharp
public record Person(string name, int age, string country);

List<Person> people = new List<Person>
{
    new Person { Name = "Alice", Age = 25, Country = "USA" },
    new Person { Name = "Bob", Age = 30, Country = "UK" },
    new Person { Name = "Charlie", Age = 22, Country = "USA" },
    new Person { Name = "David", Age = 35, Country = "Canada" },
    new Person { Name = "Emily", Age = 28, Country = "UK" }
};

var grouped = ___;
foreach (var group in grouped)
{
    Console.WriteLine("Group: " + group.Key);
    foreach (var item in group)
    {
        Console.WriteLine(item);
    }
}
```

### Task 5: Join Lists

**Description**: Join two lists based on a common property.

```csharp
public record Person(string name, int age, string country);

List<Person> people1 = new List<Person>
{
    new Person { Name = "Alice", Country = "USA" },
    new Person { Name = "Bob", Country = "UK" },
    new Person { Name = "Charlie", Country = "USA" }
};

List<Person> people2 = new List<Person>
{
    new Person { Name = "David", Country = "Canada" },
    new Person { Name = "Emily", Country = "UK" }
};

var joined = ___;
foreach (var pair in joined)
{
    Console.WriteLine($"Item from list 1: {pair.Item1}, Item from list 2: {pair.Item2}");
}
```

### Task 6: Sort Alphabetically

**Description**: Sort a list of strings alphabetically.

```csharp
List<string> strings = new List<string> { "banana", "apple", "orange", "grape" };
var sorted = ___;
Console.WriteLine(string.Join(",", sorted))
```

### Task 7: Select Distinct

**Description**: Select distinct elements from a list.

```csharp
List<int> numbers = new List<int> { 1, 2, 2, 3, 3, 4, 4, 5, 5 };
var distinctNumbers = ___;
Console.WriteLine(string.Join(",", distinctNumbers))
```

### Task 8: Retrieve Top 5 Highest Values

**Description**: Retrieve the top 5 highest values from a list of integers.

```csharp
List<int> numbers = new List<int> { 10, 5, 8, 3, 12, 15, 6, 7, 9, 2 };
var top5 = ___;
Console.WriteLine(string.Join(",", top5))
```

### Task 9: Check Condition

**Description**: Check if any element in a list satisfies a specific condition.

```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
var anyGreaterThan3 = ___;
Console.WriteLine("Any number greater than 3: " + anyGreaterThan3);
```

### Task 10: Convert to Uppercase

**Description**: Convert a list of strings to uppercase.

```csharp
List<string> words = new List<string> { "apple", "banana", "orange" };
var uppercasedWords = ___;
Console.WriteLine(string.Join(",", uppercasedWords`))
```

## Medium 🔥🔥🔥

TBA

## Advanced 🔥🔥🔥🔥

TBA

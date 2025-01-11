# LINQ Practice Tasks

## Elementary 🔥

These tasks cover various LINQ methods
like `Sum()`, `Where()`, `OrderBy()`, `Count()`, `Max()`, `Distinct()`, `FirstOrDefault()`, and `Aggregate()`, offering
a practical way to enhance your LINQ skills.

Here's a table with a brief description of each LINQ method and links to their MSDN documentation:

| Method             | Description                                                           | MSDN Link                                                                                            |
|--------------------|-----------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|
| `Sum()`            | Calculates the sum of a sequence of numeric values.                   | [Sum](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.sum)                       |
| `Where()`          | Filters a sequence based on a predicate.                              | [Where](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where)                   |
| `OrderBy()`        | Sorts the elements of a sequence in ascending order.                  | [OrderBy](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby)               |
| `Count()`          | Counts the elements in a sequence, optionally with a predicate.       | [Count](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count)                   |
| `Max()`            | Finds the maximum value in a sequence.                                | [Max](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.max)                       |
| `Distinct()`       | Returns distinct elements from a sequence.                            | [Distinct](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.distinct)             |
| `FirstOrDefault()` | Returns the first element of a sequence, or a default value if empty. | [FirstOrDefault](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.firstordefault) |
| `Aggregate()`      | Applies an accumulator function over a sequence.                      | [Aggregate](https://learn.microsoft.com/en-us/dotnet/api/system.linq.enumerable.aggregate)           |

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

| LINQ Method       | Description                                                                    | MSDN Link                                                                                                 |
|-------------------|--------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------|
| Where             | Filters a sequence of values based on a predicate                              | [Where](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.where)                         |
| Select            | Projects each element of a sequence into a new form                            | [Select](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.select)                       |
| OrderBy           | Sorts the elements of a sequence in ascending order                            | [OrderBy](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby)                     |
| OrderByDescending | Sorts the elements of a sequence in descending order                           | [OrderByDescending](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderbydescending) |
| GroupBy           | Groups the elements of a sequence based on a key selector                      | [GroupBy](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.groupby)                     |
| Join              | Joins two sequences based on matching keys                                     | [Join](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.join)                           |
| Count             | Returns the number of elements in a sequence                                   | [Count](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.count)                         |
| Any               | Determines whether any element of a sequence satisfies a condition             | [Any](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.any)                             |
| Take              | Returns a specified number of contiguous elements from the start of a sequence | [Take](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.take)                           |
| Distinct          | Returns distinct elements from a sequence                                      | [Distinct](https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.distinct)                   |

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

### Task 1: Find Common Elements

**Description**: Given two lists of integers, find the common elements between them.

### Task 2: Aggregate Nested Collections

**Description**: Given a list of orders, each containing a list of order items, calculate the total cost of each order.

### Task 3: Find Top N Students

**Description**: Given a list of students with their scores, find the top N students based on their scores.

### Task 4: Group and Count

**Description**: Given a list of transactions, group them by product name and count the number of transactions for each
product.

### Task 5: Calculate Running Total

**Description**: Given a list of numbers, calculate the running total (cumulative sum) of the numbers.

### Task 6: Find Anagrams

**Description**: Given a list of strings, find all pairs of strings that are anagrams of each other.

### Task 7: Combine and Filter

**Description**: Given two lists of objects, combine them into a single list, then filter out elements based on certain
criteria.

### Task 8: Manipulate Date and Time

**Description**: Given a list of dates, find the difference in days between each consecutive pair of dates.

### Task 9: Partition Data

**Description**: Given a list of integers, partition the data into two groups: one containing even numbers and the other
containing odd numbers.

### Task 10: Handle Null Values

**Description**: Given a list of objects that may contain null values, filter out the null values and perform an
operation on the non-null values.

## Advanced 🔥🔥🔥🔥

### Tasks to Create Your Own LINQ Implementation:

1. **Understanding LINQ Operators**: Familiarize yourself with the standard LINQ operators such
   as `Where`, `Select`, `OrderBy`, `GroupBy`, etc. Understand their behavior and the expected output.

2. **Implementing Query Operators**: Start by implementing basic query operators such as `Where` and `Select`. These
   operators should filter and transform data, respectively, similar to their LINQ counterparts.

3. **Supporting Deferred Execution**: Ensure that your LINQ implementation supports deferred execution, meaning that
   query operations are not executed until the result is needed.

4. **Handling Iterators**: Implement iterators to iterate over collections and apply query operators. This involves
   implementing custom iterator methods such as `GetEnumerator`, `MoveNext`, and `Current`.

5. **Testing and Debugging**: Test your LINQ implementation thoroughly with various data sets and edge cases. Debug any
   issues that arise and ensure that the results match the expected behavior of LINQ operators.

6. **Optimizing Performance**: Optimize your LINQ implementation for performance by minimizing unnecessary iterations
   and avoiding excessive memory allocations. Use techniques such as lazy evaluation and caching to improve performance.

### Useful Resources for LINQ Concepts:

1. **Microsoft Docs**: The official documentation for LINQ provides comprehensive explanations of LINQ concepts and
   operators. [LINQ (Language-Integrated Query)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)

2. **LINQ Tutorial**: Follow a LINQ tutorial to learn how LINQ works and how to use it effectively in C#. There are many
   tutorials available online that cover LINQ basics and advanced topics.

3. **Books on LINQ**: Consider reading books dedicated to LINQ programming, such as "LINQ Pocket Reference" by Joseph
   Albahari and Ben Albahari. These books provide in-depth coverage of LINQ concepts and techniques.

### Useful Resources for Understanding Iterators and Deferred Execution:

1. **Microsoft Docs - Iterators (C# Programming Guide)**: Learn about iterators in C# and how to use them to implement
   custom enumerable collections. [Iterators (C# Programming Guide)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/iterators)

2. **Microsoft Docs - Deferred Execution (LINQ to Objects)**: Understand deferred execution in LINQ and how it impacts
   query execution. [Deferred Execution (LINQ to Objects)](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/deferred-execution-linq-to-objects)

### Avoiding Tons of Enumerators:

1. **Use `yield return`**: When implementing custom iterators, use the `yield return` statement to return elements one
   at a time without creating multiple enumerables.

2. **Reuse Iterators**: Instead of creating new iterators for each LINQ operation, consider reusing existing iterators
   to minimize memory overhead.

3. **Optimize Query Execution**: Combine multiple LINQ operations into a single query to avoid unnecessary iterations
   and intermediate collections.

4. **Use `IEnumerable<T>` and `IEnumerator<T>`**: Implement custom collections and iterators using the `IEnumerable<T>`
   and `IEnumerator<T>` interfaces to ensure compatibility with LINQ operators and deferred execution.

By following these tasks and utilizing the recommended resources, you can create your own LINQ implementation and gain a
deeper understanding of LINQ concepts and programming techniques in C#.
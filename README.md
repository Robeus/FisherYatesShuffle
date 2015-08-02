# FisherYatesShuffle

Generic implementation of the Fisher-Yates shuffle algorithm on C#

Works with arrays, lists and any other instances of classes that implement the IList interface

### Examples of usage:
```C#
IList<int> list = new List<string>();
list.Shuffle();
```
```C#
int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
array.Shuffle();
```

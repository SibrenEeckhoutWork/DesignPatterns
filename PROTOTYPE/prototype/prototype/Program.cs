using prototype;

Tree originalTree = new Tree("Oak", 10, "Green");

// Clone using Shallow Copy
Tree shallowClone = originalTree.Clone();
Console.WriteLine("Shallow Clone:");
Console.WriteLine(shallowClone);

// Clone using Deep Copy
Tree deepClone = originalTree.DeepClone();
Console.WriteLine("Deep Clone:");
Console.WriteLine(deepClone);

// Modify the original object to show that deep clone is independent
originalTree.Color = "Yellow";
Console.WriteLine("Original Tree after modification:");
Console.WriteLine(originalTree);
Console.WriteLine("Deep Clone after modification of original:");
Console.WriteLine(deepClone);
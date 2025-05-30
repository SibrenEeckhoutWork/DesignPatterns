using Flyweight;

TreeFactory treeFactory = new TreeFactory();
Forest forest = new Forest(treeFactory);

// Planting trees in the forest
forest.PlantTree("Oak", "Green", "Rough", 10, 20);
forest.PlantTree("Pine", "Dark Green", "Smooth", 15, 25);
forest.PlantTree("Oak", "Green", "Rough", 30, 40);  // Same type as the first tree
forest.PlantTree("Birch", "White", "Smooth", 50, 60);

// Displaying the forest
forest.DisplayForest();


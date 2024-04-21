# Unweighted Graph 

## Overview

---

This folder contains components related to generating and visualizing undirected unweighted graphs.

## UnweightedGraph.cs

### Description

This [file](UnweightedGraph.cs/) defines the **UnweightedGraph<T>** class, which represents an undirected unweighted graph. It's the backbone of our graph implementation, providing methods for adding vertices, adding edges, and removing edges. The graph is internally represented using both an adjacency matrix and an adjacency list.

## GraphVisualization.cs

### Description

The [GraphVisualization.cs](GraphVisualization.cs/) file consists of the **GraphVisualization** class, which provides methods to visualize the adjacency matrix and adjacency list representations of the unweighted graph. The **PrintUnweightedMatrix** method prints the adjacency matrix, while the **PrintUnweightedList** method prints the adjacency list.

## GraphGenerator.cs

### Description

The [GraphGenerator.cs](GraphGenerator.cs/) file contains the **GraphGenerator** class, which provides a method to generate a random undirected unweighted graph based on the Erdős–Rényi model. The **GenerateGraph** method takes an instance of **UnweightedGraph<int>** and a **probability** value as input. It randomly adds edges between vertices based on the probability value.



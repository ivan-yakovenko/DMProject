# Algorithms 

## Overview

---

This folder contains implementations of two fundamental graph traversal algorithms: Breadth-First Search (BFS) and Depth-First Search (DFS).


## BFS

### Description

**BFS (Breadth-First Search)** is a graph traversal algorithm that explores all the neighbor vertices at the present depth prior to moving on to the vertices at the next depth level. It is implemented here in the [BFS.cs](BFS.cs/) file.

### Functionality

The **BFSUse** method in [BFS.cs](BFS.cs/) takes an unweighted undirected graph and a starting vertex as input. It performs BFS traversal starting from the given vertex, marking visited vertices and enqueueing neighboring vertices to a queue. The algorithm continues until all reachable vertices are visited.

---

## DFS

### Description

**DFS (Depth-First Search)** is another graph traversal algorithm that explores as far as possible along each branch before backtracking. It is implemented in the [DFS.cs](DFS.cs/) file.

### Functionality

The **DFSUse** method in [DFS.cs](DFS.cs/) also takes an unweighted undirected graph and a starting vertex as input. It performs DFS traversal starting from the given vertex, marking visited vertices and pushing neighboring vertices to a stack. The algorithm continues until all reachable vertices are visited.


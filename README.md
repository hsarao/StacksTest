# StacksTest
C# program to read read in a file containing a maze and find an exit out of that maze by performing a Depth First Search.

# Classes
# Point Class - describes a point the maze(numeric row and column coordinates).

# Public Methods of Point Class
Point(row, column) - Constructor, initializes private row and column fields using parameter values, getRow() - Returns private row field value, getColumn() - Returns private column field value, toString() - Point will appear as: [row,column]. (e.g. [2,3]).

# Node Class accepts any generic type as data. It returns the object in the same format as stored.It maintains two links per node (previous and next).

# Public Methods of Node Class: 
Node() - Constructor, initializes private fields to default values, Node(element) - Constructor, initializes only the passed parameter, Node(element, previousNode,nextNode) - Constructor, initializes private fields using parameter values, getElement() - returns the element (data), getPrevious() - Returns the reference to previous node, getNext() - Returns the reference to next node, setElement() - sets the element (data), setPrevious() - sets the reference to previous node, setNext() - sets the reference to next node

# Stack Class handles any generic type as data and maintains head, the point to the top node in the stack or null if there are no nodes. It also maintains size which the count of the number of nodes in the list.

# Public Methods of Stack Class
Stack()- Constructor, initializes private fields for size and head, push(element)	- Creates a new Node with the new element and adds it to the top of the stack, top() - Returns the top element on the stack without removing it from the data structure, pop()- Returns the top element on the stack, removing it from the data structure, clear() - Empty all elements from the list, getSize()	Getter for the private size field, getHead() - Returns the top Node, isEmpty() - Return true if the list is empty, else return false

# Maze Class keep tack of the maze details. It Contains information about the starting Point, and the row/column lengths. It maintains a 2d character array (charMaze[][]) and can read in a .maze file and print off to the screen. It contains a method for performing a depth first search and returning a Stack of the points used to traverse from the Start Point to End Point. 

# Public Methods of Maze Class
Maze(fileName) - Constructor reads a specified file while populating maze details, Maze(startingRow, startingColumn, existingMaze)	Constructor, assigns the starting point based on the passed Row/Column values.  Assigns internal charMaze variable to the passed existingMax value, getStartingPoint() - Returns the private field, getRowLength() - Returns the number of rows in the maze, getColumnLength() - Returns the number of columns in the maze, getMaze() - Returns the charMaze array, printMaze() -	Print the maze from the charArray private variable.
# depthFirstSearch() Method 
It performs a depth first search using the starting point values obtained in the constructor. The direction to take in the algorithm will be SOUTH, EAST, WEST, NORTH. (SEWN) and it marks visited Points as ‘V’ in the maze. The path taken from starting point to ending point will be indicated by changing the character from ‘V’ to ‘.’ A Stack variable will be created and stored locally (obtained from called the getPathToFollow() method). The stack will contain the path of the points from start to end. The starting point should be on Top and the ending point on the bottom. In other words, the reverse of the Stack constructed to find the exit! Note that if no Exit was found, that Stack will be empty. The returned value of this method will be a string result indicating the path to follow and a print out of the maze after exploring (see details in the below pages for formatting)

getPathToFollow()	- Returns the stack created during the search.






